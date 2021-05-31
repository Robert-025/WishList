using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhishList_WebAPI.Domains;

namespace WhishList_WebAPI.Interfaces
{
    interface IDesejosRepository
    {
        /// <summary>
        /// método utilizado para cadastrar um novo desejo
        /// </summary>
        /// <param name="novoDesejo">objeto que irá armazenar todas as informações do novo desejo</param>
        void Cadastrar(Desejo novoDesejo);

        /// <summary>
        /// método utilizado para listar todos os desejos
        /// </summary>
        /// <returns>Lista de desejos</returns>
        List<Desejo> Listar();

    }
}
