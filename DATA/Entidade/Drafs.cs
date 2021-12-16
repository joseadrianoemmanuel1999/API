 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace API.Data.Entidade
{
    public class Drafs
    {
        [Key]
        public int DrafsID{get;set;}
         [Required]
         public User UserID {get;set;}
         [Required]
         public Write WriteID {get;set;}
    }
}