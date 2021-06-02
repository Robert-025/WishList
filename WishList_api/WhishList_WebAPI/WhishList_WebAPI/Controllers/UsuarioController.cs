using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhishList_WebAPI.Domains;
using WhishList_WebAPI.Repositories;

namespace WhishList_WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private UsuarioRepository _usuairoRepository { get; set; }

        public UsuarioController() 
        {
            _usuairoRepository = new UsuarioRepository();
        }
        /// <summary>
        /// método IActionResult para listar todos os usurarios 
        /// </summary>
        /// <returns>Lista de usuarios</returns>
        ///  http://LocalHost:5000/api/Usuario/
        [HttpGet]
        public IActionResult Get() 
        {
            return Ok(_usuairoRepository.Listar());
        }

        /// <summary>
        /// Método IActionResult  para cadastrar um novo usuário
        /// </summary>
        /// <param name="cadastrarUsuario"></param>
        /// <returns>status code 201- created se o novo usuário estiver com todas as informações estejam de acordo com o necessário</returns>
        /// http://Localhost:5000/api/Usuario/
        [HttpPost]
        public IActionResult Post(Usuario cadastrarUsuario) 
        {
            //chama o método cadastrar criado no UsuarioRepository
            _usuairoRepository.Cadastrar(cadastrarUsuario);

            //retorna status code 201 - Created
            return StatusCode(201);
        }
    }
}
