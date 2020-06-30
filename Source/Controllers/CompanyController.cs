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
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        private readonly IMapper _mapper;
        public CompanyController(ICompanyService service, IMapper mapper)
        {
            _companyService = service;
            _mapper = mapper;

        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<CompanyDTO> Get(int? id = null)
        {
            CompanyDTO retorno;
            if (id.HasValue)
            {

                var company = _companyService.FindById(id.Value);
                retorno = _mapper.Map<CompanyDTO>(company);
                return Ok(retorno);
            }

            return NoContent();
        }



        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<IEnumerable<CompanyDTO>> GetAll(int? accelerationId = null, int? userId = null)
        { 
            if (accelerationId.HasValue)
            {
                var company = _companyService.FindByAccelerationId(accelerationId.Value);
                var retorno = _mapper.Map<IEnumerable<CompanyDTO>>(company);
                return Ok(retorno.ToList());
            }


            if (userId.HasValue)
            {
                var company = _companyService.FindByUserId(userId.Value);
                var retorno = _mapper.Map<IEnumerable<CompanyDTO>>(company);
                return Ok(retorno.ToList());
            }

            return NoContent();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<CompanyDTO> Post([FromBody] CompanyDTO value)
        {
            var company = _mapper.Map<Company>(value);
            var retorno = _companyService.Save(company);
            return Ok(_mapper.Map<CompanyDTO>(retorno));
        }
    }
}
