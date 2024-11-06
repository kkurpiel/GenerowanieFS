using NLog;
using System.Text;
using System.Text.Json;
using WystawianieFS.Mappings;
using WystawianieFS.Services;

namespace WystawianieFS
{
    internal static class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var appsettingsFile = Path.Combine(Directory.GetCurrentDirectory(), "config.json");
            ////////////////////////////////////  ZAPIS CONNECTION STRING DO PLIKU config.json    ////////////////////////////////
            // string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=WystawianieFS_prod;Trusted_Connection=True;"; //
            // var connStrSerial = JsonSerializer.Serialize(new AppConfig() { ConnectionString = connectionString });           // 
            // using (var file = File.OpenWrite(appsettingsFile))                                                               //
            // {                                                                                                                // 
            //     var jsonBytes = Encoding.UTF8.GetBytes(connStrSerial);                                                       //
            //     file.SetLength(0);                                                                                           //
            //     file.Write(jsonBytes, 0, jsonBytes.Length);                                                                  //
            // }                                                                                                                //
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (!File.Exists(appsettingsFile))
            {
                MessageBox.Show("B³¹d po³¹czenia z baz¹ danych.");
                logger.Error("B³¹d po³¹czenia z baz¹ danych. Problemy z connection stringiem.");
                return;
            }
            var jsonS = File.ReadAllText(appsettingsFile);
            var connStrDeserial = JsonSerializer.Deserialize<AppConfig>(jsonS);

                ApplicationConfiguration.Initialize();
            NH_Service.Init(connStrDeserial.ConnectionString, 
                new List<Type>() { typeof(FSMap), typeof(CenaMap), typeof(ArchiwumCenMap), typeof(FirmaMap), typeof(FS_CenaMap), typeof(KontrahentMap), typeof(LogowanieMap), typeof(TowarMap)});
            logger.Info("Pomyœlnie nawi¹zano po³¹czenie z baz¹ danych");
            Application.Run(new FrmLogin());
            logger.Info("Program koñczy dzia³anie.");
        }
    }
}