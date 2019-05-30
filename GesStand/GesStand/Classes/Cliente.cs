using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesStand
{
    [Serializable]
    public partial class Cliente
    {

        public override string ToString()
        {
            return "( -> Nome:" + this.Nome + "   -> NIF: " + this.NIF +" )";
             
        }
               
    }
}
