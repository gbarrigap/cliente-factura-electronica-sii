using System;
using System.Configuration;

namespace FacturaElectronicaSii
{
    public static class Config
    {
        public static string CertificatePath
        {
            get
            {
                return Environment.GetEnvironmentVariable("CERT_PATH");
            }
        }

        public static string CertificatePassword
        {
            get
            {
                return Environment.GetEnvironmentVariable("CERT_PWD");
            }
        }
    }
}
