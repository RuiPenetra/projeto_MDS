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
            ToolTip toolTip1 = new ToolTip();

            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(bt_gestClientes, "Gestão Clientes");
            toolTip1.SetToolTip(bt_gestOficina, "Gestão Oficina");
            toolTip1.SetToolTip(bt_gestVenda, "Gestão Vendas");
            toolTip1.SetToolTip(bt_gestAluguer, "Gestão Aluguer");
            #endregion

        }

        #region ABRIR FORMS

        //ABRIR FORMULÁRIO CLIENTES
        private void bt_gestClientes_Click(object sender, EventArgs e)
        {
            Form_GestaoClientes cliente = new Form_GestaoClientes();

            cliente.Show();
        }

        //ABRIR FORMULÁRIO OFICINA
        private void bt_gestOficina_Click(object sender, EventArgs e)
        {
            Form_GestaoOficina oficina = new Form_GestaoOficina();

            oficina.Show();
        }

        //ABRIR FORMULÁRIO VENDA
        private void bt_gestVenda_Click(object sender, EventArgs e)
        {
            Form_Gestao_Vendas vendas = new Form_Gestao_Vendas();

            vendas.Show();
        }

        //ABRIR FORMULÁRIO ALUGUER
        private void bt_gestAluguer_Click(object sender, EventArgs e)
        {
            Form_Gestão_Alugueres aluguer = new Form_Gestão_Alugueres();

            aluguer.Show();
        }

        #endregion

        //CONTAR TOTAL(CLIENTES,VENDAS,ALUGUER) E MOSTRAR
        private void timer_Tick(object sender, EventArgs e)
        {

            lb_data_atual.Text = DateTime.Now.ToShortDateString();
            lb_nClientes.Text = "Clientes: " + Convert.ToString(MdGesStand.Clientes.Count());
            lb_nAluguer.Text = "Total Aluguer: " + Convert.ToString(MdGesStand.Alugueres.Count());
            lb_nVenda.Text = "Total Vendas: " + Convert.ToString(MdGesStand.Vendas.Count());
            contadorTempo = contadorTempo.Add(new TimeSpan(0, 0, 0, 0, 100));
            lb_cronometro.Text= contadorTempo.ToLongTimeString();
        }

        //FECHAR FORMULÁRIO
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
