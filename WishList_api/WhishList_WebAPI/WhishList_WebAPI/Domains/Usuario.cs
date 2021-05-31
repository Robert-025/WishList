using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace WhishList_WebAPI.Domains
{
    /// <summary>
    /// Entidade Usuario que representa a tabela Usuarios no banco de dados
    /// </summary>
    public partial class Usuario
    {
        public Usuario()
        {
            Desejos = new HashSet<Desejo>();
        }
        
        /// <summary>
        /// id do usuário
        /// </summary>
        public int IdUsuario { get; set; }

        /// <summary>
        /// email do usuário
        /// </summary>
        [Required(ErrorMessage ="Inisira o email do usuário")]
        public string Email { get; set; }

        /// <summary>
        /// senha do usuário com no máximo de 10 caracteres e com o mínimo de 5
        /// </summary>
        [Required(ErrorMessage ="Insira a senha de usuário")]
        [StringLength(10, MinimumLength = 5, ErrorMessage ="Sua senha é fraca")]
        public string Senha { get; set; }

        public virtual ICollection<Desejo> Desejos { get; set; }
    }
}
