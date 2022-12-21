using Microsoft.Extensions.Configuration;

namespace RH_PJ.Common.Base
{
    public static class ConfigurationHelper
    {
        public static IConfiguration config;
        public static void Initialize(IConfiguration Configuration)
        {
            config = Configuration;
        }
    }
}
