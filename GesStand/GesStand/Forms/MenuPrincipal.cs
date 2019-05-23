using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesStand.Forms
{
    public partial class form_MenuPrincipal : Form
    {
        private DateTime contadorTempo;
        public form_MenuPrincipal()
        {
            InitializeComponent();
            contadorTempo = new DateTime(0);
            timer.Start();

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

        private void timer_Tick(object sender, EventArgs e)
        {
            Model_GesStandContainer MdGesStand=new Model_GesStandContainer();

            status_datetime.Text = DateTime.Now.ToShortDateString();
            lb_clientes.Text = "Clientes: " + Convert.ToString(MdGesStand.Cliente.Count());
            lb_totalAluguer.Text = "Total Aluguer: " + Convert.ToString(MdGesStand.aluguer.Count());
            lb_totalVendas.Text = "Total Vendas: " + Convert.ToString(MdGesStand.Venda.Count());
            contadorTempo = contadorTempo.Add(new TimeSpan(0, 0, 0, 0, 10));
            status_contador.Text= contadorTempo.ToLongTimeString();
        }
        
    }
}
