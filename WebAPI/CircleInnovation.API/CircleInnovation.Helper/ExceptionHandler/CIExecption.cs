using System;
using System.Collections.Generic;
using System.Net;
using static CircleInnovation.Helper.Enums;

namespace CircleInnovation.Helper.ExceptionHandler
{
    public class CIException : Exception
    {
        public CIException()
        {
            this.StatusCode = HttpStatusCode.InternalServerError;
            this.Severity = ErrorSeverity.MINOR;
        }

        public CIException(string message, Exception e, string parameters = "", HttpStatusCode statusCode = HttpStatusCode.InternalServerError) : base(message, e)
        {
            this.ErrorMessage = message;
            this.StatusCode = statusCode;
            this.Severity = ErrorSeverity.MINOR;
            this.IsCustomException = true;
            this.Parameters = parameters;
        }

        public CIException(string message, string parameters = "", ErrorSeverity severity = ErrorSeverity.MINOR, bool isHandled = true, HttpStatusCode statusCode = HttpStatusCode.BadRequest)
        {
            this.ErrorMessage = message;
            this.IsCustomException = true;
            this.StatusCode = statusCode;
            this.Severity = severity;
            this.IsHandled = IsHandled;
            this.Parameters = parameters;
        }

        public bool IsCustomException { get; set; }
        public bool IsHandled { get; set; }
        public ErrorSeverity Severity { get; set; }
        public string Location { get; set; }
        public string Code { get; set; }
        public string ErrorMessage { get; set; }
        public string LibertyInnerException { get; set; }
        public Type LibertyGetType { get; set; }
        public string LibertyStackTrace { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public string Parameters { get; set; }
        public Dictionary<object, object> Info { get; set; }
    }
}
