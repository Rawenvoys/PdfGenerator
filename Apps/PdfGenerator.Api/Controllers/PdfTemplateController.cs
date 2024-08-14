using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PdfTemplate.Application.Queries.GetPdfTemplate;

namespace PdfGenerator.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PdfTemplateController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PdfTemplateController(IMediator mediator)
            => _mediator = mediator;

        [HttpGet("{id}")]
        public async Task<ActionResult<GetPdfTemplateResponse>> Get(Guid id)
        {
            var query = new GetPdfTemplateQuery(id);
            return await _mediator.Send(query);
        }
    }
}