namespace CircleInnovation.Helper
{
    public class Constants
    {
        public struct ErrorLogType
        {
            public const string DATABASE = "database";
            public const string FILE = "file";
            public const string ALL = "all";
            public const string API = "API";
        }

        public struct ResourceMessageKeys
        {
            public const string EXCEPTIOIN_DEFAULT_MSG = "Exception_DefaultMessage";
            public const string STORE_KEY_INVALID = "StoreKey_Invalid";
            public const string REGISTER_KEY_INVALID = "RegisterKey_Invalid";
            public const string REGISTER_IP_INVALID = "MachineIP_Invalid";
            public const string STORE_IP_INVALID = "PublicIP_Invalid";
            public const string VALID = "Machine_Valid";
            public const string REGISTER_IP_UNAUTHORIZED = "MachineIP_UnAuthorized";
            public const string STORE_IP_UNAUTHORIZED = "PublicIP_UnAuthorized";
            public const string USER_UNAUTHORIZED = "User_UnAuthorized";
            public const string STORE_NOT_FOUND = "Store_NotFound";
            public const string NO_STORE_AVAILABLE = "NoStore_Available";
            public const string STORE_IP_ALREADY_EXISTS = "StoreIp_Already_Exists";
        }
    }
}
