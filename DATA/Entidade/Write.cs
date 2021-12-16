using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace API.Data.Entidade
{
    public class Write
    {
        [Key]
        public int WriteID {get;set;}
        [Required]
        public string Tittle {get;set;}
        [Required]
        public string text{get;set;}
        //public User UserID{get;set;}
        
    
    }
}