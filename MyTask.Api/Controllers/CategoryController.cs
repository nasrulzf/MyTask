using Microsoft.AspNetCore.Mvc;
using MyTask.Api.Application.UseCases.Categories.Queries.GetAllCategory;

namespace Mytask.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoryController : BaseController
{
    [HttpGet(Name = "GetAll")]
    public async Task <GetAllCategoryDto> Get()
    {
        return await Mediator.Send(new GetAllCategoryQuery());
    }
}