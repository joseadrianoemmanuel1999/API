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
namespace API.DATA.Entidade
{
    public class AplicationDBcontext : DbContext
    {
        public AplicationDBcontext(DbContextOptions<AplicationDBcontext> options) : base(options)
        {
        }
        public DbSet<Register> Registers { get; set; }
    }
}
