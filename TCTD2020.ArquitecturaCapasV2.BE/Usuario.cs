using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TCTD2020.ArquitecturaCapasV2.Interfaces;

namespace TCTD2020.ArquitecturaCapasV2.BE
{
   public class Usuario : Entity
    {

        public string Email { get; set; }
        public string Password { get; set; }
       
    }
}
