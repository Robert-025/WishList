using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhishList_WebAPI.Contexts;
using WhishList_WebAPI.Domains;
using WhishList_WebAPI.Interfaces;

namespace WhishList_WebAPI.Repositories
{
    public class UsuarioRepository : IUsuariosRepositorty
    {
        /// <summary>
        /// pega as informações da classe contexts
        /// </summary>
        WishListContext ctx = new WishListContext();

        /// <summary>
        /// método para cadastrar o usuário
        /// </summary>
        /// <param name="cadastrarUsuario">objeto que irá armazenar as informações do novo usuário</param>
        public void Cadastrar(Usuario cadastrarUsuario)
        {
            //adiciona novo usuário a lista de usuários
            ctx.Usuarios.Add(cadastrarUsuario);

            //salva os dados e adiciona a lista
            ctx.SaveChanges();          
        }

        /// <summary>
        /// método usado para listar todos os usuários cadastrados no sistema
        /// </summary>
        /// <returns>Lista de usuários</returns>
        public List<Usuario> Listar()
        {
            return ctx.Usuarios.Include(l => l.Desejos).ToList();
        }

        /// <summary>
        /// método usado para logar no site, utilizando conta existente 
        /// </summary>
        /// <param name="email">objeto que está armazenado o email de usuario</param>
        /// <param name="senha">objeto que está armazenando a senha de usuario</param>
        /// <returns></returns>
        public Usuario Login(string email, string senha)
        {
            return ctx.Usuarios.FirstOrDefault(e => e.Email == email && e.Senha == senha);
        }
    }
}
