using Application.Features.Cars.Commands.Create;
using Application.Features.Cars.Queries.GetList;
using Microsoft.AspNetCore.Mvc;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;

namespace WebAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CarsController :BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateCarCommand createCarCommand)
    {
        CreatedCarResponse response = await Mediator.Send(createCarCommand);

        return Created(uri: "", response);
    }
    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListCarQuery getListCarQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListCarItemDto> response = await Mediator.Send(getListCarQuery);
        return Ok(response);
    }
}