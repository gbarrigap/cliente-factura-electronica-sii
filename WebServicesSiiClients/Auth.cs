using Sii.Auth;
using System.Threading.Tasks;

namespace WebServicesSiiClients
{
    public class Auth
    {
        private readonly CrSeedClient client;

        public Auth()
        {
            client = new CrSeedClient();
        }

        public async Task<string> ObtenerSemillaAsync()
        {
            var seed = await client.getSeedAsync();

            return seed;
        }
    }
}
