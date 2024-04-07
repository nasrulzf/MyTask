using MediatR;

namespace MyTask.Api.Application.UseCases.Categories.Queries.GetAllCategory;

public class GetAllCategoryQueryHandler : IRequestHandler<GetAllCategoryQuery, GetAllCategoryDto>
{
    public async Task<GetAllCategoryDto> Handle(GetAllCategoryQuery request, CancellationToken cancellationToken)
    {
        return await Task.FromResult(new GetAllCategoryDto{ IsSuccess = true, Messages = new List<string>{ "Ini Dummy Response." }});
    }
}