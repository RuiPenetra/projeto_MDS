using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesStand
{
    [Serializable]
    public partial class CarroOficina:Carro
    {      
            public override string ToString()
        {
            return "[ "+ this.Marca + " -> " + this.Matricula + " ]";
        }
    }
}
