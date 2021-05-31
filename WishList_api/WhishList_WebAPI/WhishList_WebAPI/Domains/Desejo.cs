using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace WhishList_WebAPI.Domains
{
    public partial class Desejo
    {
        /// <summary>
        /// identificador do desejo
        /// </summary>
        public int IdDesejo { get; set; }

        /// <summary>
        /// descrição do desejo
        /// </summary>
        [Required(ErrorMessage ="Insira o desejo do usuário")]
        public string Descricao { get; set; }

        /// <summary>
        /// identificador do usuário que está anotando o desejo
        /// </summary>
        [Required(ErrorMessage = "Insira o identificador do usuário")]
        public int? IdUsuario { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
