using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Codenation.Challenge.DTOs;
using Codenation.Challenge.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Codenation.Challenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChallengeController : ControllerBase
    {
        private readonly IChallengeService _challengeService;
        private readonly IMapper _mapper;
        public ChallengeController(IChallengeService service, IMapper mapper)
        {
            _challengeService = service;
            _mapper = mapper;

        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<IEnumerable<ChallengeDTO>> GetAll(int? userId = null, int? accelerationId = null)
        {   
            if (userId.HasValue && accelerationId.HasValue)
            {
                var challenges =_challengeService.FindByAccelerationIdAndUserId( accelerationId.Value, userId.Value);
                var retorno = _mapper.Map<List<ChallengeDTO>>(challenges);
                return Ok(retorno);
            }
            return NoContent();
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<ChallengeDTO> Post([FromBody] ChallengeDTO value)
        {
            var challenge = _mapper.Map<Models.Challenge>(value);
            var retorno = _challengeService.Save(challenge);
            return Ok(_mapper.Map<ChallengeDTO>(retorno));
        }
    }

}
