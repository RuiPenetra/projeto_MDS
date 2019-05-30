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
        private Model_GesStandContainer MdGesStand;
        public form_MenuPrincipal()
        {
            InitializeComponent();
            MdGesStand = new Model_GesStandContainer();
            contadorTempo = new DateTime(0);
            timer.Start();

            #region BUTTON HOVER
            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(bt_gestClientes, "Gestão Clientes");
            toolTip1.SetToolTip(bt_gestOficina, "Gestão Oficina");
            toolTip1.SetToolTip(bt_gestVenda, "Gestão Vendas");
            toolTip1.SetToolTip(bt_gestAluguer, "Gestão Aluguer");
            #endregion

        }

        #region ABRIR FORMS
        private void bt_gestClientes_Click(object sender, EventArgs e)
        {
            Form_GestaoClientes cliente = new Form_GestaoClientes();

            cliente.Show();
        }

        private void bt_gestOficina_Click(object sender, EventArgs e)
        {
            Form_GestaoOficina oficina = new Form_GestaoOficina();

            oficina.Show();
        }

        private void bt_gestVenda_Click(object sender, EventArgs e)
        {
            Form_Gestão_Vendas vendas = new Form_Gestão_Vendas();

            vendas.Show();
        }
        private void bt_gestAluguer_Click(object sender, EventArgs e)
        {
            Form_Gestão_Alugueres aluguer = new Form_Gestão_Alugueres();

            aluguer.Show();
        }

        #endregion

        private void timer_Tick(object sender, EventArgs e)
        {           

            status_datetime.Text = DateTime.Now.ToShortDateString();
            lb_clientes.Text = "Clientes: " + Convert.ToString(MdGesStand.Cliente.Count());
            lb_totalAluguer.Text = "Total Aluguer: " + Convert.ToString(MdGesStand.aluguer.Count());
            lb_totalVendas.Text = "Total Vendas: " + Convert.ToString(MdGesStand.Venda.Count());
            contadorTempo = contadorTempo.Add(new TimeSpan(0, 0, 0, 0,1));
            status_contador.Text= contadorTempo.ToLongTimeString();
        }

        private void form_MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult fechar = MessageBox.Show("Tem a certeza que pertende sair da aplicação ? ", "Sair", MessageBoxButtons.YesNo);

            if (fechar == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

    }
}
