using System;
using System.Text;

namespace FacturaElectronicaSii
{
    public static class Config
    {
        public static string CertificatePath
        {
            get
            {
                return Encoding.UTF8.GetString(
                    Convert.FromBase64String(
                        Environment.GetEnvironmentVariable("CERT_PATH")));
            }
        }

        public static string CertificatePassword
        {
            get
            {
                return Encoding.UTF8.GetString(
                    Convert.FromBase64String(
                        Environment.GetEnvironmentVariable("CERT_SECRET")));
            }
        }
    }
}
