using Application.Features.Fuels.Commands.Create;
using Application.Features.Fuels.Queries.GetList;
using Microsoft.AspNetCore.Mvc;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FuelsController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateFuelCommand createFuelCommand)
    {
        CreatedFuelResponse response = await Mediator.Send(createFuelCommand);

        return Created(uri: "", response);
    }
    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListFuelQuery getListFuelQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListFuelItemDto> response = await Mediator.Send(getListFuelQuery);
        return Ok(response);
    }
}
