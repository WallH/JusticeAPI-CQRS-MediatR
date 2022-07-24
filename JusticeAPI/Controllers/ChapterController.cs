using Application.Models.Request;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JusticeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChapterController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ChapterController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(Name = "listChapter")]
        public async Task<IActionResult> Get([FromQuery] GetChapterRequestModel request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost(Name = "createChapter")]
        public async Task<IActionResult> Post([FromBody] GetArticleRequestModel request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
