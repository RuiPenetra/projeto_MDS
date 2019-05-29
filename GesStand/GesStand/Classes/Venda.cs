using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesStand
{
    public partial class Venda
    {
        public override string ToString()
        {
            return "( " + " |> " +this.CarroVenda.Marca + "     |>" + this.CarroVenda.Modelo + "     |>" + this.Estado + "     |> " + this.Valor + " )";  
        }
    }
}
