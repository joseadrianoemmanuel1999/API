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
namespace API.Service.Interface
{
    public interface IRegister
    {
        //List<RegisterDTO> GetRegisters();
      //  RegisterDTO GetRegister(int UserID);
        void AddRegister(RegisterDTO item);
       // void DeleteRegister(int UserID);
      //  bool RegisterExist(int UserID);

    }
}
