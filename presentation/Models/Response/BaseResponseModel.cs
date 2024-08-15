using System.Net;

namespace presentation.Models.Response
{
    public class BaseResponseModel
    {
        public HttpStatusCode Status { get; set; } = HttpStatusCode.OK;
        public string Message { get; set; } = string.Empty;
    }
}
