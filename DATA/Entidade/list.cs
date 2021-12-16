using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace API.Data.Entidade
{
    public class list
    {
        [Key]
        public int listID { get; set; }
        [Required]
        public string listName { get; set; }
        [Required]
        public User UserID { get; set; }




    }
}