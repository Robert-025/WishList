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
    public class DesejoRepository : IDesejosRepository
    {
        WishListContext ctx = new WishListContext();

        public void Cadastrar(Desejo novoDesejo)
        {
            //adiciona um novo desejo a lista 
            ctx.Desejos.Add(novoDesejo);

            //salva os dados
            ctx.SaveChanges();
        }

        public List<Desejo> Listar()
        {
            return ctx.Desejos.ToList();
        }
    }
}
