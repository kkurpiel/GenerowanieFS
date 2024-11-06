using Newtonsoft.Json;
using NLog;
using System.Net.Mail;
using System.Net;
using WystawianieFS.Models;
using WystawianieFS.Models.NBPModels;
using WystawianieFS.Models.DBModels;
using System.Text.Json;
using System.Security.Cryptography;
using System.Text;

namespace WystawianieFS.Services
{
    public class HttpService
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private static readonly byte[] Key = Encoding.UTF8.GetBytes("HttpServiceKey1#");
        private static readonly byte[] IV = Encoding.UTF8.GetBytes("##HttpServiceIV#");
        public HttpService()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var response = client.GetAsync("https://www.google.com").Result;
                    if (!response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Brak połączenia z internetem.");
                        logger.Error("Brak połączenia z internetem");
                    }
                    else
                    {
                        logger.Info("Połączenie z internetem działa");
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }
        public async Task<KursWaluty?> PobierzKursyWalut(DateTime dataWyst, string walutaKod)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var dataSpr = dataWyst.AddDays(-1);

                    while (true)
                    {
                        var dataString = dataSpr.ToString("yyyy-MM-dd");
                        var url = $"https://api.nbp.pl/api/exchangerates/rates/A/{walutaKod}/{dataString}/?format=json";

                        try
                        {
                            var response = await client.GetStringAsync(url);
                            var kursyResponse = JsonConvert.DeserializeObject<KursWalutyResponse>(response);

                            if (kursyResponse?.Rates != null && kursyResponse.Rates.Count > 0)
                            {
                                logger.Info("Pobrano kursy walut");
                                return kursyResponse.Rates[0];
                            }
                        }
                        catch (HttpRequestException ex) when (ex.Message.Contains("404"))
                        {
                            // Ignoruj 404 Not Found i przejdź do kolejnej daty
                            dataSpr = dataSpr.AddDays(-1);
                            continue;
                        }

                        if (dataSpr < dataWyst.AddMonths(-1))
                        {
                            break;
                        }
                    }
                    return null;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
                return null;
            }
        }
        public void WyslijEmail(string emailWyst, string emailKnt, FS fs)
        {
            try
            {
                var appsettingsFile = Path.Combine(Directory.GetCurrentDirectory(), "config.json");
                ////////////////////////////////////  ZAPIS HASLA DO PLIKU config.json    ///////////////////////////////////////
                // string haslo = "";                                                                            
                // string hasloSzyfr = Encrypt(haslo);
                // var jsonSprawdz = File.ReadAllText(appsettingsFile);
                // var sprawdzDeserial = System.Text.Json.JsonSerializer.Deserialize<AppConfig>(jsonSprawdz);
                // var sprawdzSerial = System.Text.Json.JsonSerializer.Serialize(sprawdzDeserial, new JsonSerializerOptions { WriteIndented = true });
                // File.WriteAllText(appsettingsFile, sprawdzSerial);                                                          
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                if (!File.Exists(appsettingsFile))
                {
                    MessageBox.Show("Błąd odczytu hasła.");
                    logger.Error("Plik konfiguracyjny nie istnieje.");
                    return;
                }
                var jsonS = File.ReadAllText(appsettingsFile);
                var passDeserial = System.Text.Json.JsonSerializer.Deserialize<AppConfig>(jsonS);
                string hasloOdszyfr = Decrypt(passDeserial.Password);


                string temat = $"{fs.Nazwa}: {fs.NumerFaktury}";
                string tresc = $"Dzień dobry,\nW załączniku przesyłam fakturę VAT o numerze {fs.NumerFaktury}.\nZ wyrazami szacunku,\nKonrad Kurpiel (173656)";
                string nazwaPliku = $"{fs.Nazwa} {fs.NumerFaktury.Replace("/", "-")}.pdf";
                string sciezkaPliku = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), nazwaPliku);

                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(emailWyst);
                    // mail.To.Add(emailKnt);
                    mail.To.Add(emailKnt);
                    mail.Subject = temat;
                    mail.Body = tresc;
                    using (Attachment zalacznik = new Attachment(sciezkaPliku))
                    {
                        mail.Attachments.Add(zalacznik);

                        using (SmtpClient smtp = new SmtpClient("smtp.office365.com", 587))
                        {
                            smtp.Credentials = new NetworkCredential(emailWyst, hasloOdszyfr);
                            smtp.EnableSsl = true;
                            smtp.Send(mail);
                            logger.Info("Wiadomość został wysłana.");
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                MessageBox.Show("Wystąpił błąd podczas wysyłania wiadomości e-mail.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string Encrypt(string haslo)
        {
            try
            {
                using (Aes aes = Aes.Create())
                {
                    aes.Key = Key;
                    aes.IV = IV;

                    ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter sw = new StreamWriter(cs))
                            {
                                sw.Write(haslo);
                            }
                            return Convert.ToBase64String(ms.ToArray());
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                logger.Error(ex.Message);
                return string.Empty;
            }
        }
        public static string Decrypt(string hasloSzyfr)
        {
            try
            {
                using (Aes aes = Aes.Create())
                {
                    aes.Key = Key;
                    aes.IV = IV;

                    ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                    using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(hasloSzyfr)))
                    {
                        using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader sr = new StreamReader(cs))
                            {
                                return sr.ReadToEnd();
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                logger.Error(ex.Message);
                return string.Empty;
            }
        }
    }
}
