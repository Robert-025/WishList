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
    public class DesejoController : ControllerBase
    {
        private DesejoRepository _desejoRepository { get; set; }


        public DesejoController() 
        {
            _desejoRepository = new DesejoRepository();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// http://LocalHost:5000/desejo
        [HttpGet]
        public IActionResult Get() 
        {
            return Ok(_desejoRepository.Listar());
        }

        /// <summary>
        /// método IActionResult utilizado para cadastrar
        /// </summary>
        /// <param name="novoDesejo">objeto usado para armazenar os novos dados</param>
        /// <returns>status code 201 - created</returns>
        /// http://LocalHost:5000/desejo
        [HttpPost]
        public IActionResult Post(Desejo novoDesejo) 
        {
            //Chama o método cadasrar do desejoRepository
            _desejoRepository.Cadastrar(novoDesejo);

            //retorna status code 201 - created
            return StatusCode(201);
        }
    }
}
