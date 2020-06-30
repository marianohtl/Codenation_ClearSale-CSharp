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
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        public UserController(IUserService service, IMapper mapper)
        {
            _userService = service;
            _mapper = mapper;

        }

        // GET api/user
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<IEnumerable<UserDTO>> GetAll(string accelerationName = null, int? companyId = null)
        {
            IEnumerable<UserDTO> retorno;

            if (accelerationName != null)
            {
   
                var user = _userService.FindByAccelerationName(accelerationName);
                retorno = _mapper.Map<IEnumerable<UserDTO>>(user);
                return Ok(retorno.ToList());
            }


            if (companyId.HasValue)
            {
                var company = _userService.FindByCompanyId(companyId.Value);
                retorno = _mapper.Map<IEnumerable<UserDTO>>(company);
                return Ok(retorno.ToList());
            }

            return NoContent();

        }

        // GET api/user/{id}
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<UserDTO> Get(int? id = null)
        {
            UserDTO retorno;
            if (id.HasValue)
            {
                var user = _userService.FindById(id.Value);
                retorno = _mapper.Map<UserDTO>(user);
                return Ok(retorno);
            }

            return NoContent();
        }

        // POST api/user
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<UserDTO> Post([FromBody] UserDTO value)
        {
            var user = _mapper.Map<User>(value);
            var retorno = _userService.Save(user);
            return Ok(_mapper.Map<UserDTO>(retorno));
        }

    }
}
