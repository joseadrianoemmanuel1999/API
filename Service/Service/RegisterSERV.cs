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

namespace API.Service.Service
{
    public class RegisterSERV : IRegister
    {
        private readonly List<RegisterDTO> registers;
        public RegisterSERV()
        {

            this.registers = new List<RegisterDTO>
       {
           new RegisterDTO {UserID = 1,Email="joseadriano066@gmail.com",password ="12232434" } };
       }
        public void AddRegister(RegisterDTO item)
        {
            this.registers.Add(item);
        }
        public void DeleteRegister(int UserID)
        {
            var model = this.registers.Where(m => m.UserID == UserID).FirstOrDefault();
            this.registers.Remove(model);

        }
        /*
        public List<RegisterDTO> GetRegister(int UserID)
        {
            return this.registers.Where(m => m.UserID == UserID).FirstOrDefault();
        }
        */
    }
    }

