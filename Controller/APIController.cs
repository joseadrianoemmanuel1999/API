using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API.Models.Api;
using API.Service.Service;
using API.DATA.Entidade;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controller
{
    [Route("api/[controller]")]
    public class APIController : ControllerBase
    {
        [HttpPost]
        [Route("Adcionar")]
        public IActionResult Adcionar(WriteDTO Li)
        {
            WriteServ M1 = new WriteServ();

            var op = M1.adcionar(Li);

            return Ok(op);
        }
        [HttpGet]
        public IActionResult pegar(WriteDTO_ID Ma)
        {
            WriteServ M2 = new WriteServ();
            var opp = M2.Get(Ma);
            if (opp == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(opp);
            }


        }
        /*
        [HttpDelete("{id}")]
        public IActionResult Delete(WriteDTO id)
        {

            if (!Service.Service.)
                return NotFound();
            service.DeleteFilme(id);
            return NoContent();
        }*/
    }
   
    }
   
