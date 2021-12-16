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

    public class WriteServ
    {

        public static List<Write> list_write;

        public Write adcionar(WriteDTO Ad)
        {
            Write data = new Write();
            data.WriteID = Ad.WriteID;
            data.Tittle = Ad.Tittle;
            data.text = Ad.text;


            list_write = new List<Write>();

            list_write.Add(data);
            return data;
        }
       public Write del (Write id)
        {
             if (list_write.Contains(id))
            {
                 list_write.Remove(id);
            }
            return id;
        }
        public Write Get(WriteDTO_ID b)
        {
         
            
           Write B = new Write();
            B.WriteID = b.WriteID;
        
            if(list_write.Contains(B))
            {
                
                foreach (Write o in list_write)
                {
                    return o;
                }
            }
            return null;
           
        }
    }
}
