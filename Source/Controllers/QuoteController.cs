using System;
using System.Collections.Generic;
using AutoMapper;
using Codenation.Challenge.Models;
using Codenation.Challenge.Services;
using Microsoft.AspNetCore.Mvc;

namespace Codenation.Challenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuoteController : ControllerBase
    {
        private readonly IQuoteService _service;
        //private readonly IMapper _mapper;

        public QuoteController(IQuoteService service)
        {
            _service = service;
            //_mapper = mapper;
        }

        // GET api/quote
        [HttpGet]
        public ActionResult<QuoteView> GetAnyQuote()
        {

            var quote = _service.GetAnyQuote();
            if (quote == null)
                return NotFound();

            var quoteView = new QuoteView
            {
                Id = quote.Id,
                Actor = quote.Actor,
                Detail = quote.Detail
            };


            return quoteView;
        }

        // GET api/quote/{actor}
        [HttpGet("{actor}")]
        public ActionResult<QuoteView> GetAnyQuote(string actor)
        {

            //var quoteView = _mapper.Map<QuoteView>(_service.GetAnyQuote(actor));

            var quote = _service.GetAnyQuote(actor);
            if (quote == null)
                return NotFound();

            var quoteView = new QuoteView
            {
                Id = quote.Id,
                Actor = quote.Actor,
                Detail = quote.Detail
            };


            return quoteView;

        }

    }
}
