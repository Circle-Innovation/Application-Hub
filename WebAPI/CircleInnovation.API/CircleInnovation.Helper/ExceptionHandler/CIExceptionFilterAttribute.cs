using CircleInnovation.Helper.Resources;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Filters;
using static CircleInnovation.Helper.Constants;
using static CircleInnovation.Helper.Enums;

namespace CircleInnovation.Helper.ExceptionHandler
{
    public class CIExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext context)
        {
            CIException ex;

            if (context.Exception.GetType() != typeof(CIException))
            {
                ex = CIExceptionHandler.HandleError(context.Exception);
            }
            else
            {
                ex = context.Exception as CIException;
            }

            if (ex.IsCustomException)
            {
                throw new HttpResponseException(context.Request.CreateErrorResponse(ex.StatusCode, ex.ErrorMessage));
            }
            else
            {
                throw new HttpResponseException(context.Request.CreateErrorResponse((HttpStatusCode)ErrorNotificationType.VALIDATIONFAILURE, ResourceHelper.GetMessage(ResourceMessageKeys.EXCEPTIOIN_DEFAULT_MSG)));
            }

        }
    }
}
