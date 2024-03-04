using Application.Features.Models.Commands;
using Application.Features.Models.Queries.GetList;
using Microsoft.AspNetCore.Mvc;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ModelsController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateModelCommand createModelCommand)
    {
        CreatedModelResponse response = await Mediator.Send(createModelCommand);

        return Created(uri: "", response);
    }
    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListModelQuery getListModelQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListModelItemDto> response = await Mediator.Send(getListModelQuery);
        return Ok(response);
    }
}