using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesStand
{
    [Serializable]
    public partial class Servico
    {
        public override string ToString()
        {
            return "( " + "[ " + this.DataEntrada + " ]"  + " ->" + this.Tipo + this.Total + " )";
        }

        public Decimal Total
        {
            get
            {
                Decimal subTotal = 0;

                foreach (Parcela item in this.Parcela)
                {
                    subTotal += item.Valor;

                }
                return subTotal;
            }
        }
    }

}
