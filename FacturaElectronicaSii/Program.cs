using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace FacturaElectronicaSii
{
    class Program
    {
        //private static async System.Threading.Tasks.Task<string> GetSeedAsync()
        //{
        //    //AppContext.SetSwitch("TestSwitch.LocalAppContext.DisableCaching", true);
        //    //AppContext.SetSwitch("Switch.System.Net.DontEnableSchSendAuxRecord", true);

        //    using (var client = new Sii.Auth.CrSeedClient())
        //    {
        //        var result = await client.getSeedAsync();

        //        return result;
        //    }
        //}
        public static void Main(string[] args)
        {
            //var certData = File.ReadAllBytes(Config.CertificatePath);
            //var certPwd = Config.CertificatePassword;
            //var x509 = new X509Certificate2(certData, certPwd);

            //var seed = GetSeedAsync().Result;
            using (var client = new Sii.Auth.CrSeedClient())
            {
                var result = client.getSeed();
            }
        }
    }
}
