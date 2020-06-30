using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Codenation.Challenge.DTOs;
using Codenation.Challenge.Models;
using Codenation.Challenge.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Codenation.Challenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubmissionController : ControllerBase
    {
        private readonly ISubmissionService _submissionService;
        private readonly IMapper _mapper;

        public SubmissionController(ISubmissionService service, IMapper map)
        {
            _submissionService = service;
            _mapper = map;

        }


        [HttpGet("/higherScore")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<decimal> GetHigherScore(int? challengeId = null)
        {
            var submission = _submissionService.FindHigherScoreByChallengeId(challengeId.Value);
            if (challengeId.HasValue)
                return Ok(submission);
            return NoContent();
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<IList<SubmissionDTO>> GetAll(int? challengeId, int? accelerationId)
        {

            if (challengeId.HasValue && accelerationId.HasValue)
            {
                var submission = _submissionService.FindByChallengeIdAndAccelerationId(challengeId.Value, accelerationId.Value).ToList();
                var retorno = _mapper.Map<List<SubmissionDTO>>(submission);
                return Ok(retorno);
            }
            return NoContent();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<SubmissionDTO> Post([FromBody] SubmissionDTO submissionDTO)
        {
            var submission = _mapper.Map<Submission>(submissionDTO);
            var retorno = _submissionService.Save(submission);
            return Ok(_mapper.Map<SubmissionDTO>(retorno));
        }


    }
}

