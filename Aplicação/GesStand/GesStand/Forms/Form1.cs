using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesStand
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_gestClientes_Click(object sender, EventArgs e)
        {
            Form_GestaoClientes cliente = new Form_GestaoClientes();

            cliente.Show();
        }

        private void bt_gestOficina_Click(object sender, EventArgs e)
        {
            Form_GestãoOficina oficina = new Form_GestãoOficina();

            oficina.Show();
        }
    }
}
