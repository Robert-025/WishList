using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhishList_WebAPI.Domains;

namespace WhishList_WebAPI.Interfaces
{
    interface IUsuariosRepositorty
    {
        /// <summary>
        /// método para cadastrar o usuário
        /// </summary>
        /// <param name="cadastrarUsuario">objeto que irá armazenar as informações do novo usuário</param>
        void Cadastrar(Usuario cadastrarUsuario);

        /// <summary>
        /// método usado para listar todos os usuários cadastrados no sistema
        /// </summary>
        /// <returns>Lista de usuários</returns>
        List<Usuario> Listar();

        /// <summary>
        /// método usado para logar no site, utilizando conta existente 
        /// </summary>
        /// <param name="email">objeto que está armazenado o email de usuario</param>
        /// <param name="senha">objeto que está armazenando a senha de usuario</param>
        /// <returns></returns>
        Usuario Login(string email, string senha);
    }
}
