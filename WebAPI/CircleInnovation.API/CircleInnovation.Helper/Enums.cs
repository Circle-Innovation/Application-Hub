namespace CircleInnovation.Helper
{
    public class Enums
    {
        public enum ErrorSeverity { CRITICAL, MAJOR, MODERATE, MINOR, COSMETIC }
        public enum ErrorNotificationType { INFO = 250, WARNING = 150, VALIDATIONFAILURE = 450, NOCONTENT = 204, APIERROR = 512, BADREQUEST = 400, OK = 200, INTERNALSERVERERROR = 500 };
    }
}
