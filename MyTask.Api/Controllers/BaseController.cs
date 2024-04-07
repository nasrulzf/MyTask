using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Mytask.Api.Controllers;

public class BaseController : ControllerBase 
{
    private IMediator? _mediator;
    public IMediator Mediator => _mediator ?? (_mediator = HttpContext.RequestServices.GetRequiredService<IMediator>());
}