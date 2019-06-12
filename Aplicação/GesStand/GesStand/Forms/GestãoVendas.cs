using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesStand
{
    [Serializable]
    public partial class Form_Gestao_Vendas : Form
    {
        private Model_GesStandContainer MdGesStand;
        public Form_Gestao_Vendas()
        {
            InitializeComponent();
        }

        private void Gestão_Vendas_Load(object sender, EventArgs e)
        {
            #region BOTÃO DETALHES
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

        #region LER DADOS
        private void LerClientes()
        {
            LIST_clientes.DataSource = MdGesStand.Clientes.ToList<Cliente>();
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
                TB_inf_combustivel.Text = vendaSelecionada.CarroVenda.Combustivel;
                TB_inf_extras.Text = vendaSelecionada.CarroVenda.Extras;

                TB_inf_estado.Text = vendaSelecionada.Estado;
                TB_inf_data.Text = vendaSelecionada.Data.ToShortDateString();
                TB_inf_valor.Text = vendaSelecionada.Valor.ToString();
            }
            else
            {
                TB_inf_nchassi.Text = "";
                TB_inf_marca.Text = "";
                TB_inf_modelo.Text = "";
                TB_inf_combustivel.Text = "";
                TB_inf_extras.Text = "";
                TB_inf_estado.Text = "";
                TB_inf_data.Text = "";
                TB_inf_valor.Text = "0";
            }

        }
        #endregion

        #region INSERIR
        private void bt_inserirVenda_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = LIST_clientes.SelectedItem as Cliente;

            Venda v = new Venda();

            v.CarroVenda = new CarroVenda();

            DialogResult guardar = MessageBox.Show("Tem a certeza que pertende inserir esta venda ? ", "GUARDAR", MessageBoxButtons.YesNo);

            if (guardar == DialogResult.Yes)
            {
                if (!ValidarTextBox(tb_chassi, tb_combustivel, tb_estado, tb_extras, tb_marca, tb_estado, tb_modelo, tb_valor))
                    return;

                if (!decimal.TryParse(tb_valor.Text.Replace('.', ','), out decimal valor))
                {
                    tb_valor.Text = string.Empty;
                    tb_valor.Focus();
                    MessageBox.Show("Introduza um Valor!", "AVISO");
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

                limpar_textbox();
                MessageBox.Show("Venda inserida com sucesso!", "GUARDAR");

            }
            else
            {
                limpar_textbox();
            }
        }

        #endregion

        #region REMOVER
        private void BT_removerVenda_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = LIST_clientes.SelectedItem as Cliente;

            Venda venda = LIST_venda.SelectedItem as Venda;

            CarroVenda carroVenda = venda.CarroVenda;

            DialogResult remover = MessageBox.Show("Tem a certeza que pertende remover esta venda ? ", "REMOVER", MessageBoxButtons.YesNo);

            if (remover == DialogResult.Yes)
            {

                MdGesStand.Carros.Remove(venda.CarroVenda);
                MdGesStand.Vendas.Remove(venda);

                MdGesStand.SaveChanges();

                atualizar_listVendaCarro();

                MessageBox.Show("Venda removida com sucesso!", "REMOVER");

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

        #region LIMPAR
        public void limpar_textbox()
        {
            tb_chassi.Text = "";
            tb_marca.Text = "";
            tb_modelo.Text = "";
            tb_combustivel.Text = "";
            tb_extras.Text = "";

            tb_estado.Text = "";

            dateTimePicker_data.Value = DateTime.Now;

            tb_valor.Text = "";
        }

        #endregion

        #region EXPORTAR
        private void BT_exportar_Click(object sender, EventArgs e)
        {
            DialogResult exportar = MessageBox.Show("Tem a certeza que pertende exportar os dados selecionados ? ", "EXPORTAR", MessageBoxButtons.YesNo);

            if (exportar == DialogResult.Yes)
            {

                if (LIST_clientes.SelectedIndex == -1 || LIST_venda.SelectedIndex == -1)
                {
                    MessageBox.Show("Para Exporta será necssario selecionar um cliente e uma respetiva venda");
                    return;
                }
                else
                {
                    Cliente clienteSelecionado = (Cliente)LIST_clientes.SelectedItem;
                    Venda vendaSelecionada = (Venda)LIST_venda.SelectedItem;
                    CarroVenda carroVendaSelecionado = vendaSelecionada.CarroVenda;


                    string linha = "***************************************************************";


                    saveFileDialogFicheiroTexto.Filter = "Arquivo de Texto (.txt)|.txt";
                    saveFileDialogFicheiroTexto.FileName = "(VENDA)" + clienteSelecionado.Nome + "" + carroVendaSelecionado.NumeroChassis + ".txt";

                    if (saveFileDialogFicheiroTexto.ShowDialog() != DialogResult.OK)
                        return;



                    StreamWriter ficheiro = new StreamWriter(saveFileDialogFicheiroTexto.FileName, false);

                    ficheiro.WriteLine(string.Empty);
                    ficheiro.WriteLine(linha);
                    ficheiro.WriteLine("          <<  FATURA VENDA  >>");
                    ficheiro.WriteLine(linha);

                    ficheiro.WriteLine("# CLIENTE #");
                    ficheiro.WriteLine("Cliente: " + clienteSelecionado.Nome);
                    ficheiro.WriteLine("Nif: " + clienteSelecionado.NIF);
                    ficheiro.WriteLine("Contacto: " + clienteSelecionado.Contacto);
                    ficheiro.WriteLine(string.Empty);
                    ficheiro.WriteLine(linha);
                    ficheiro.WriteLine(string.Empty);

                    ficheiro.WriteLine("# CARRO #");
                    ficheiro.WriteLine("---> Marca: " + carroVendaSelecionado.Marca);
                    ficheiro.WriteLine("---> Modelo: " + carroVendaSelecionado.Modelo);
                    ficheiro.WriteLine("---> Combustivel: " + carroVendaSelecionado.Combustivel);
                    ficheiro.WriteLine("---> Extras: " + carroVendaSelecionado.Extras);
                    ficheiro.WriteLine(string.Empty);
                    ficheiro.WriteLine(linha);
                    ficheiro.WriteLine(string.Empty);

                    ficheiro.WriteLine("# Venda #");
                    ficheiro.WriteLine("---> Data da venda: " + vendaSelecionada.Data.ToString("MM/dd/yyyy"));
                    ficheiro.WriteLine("---> Estado: " + vendaSelecionada.Estado);
                    ficheiro.WriteLine("---> Valor: " + vendaSelecionada.Valor);
                    ficheiro.WriteLine(string.Empty);
                    ficheiro.WriteLine(linha);
                    ficheiro.WriteLine(string.Empty);


                    ficheiro.WriteLine(" Valor: " + vendaSelecionada.Valor + "€");

                    ficheiro.WriteLine(vendaSelecionada.Valor + "€");

                    ficheiro.WriteLine(linha);
                    ficheiro.WriteLine(" [ Data de Emissão: " + DateTime.Now.ToString() + " ]");
                    ficheiro.WriteLine(linha);

                    ficheiro.Close();
                    MessageBox.Show("Dados exportados com Sucesso !", "SUCESSO");
                }

            }
        }

        #endregion

        #region FECHAR FORMULÁRIO
        private void Form_Gestão_Vendas_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult fechar = MessageBox.Show("Tem a certeza que pertende sair ? ", "Sair", MessageBoxButtons.YesNo);

            if (fechar == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


        #endregion
               
    }
}
