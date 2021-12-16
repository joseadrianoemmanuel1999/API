using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models.Api;
using API.Service.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controller
{
    public class WriteController : ControllerBase
    {
       /* [Route("api/[controller]")]
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
            }
            */
        }

    }

