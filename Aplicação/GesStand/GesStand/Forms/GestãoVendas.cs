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
    public partial class Form_Gestão_Vendas : Form
    {
        private Model_GesStandContainer MdGesStand;
        public Form_Gestão_Vendas()
        {
            InitializeComponent();
        }

        private void Gestão_Vendas_Load(object sender, EventArgs e)
        {
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
            toolTip1.SetToolTip(BT_inserirVenda, "Guardar");
            toolTip1.SetToolTip(BT_removerVenda, "Remover");
            toolTip1.SetToolTip(BT_exportar, "Exportar");
            #endregion

            MdGesStand = new Model_GesStandContainer();
            LerClientes();


        }

        #region LER
        private void LerClientes()
        {
            LIST_clientes.DataSource = MdGesStand.Cliente.ToList<Cliente>();
        }
        private void List_clientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = LIST_clientes.SelectedItem as Cliente;

            TB_inf_nome.Text = clienteSelecionado.Nome;
            TB_inf_nif.Text = clienteSelecionado.NIF;
            TB_inf_contacto.Text = clienteSelecionado.Contacto.ToString();

            LIST_venda.DataSource = null;

            if (clienteSelecionado != null)
            {
                LIST_venda.DataSource = clienteSelecionado.Venda.ToList<Venda>();

            }
        }

        private void List_venda_SelectedIndexChanged(object sender, EventArgs e)
        {
            Venda vendaSelecionada = LIST_venda.SelectedItem as Venda;

            if (vendaSelecionada != null)
            {
                TB_inf_nchassi.Text = vendaSelecionada.CarroVenda.NumeroChassis;
                TB_inf_modelo.Text = vendaSelecionada.CarroVenda.Modelo;
                TB_inf_marca.Text = vendaSelecionada.CarroVenda.Marca;
                TB_inf_combustivel.Text =  vendaSelecionada.CarroVenda.Combustivel;
                TB_inf_extras.Text = vendaSelecionada.CarroVenda.Extras;

                TB_inf_estado.Text = vendaSelecionada.Estado;
                TB_inf_data.Text =  vendaSelecionada.Data.ToString();
                TB_inf_valor.Text = vendaSelecionada.Valor.ToString();
            }
        }
        #endregion

        #region INSERIR
        private void bt_inserirVenda_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = LIST_clientes.SelectedItem as Cliente;

            Venda v = new Venda();

            v.CarroVenda = new CarroVenda();

            DialogResult guardar = MessageBox.Show("Tem a certeza que pertende inserir esta venda ? ", "SALVAR", MessageBoxButtons.YesNo);

            if (guardar == DialogResult.Yes)
            {
                if (!ValidarTextBox(tb_chassi, tb_combustivel, tb_estado, tb_extras, tb_marca, tb_estado, tb_modelo, tb_valor))
                    return;

                if (!decimal.TryParse(tb_valor.Text.Replace('.', ','), out decimal valor))
                {
                    tb_valor.Text = string.Empty;
                    tb_valor.Focus();
                    MessageBox.Show("Introduza um Valor!");
                    return;
                }

                v.Estado = tb_estado.Text;
                v.Data = Convert.ToDateTime(dateTimePicker_data.Text);
                v.Valor = valor;

                v.CarroVenda.NumeroChassis = tb_chassi.Text;
                v.CarroVenda.Marca = tb_marca.Text;
                v.CarroVenda.Modelo = tb_modelo.Text;
                v.CarroVenda.Combustivel = tb_combustivel.Text;
                v.CarroVenda.Extras = tb_extras.Text;

                clienteSelecionado.Venda.Add(v);

                MdGesStand.SaveChanges();

                atualizar_listVendaCarro();

                MessageBox.Show("Venda inserida com sucesso!");

            }
        }

        #endregion

        #region ATUALIZAR
        public void atualizar_listVendaCarro()
        {
            Cliente clienteSelecionado = LIST_clientes.SelectedItem as Cliente;
            TB_inf_nome.Text = clienteSelecionado.Nome;
            TB_inf_nif.Text = clienteSelecionado.NIF;
            TB_inf_contacto.Text = clienteSelecionado.Contacto.ToString();

            LIST_venda.DataSource = null;

            if (clienteSelecionado != null)
            {
                LIST_venda.DataSource = clienteSelecionado.Venda.ToList<Venda>();

            }
        }

        #endregion

        #region FECHAR
        private void Form_Gestão_Vendas_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult fechar = MessageBox.Show("Tem a certeza que pertende sair ? ", "Sair", MessageBoxButtons.YesNo);

            if (fechar == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        #endregion

        #region VALIDAÇÕES
        public bool ValidarTextBox(params TextBox[] registos)
        {
            foreach (TextBox textBox in registos)
            {
                if (textBox.Text == string.Empty)
                {
                    MessageBox.Show("Não foi possivel guardar o registo pois existe campos por preencher!!", "ERRO");
                    textBox.Focus();
                    return false;
                }
            }
            return true;
        }
        //private void tb_kms_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
        //    {
        //        e.Handled = true;
        //    }
        //}


        #endregion

        private void BT_removerVenda_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = LIST_clientes.SelectedItem as Cliente;

            Venda venda = LIST_venda.SelectedItem as Venda;

            CarroVenda carroVenda = venda.CarroVenda;

            DialogResult remover = MessageBox.Show("Tem a certeza que pertende remover esta venda ? ", "REMOVER", MessageBoxButtons.YesNo);

            if (remover == DialogResult.Yes)
            {

                MdGesStand.Carro.Remove(venda.CarroVenda);
                MdGesStand.Venda.Remove(venda);
                
                MdGesStand.SaveChanges();

                atualizar_listVendaCarro();

                MessageBox.Show("Venda removida com sucesso!");

            }
        }
    }
}
