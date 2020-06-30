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
    public class CandidateController : ControllerBase
    {
        private readonly ICandidateService _candidateService;
        private readonly IMapper _mapper;
        public CandidateController(ICandidateService service, IMapper mapper)
        {
            _candidateService = service;
            _mapper = mapper;
        }


        [HttpGet("{userId}/{accelerationId}/{companyId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<CandidateDTO> Get(int? accelerationId = null, int? companyId = null, int? userId = null)
        {
            if (accelerationId.HasValue && companyId.HasValue && userId.HasValue)
            {
 
                var candidate = _candidateService.FindById(accelerationId.Value, companyId.Value, userId.Value);
                var retorno = _mapper.Map<CandidateDTO>(candidate);
                return Ok(retorno);
            }
            return NoContent();
        }

        [HttpGet("id")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<IEnumerable<CandidateDTO>> GetAll(int? accelerationId = null, int? companyId = null)
        {

            if (companyId.HasValue)
            {
                var candidate = _candidateService.FindByCompanyId(companyId.Value).ToList();
                var retorno = _mapper.Map<List<CandidateDTO>>(candidate);
                return Ok(retorno);
            }

            if (accelerationId.HasValue)
            {
                var candidate = _candidateService.FindByAccelerationId(accelerationId.Value).ToList();
                var retorno = _mapper.Map<List<CandidateDTO>>(candidate);
                return Ok(retorno);
            }

            return NoContent();
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<CandidateDTO> Post([FromBody] CandidateDTO value)
        {
            var company = _mapper.Map<Candidate>(value);
            var retorno = _candidateService.Save(company);
            return Ok(_mapper.Map<CandidateDTO>(retorno));
        }



    }
}
