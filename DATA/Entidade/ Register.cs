using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkViewMigrations;
using Microsoft.EntityFrameworkCore.Design;
namespace API.DATA.Entidade
{
    public class Register
    {
        [Key]
        public int UserID { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public int Number_Phone { get; set; }


    }
}
