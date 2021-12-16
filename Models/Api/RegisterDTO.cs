using API.Data;
using API.Data.Entidade;
using API.Models;
using API.Models.Api;
using API.Service.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Models.Api
{
    public class RegisterDTO
    {
        public int UserID { get; set; }


        public string Email { get; set; }

        public string password { get; set; }

        public int Number_Phone { get; set; }
    }
    public class AddRegisterDTO
    {
        public int UserID { get; set; }


        public string Email { get; set; }

        public string password { get; set; }

        public int Number_Phone { get; set; }
    }
    public class RecRegisterDTO
    {
        public int UserID { get; set; }


        public string Email { get; set; }

        public string password { get; set; }

        public int Number_Phone { get; set; }
    }
}
