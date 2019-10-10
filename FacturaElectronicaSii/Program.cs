using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace FacturaElectronicaSii
{
    class Program
    {
        public static void Main(string[] args)
        {
            var certData = File.ReadAllBytes(Config.CertificatePath);
            var certPwd = Config.CertificatePassword;
            var x509 = new X509Certificate2(certData, certPwd);

            using (var cliente = new Sii.Auth.CrSeedClient())
            {
                var semilla = cliente.getSeed();
            }
        }
    }
}
