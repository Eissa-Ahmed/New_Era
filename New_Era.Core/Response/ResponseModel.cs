
namespace New_Era.Core.Response
{
    public class ResponseModel<T>
    {
        public HttpStatusCode StatusCode { get; set; }
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
        public T Data { get; set; }
    }
}
