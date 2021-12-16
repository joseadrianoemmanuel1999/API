using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace API.Data.Entidade
{
    public class Storie
    {
        [Key]
        public int StorieID {get;set;}
        [Required]
        public User UserID {get;set;}
    }
}