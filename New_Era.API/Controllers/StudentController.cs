using New_Era.Core.Features.StudentFeature.Command.Model;
using New_Era.Data.Router;

namespace New_Era.API.Controllers
{
    [ApiController]
    public class StudentController : BaseController
    {
        [HttpGet(Router.StudentRouter.GetAllAsync)]
        public async Task<IActionResult> GetAllAsync(int? Page = null, int? ItemForPage = null)
        {
            var data = await mediator.Send(new GetAllAsyncStudentQuery(Page: Page, ItemForPage: ItemForPage));
            return result(data);
        }

        [HttpGet(Router.StudentRouter.GetByIdAsync)]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var data = await mediator.Send(new GetByIdAsyncStudentQuery(id));
            return result(data);
        }

        [HttpPost(Router.StudentRouter.AddAsync)]
        public async Task<IActionResult> AddAsync(AddStudentAsyncCommand model)
        {
            var data = await mediator.Send(model);
            return result(data);
        }
        [HttpPut(Router.StudentRouter.UpdateAsync)]
        public async Task<IActionResult> UpdateAsync(UpdateStudentAsyncCommand model)
        {
            var data = await mediator.Send(model);
            return result(data);
        }
    }
}
