using CarBook.Application.Features.Mediator.Commands.BlogCommands;
using CarBook.Application.Features.Mediator.Queries.BlogQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BlogsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> BlogList()
        {
            var values = await _mediator.Send(new GetBlogQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBlogById(int id)
        {
            var value = await _mediator.Send(new GetBlogByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBlog(CreateBlogCommand command)
        {
            await _mediator.Send(command);
            return Ok("Blog information has been created.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBlog(UpdateBlogCommand command)
        {
            await _mediator.Send(command);
            return Ok("Blog information has been updated.");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBlog(int id)
        {
            await _mediator.Send(new RemoveBlogCommand(id));
            return Ok("Blog information has been deleted.");
        }

        [HttpGet("GetLast3BlogsWithAuthors")]
        public async Task<IActionResult> GetLast3BlogsWithAuthors()
        {
            var values = await _mediator.Send(new GetLast3BlogsWithAuthorsQuery());
            return Ok(values);
        } 
        [HttpGet("GetAllBlogsWithAuthors")]
        public async Task<IActionResult> GetAllBlogsWithAuthors()
        {
            var values = await _mediator.Send(new GetAllBlogsWithAuthorsQuery());
            return Ok(values);
        } 
        
        [HttpGet("GetAuthorByBlogId/{id}")]
        public async Task<IActionResult> GetAuthorByBlogId(int id)
        {
            var values = await _mediator.Send(new GetAuthorByBlogIdQuery(id));
            return Ok(values);
        } 
    }
}
