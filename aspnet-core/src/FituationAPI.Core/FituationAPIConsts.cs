using FituationAPI.Debugging;

namespace FituationAPI
{
    public class FituationAPIConsts
    {
        public const string LocalizationSourceName = "FituationAPI";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "08de575167a34c2e9b86ae74eeab2247";
    }
}
