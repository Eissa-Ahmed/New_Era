namespace New_Era.API.Controllers.Bases
{
    [ApiController]
    public class BaseController : ControllerBase
    {
        private IMediator _mediator;
        protected IMediator mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

        public ObjectResult result<T>(ResponseModel<T> model)
        {
            switch (model.StatusCode)
            {
                case HttpStatusCode.OK:
                    return new OkObjectResult(model);
                case HttpStatusCode.Created:
                    return new CreatedResult(string.Empty, model);
                case HttpStatusCode.NotFound:
                    return new NotFoundObjectResult(model);
                case HttpStatusCode.BadRequest:
                    return new BadRequestObjectResult(model);
                case HttpStatusCode.UnprocessableEntity:
                    return new UnprocessableEntityObjectResult(model);
                default:
                    return new BadRequestObjectResult(model);

            };
        }
    }
}
