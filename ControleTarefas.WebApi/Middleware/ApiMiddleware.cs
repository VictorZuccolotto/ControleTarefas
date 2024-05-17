
using ControleTarefas.Utils.Exceptions;
using ControleTarefas.Utils.Messages;
using ControleTarefas.Utils.Responses;
using Newtonsoft.Json;
using System.Net;

namespace ControleTarefas.WebApi.Middleware
{
    public class ApiMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }catch (Exception ex)
            {
                await HandleException(context, ex);
            }
        }

        private async Task HandleException(HttpContext context, Exception ex)
        {
            var response = context.Response;
            response.ContentType = "application/json";

            var messages = new List<string>();
            HttpStatusCode statusCode;
            switch (ex)
            {
                case BusinessException:
                    messages.Add(ex.Message);
                    statusCode = HttpStatusCode.Conflict;
                    break;
                case GenericException:
                    messages.Add(ex.Message);
                    statusCode = HttpStatusCode.NotFound;
                    break;
                default:
                    messages.Add(InfraMessages.InternalServerError);
                    statusCode = HttpStatusCode.InternalServerError;
                    break;
            }
            response.StatusCode = (int)statusCode;
            await response.WriteAsync(JsonConvert.SerializeObject(new DefaultResponse(statusCode, messages)));
        }
    }
}
