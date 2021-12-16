using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace API.Models.Api
{
    public class StorieDTO
    {
       
        public int StorieID { get; set; }
        
        public UserDTO UserID { get; set; }
    }
}
