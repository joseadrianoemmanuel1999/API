using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace API.Models.Api
 
 
{
    public class WriteDTO
    {

        public int WriteID { get; set; }
        public string Tittle { get; set; }
        public string text { get; set; }
       // public UserDTO UserID { get; set; }
    }
    public class WriteDTO_ID
    {
        public int WriteID { get; set; }

       
    }
}

