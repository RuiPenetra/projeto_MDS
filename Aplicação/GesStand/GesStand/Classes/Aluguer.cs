using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesStand
{
    public partial class Aluguer
    {
        public override string ToString()
        {
            return "( " + " |> " + this.CarroAluguer.Marca + "     |>" + this.CarroAluguer.Modelo + "     |>" + this.Kms + "     |> " + this.Valor + " )";
        }
    }
}
