namespace New_Era.Core.Response
{
    public class ResponseHandler
    {
        private readonly IStringLocalizer<Lang> localizer;
        public ResponseHandler(IStringLocalizer<Lang> localizer)
        {
            this.localizer = localizer;
        }
        public ResponseModel<T> Success<T>(T data)
        {
            return new ResponseModel<T>()
            {
                Data = data,
                IsSuccess = true,
                StatusCode = HttpStatusCode.OK,
                Message = localizer[LanguageKeys.GetData]
            };
        }
        public ResponseModel<string> Delete()
        {
            return new ResponseModel<string>()
            {
                IsSuccess = true,
                StatusCode = HttpStatusCode.OK,
                Message = localizer[LanguageKeys.DeleteData]
            };
        }
        public ResponseModel<T> Created<T>(T data)
        {
            return new ResponseModel<T>()
            {
                Data = data,
                IsSuccess = true,
                StatusCode = HttpStatusCode.Created,
                Message = localizer[LanguageKeys.CreatedData]
            };
        }
        public ResponseModel<T> BadRequest<T>(string? message = null)
        {
            return new ResponseModel<T>()
            {
                IsSuccess = false,
                StatusCode = HttpStatusCode.BadRequest,
                Message = message ?? localizer[LanguageKeys.BadRequest]
            };
        }
        public ResponseModel<string> NotFound<T>()
        {
            return new ResponseModel<string>()
            {
                IsSuccess = false,
                StatusCode = HttpStatusCode.NotFound,
                Message = localizer[LanguageKeys.NotFound]
            };
        }
    }
}
