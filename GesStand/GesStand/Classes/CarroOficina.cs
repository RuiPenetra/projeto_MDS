using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesStand
{
    public partial class CarroOficina:Carro
    {      
            public override string ToString()
        {
            return "[ -> Matricula:" + this.Matricula + "  -> Kms: " + this.Kms + " km" + " ]";
        }
    }
}
