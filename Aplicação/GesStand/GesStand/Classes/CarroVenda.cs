using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesStand
{
    public partial class CarroVenda:Carro
    {
        public override string ToString()
        {
            return "[ -> Marca:" + this.Marca + "  -> Modelo: " + this.Modelo + " ]";
        }
    }
}
