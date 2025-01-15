using System.Security.Cryptography;
using System.Text;

class Program
{
    public static void Main()
    {
        try 
        { 
            Console.WriteLine("Wprowadź swoje hasło\n");
            var haslo = Console.ReadLine();

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes("HttpServiceKey1#");
                aes.IV = Encoding.UTF8.GetBytes("##HttpServiceIV#");

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(cs))
                        {
                            sw.Write(haslo);
                        }
                        Console.WriteLine(Convert.ToBase64String(ms.ToArray()));
                    }
                }
            }
        }
        catch
        {
            Console.WriteLine("Wystąpił błąd podczas szyfrowania hasła");
        }
    }
}