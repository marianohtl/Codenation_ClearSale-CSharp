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
    public class AccelerationController : ControllerBase
    {
        private readonly IAccelerationService _acceletarionService;
        private readonly IMapper _mapper;
        public AccelerationController(IAccelerationService service, IMapper mapper)
        {
            _acceletarionService = service;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<IEnumerable<AccelerationDTO>> GetAll(int? companyId = null)
        {
            
            if (companyId.HasValue)
            {
                var acceleration = _acceletarionService.FindByCompanyId(companyId.Value);
                var retorno = _mapper.Map<List<AccelerationDTO>>(acceleration);
                return Ok(retorno);
            }
            return NoContent();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<AccelerationDTO> Get(int? companyId = null)
        {
            AccelerationDTO retorno;
            if (companyId.HasValue)
            {
                var acceleration = _acceletarionService.FindById(companyId.Value);
                retorno = _mapper.Map<AccelerationDTO>(acceleration);
                return Ok(retorno);
            }
            return NoContent();
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<AccelerationDTO> Post([FromBody] AccelerationDTO value)
        {
            var acceleration = _mapper.Map<Acceleration>(value);
            var retorno = _acceletarionService.Save(acceleration);
            return Ok(_mapper.Map<AccelerationDTO>(retorno));
        }


    }
}
