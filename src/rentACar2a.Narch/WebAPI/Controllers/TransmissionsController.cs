using Application.Features.Transmissions.Commands;
using Application.Features.Transmissions.Queries.GetList;
using Microsoft.AspNetCore.Mvc;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TransmissionsController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateTransmissionCommand createTransmissionCommand)
    {
        CreatedTransmissionResponse response = await Mediator.Send(createTransmissionCommand);

        return Created(uri: "", response);
    } 
    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListTransmissionQuery getListTransmissionQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListTransmissionItemDto> response = await Mediator.Send(getListTransmissionQuery);
        return Ok(response);
    }
}
