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

namespace GesStand.Forms
{
    [Serializable]
    public partial class Form_GestaoOficina : Form
    {
        private Model_GesStandContainer MdGesStand;

        public Form_GestaoOficina()
        {
            InitializeComponent();
        }
        private void GestãoOficina_Load(object sender, EventArgs e)
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
            toolTip1.SetToolTip(BT_addCarro, "Guardar");
            toolTip1.SetToolTip(BT_remvCarro, "Remover");
            toolTip1.SetToolTip(BT_addServico, "Guardar");
            toolTip1.SetToolTip(BT_remvServico, "Remover");
            toolTip1.SetToolTip(BT_addParcela, "Guardar");
            toolTip1.SetToolTip(BT_remvParcela, "Remover");
            toolTip1.SetToolTip(BT_exportar, "Exportar");
            #endregion

            MdGesStand = new Model_GesStandContainer();
            LerClientes();
        }

        #region LER DADOS
        private void LerClientes()
        {
            LIST_clientes.DataSource = MdGesStand.Cliente.ToList<Cliente>();
        }
        private void LB_clientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = LIST_clientes.SelectedItem as Cliente;

            TB_inf_nome.Text = clienteSelecionado.Nome;
            TB_inf_nif.Text = clienteSelecionado.NIF;
            TB_inf_contacto.Text = Convert.ToString(clienteSelecionado.Contacto);

            LIST_carros.DataSource = null;

            if (clienteSelecionado != null)
            {
                LIST_carros.DataSource = clienteSelecionado.CarroOficina.ToList<CarroOficina>();

            }
        }

        private void LB_carros_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarroOficina carroOficinaSelecionado = LIST_carros.SelectedItem as CarroOficina;

            LIST_servicos.DataSource = null;

            if (carroOficinaSelecionado != null)
            {

                LIST_servicos.DataSource = carroOficinaSelecionado.Servico.ToList<Servico>();

                TB_inf_nchassi.Text = carroOficinaSelecionado.NumeroChassis;
                TB_inf_modelo.Text = carroOficinaSelecionado.Modelo;
                TB_inf_marca.Text = carroOficinaSelecionado.Marca;
                TB_inf_combustivel.Text = carroOficinaSelecionado.Combustivel;

            }
            else
            {
                TB_inf_nchassi.Text = "Nenhum";
                TB_inf_modelo.Text = "Nenhum";
                TB_inf_marca.Text = "Nenhum";
                TB_inf_combustivel.Text = "Nenhum";

            }
        }

        private void LB_Servicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Servico servicoSelecionado = LIST_servicos.SelectedItem as Servico;

            LIST_parcelas.DataSource = null;

            if (servicoSelecionado != null)
            {
                LIST_parcelas.DataSource = servicoSelecionado.Parcela.ToList<Parcela>();

                TB_inf_dt_inicio.Text = Convert.ToString( servicoSelecionado.DataEntrada);
                TB_inf_dt_fim.Text = Convert.ToString( servicoSelecionado.DataSaida);
                TB_inf_tipo.Text = Convert.ToString(servicoSelecionado.Tipo);
                TB_inf_valor.Text = Convert.ToString(servicoSelecionado.Total) ;
                
            }
        }

        #endregion

        #region INSERIR
        private void bt_addCarro_Click(object sender, EventArgs e)
        {

            Cliente clienteSelecionado = LIST_clientes.SelectedItem as Cliente;

            CarroOficina co = new CarroOficina();

            DialogResult guardar = MessageBox.Show("Tem a certeza que pertende inserir este carro ? ", "SALVAR", MessageBoxButtons.YesNo);

            if (guardar == DialogResult.Yes)
            {
                if (!ValidarTextBox(tb_c_nChassis, tb_c_matricula, tb_c_kms, tb_c_marca, tb_c_modelo, tb_c_combustivel))
                    return;

                co.NumeroChassis = tb_c_nChassis.Text;
                co.Marca = tb_c_marca.Text;
                co.Modelo = tb_c_modelo.Text;
                co.Combustivel = tb_c_combustivel.Text;
                co.Matricula = tb_c_matricula.Text;
                co.Kms =Convert.ToInt32( tb_c_kms.Text);

                clienteSelecionado.CarroOficina.Add(co);
                MdGesStand.SaveChanges();

                limparLabelsCarros();

                atualizarCarros();

            }
            else
            {
                limparLabelsCarros();
            }
        }

        private void bt_addServico_Click(object sender, EventArgs e)
        {
            CarroOficina CarroOficinaSelecionado = LIST_carros.SelectedItem as CarroOficina;
            Servico s = new Servico();

            DialogResult guardar = MessageBox.Show("Tem a certeza que pertende inserir este serviço ? ", "SALVAR", MessageBoxButtons.YesNo);

            if (guardar == DialogResult.Yes)
            {
                if (!ValidarTextBox(tb_s_servicoTipo))
                    return;
                

                s.DataEntrada = Convert.ToDateTime(dateTimePickerDataInicio.Text);
                s.DataSaida = Convert.ToDateTime(dateTimePickerDataFim.Text);
                s.Tipo = tb_s_servicoTipo.Text;

                CarroOficinaSelecionado.Servico.Add(s);

                MdGesStand.SaveChanges();

                limparLabelsServicos();
                atualizarServicos();
            }
            else
            {
                limparLabelsServicos();
            }

        }
               
        private void bt_addParcela_Click(object sender, EventArgs e)
        {
            if (!ValidarTextBox(tb_p_descricao,tb_p_valor))
                return;

            Servico ServicoSelecionado = LIST_servicos.SelectedItem as Servico;

            Parcela p = new Parcela();

            DialogResult guardar = MessageBox.Show("Tem a certeza que pertende inserir esta parcela ? ", "SALVAR", MessageBoxButtons.YesNo);

            if (guardar == DialogResult.Yes)
            {
                if (!decimal.TryParse(tb_p_valor.Text.Replace('.', ','), out decimal valor))
                {
                    tb_p_valor.Text = string.Empty;
                    tb_p_valor.Focus();
                    MessageBox.Show("Introduza um Valor!");
                    return;
                }

                p.Valor = valor;
                p.Descricao = tb_p_descricao.Text;

                ServicoSelecionado.Parcela.Add(p);

                MdGesStand.SaveChanges();

                atualizarParcelas();

                limparLabelsParcelas();

            }
            else
            {
                limparLabelsParcelas();
            }

        }
        
        #endregion

        #region REMOVER
        private void bt_remvCarro_Click(object sender, EventArgs e)
        {

        }

        private void bt_remvServico_Click(object sender, EventArgs e)
        {

        }
        private void bt_remvParcela_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Limpar
        public void limparLabelsCarros()
        {
            tb_c_nChassis.Text = "";
            tb_c_marca.Text = "";
            tb_c_modelo.Text = "";
            tb_c_combustivel.Text = "";
            tb_c_matricula.Text = "";
            tb_c_matricula.Text = "";
        }

        public void limparLabelsServicos()
        {
            tb_s_servicoTipo.Text = "";
        }
        public void limparLabelsParcelas()
        {
            tb_p_descricao.Text = "";
            tb_p_valor.Text = "";
        }
        #endregion

        #region Atualizar
        public void atualizarCarros()
        {
            Cliente clienteSelecionado = LIST_clientes.SelectedItem as Cliente;
            LIST_carros.DataSource = null;
            if (clienteSelecionado != null)
            {
                LIST_carros.DataSource = clienteSelecionado.CarroOficina.ToList<CarroOficina>();
            }
        }

        public void atualizarServicos()
        {
            CarroOficina carroOficinaSelecionado = LIST_carros.SelectedItem as CarroOficina;

            if (carroOficinaSelecionado != null)
            {
                LIST_servicos.DataSource = null;
                LIST_servicos.DataSource = carroOficinaSelecionado.Servico.ToList<Servico>();

            }
        }

        public void atualizarParcelas()
        {
            Servico servicoSelecionado = LIST_servicos.SelectedItem as Servico;

            LIST_parcelas.DataSource = null;

            if (servicoSelecionado != null)
            {
                LIST_parcelas.DataSource = servicoSelecionado.Parcela.ToList<Parcela>();
                Parcela p = LIST_parcelas.SelectedItem as Parcela;
                TB_inf_valor.Text = Convert.ToString(servicoSelecionado.Total) + " €";

            }
        }
        #endregion

        #region CONFIGS
        private void Form_GestaoOficina_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult fechar = MessageBox.Show("Tem a certeza que pertende sair ? ", "Sair", MessageBoxButtons.YesNo);

            if (fechar == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void tb_c_kms_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        #endregion

        #region VALIDAÇÕES
        public  bool ValidarTextBox(params TextBox[] registos)
        {
            foreach (TextBox textBox in registos)
            {
                if (textBox.Text == string.Empty)
                {
                    MessageBox.Show("Não foi possivel guardar o registo pois existe campos por preencher!!","ERRO");
                    textBox.Focus();
                    return false;
                }
            }
            return true;
        }
        #endregion

        private void BT_exportar_Click(object sender, EventArgs e)
        {
            if (LIST_clientes.SelectedIndex == -1 || LIST_carros.SelectedIndex == -1 || LIST_servicos.SelectedIndex == -1)
                return;



            Cliente clienteSelected = (Cliente)LIST_clientes.SelectedItem;
            CarroOficina carroSelected = (CarroOficina)LIST_carros.SelectedItem;
            Servico servicoSelected = (Servico)LIST_servicos.SelectedItem;



            saveFileDialogFicheiroTexto.Filter = "Arquivo de Texto (.txt)|.txt";
            saveFileDialogFicheiroTexto.FileName = clienteSelected.Nome + "" + carroSelected.Matricula + "" + servicoSelected.Tipo + ".txt";
            if (saveFileDialogFicheiroTexto.ShowDialog() != DialogResult.OK)
                return;



            StreamWriter ficheiro = new StreamWriter(saveFileDialogFicheiroTexto.FileName, false);

            ficheiro.WriteLine("Data de Emissão: " + DateTime.Now.ToString());
            ficheiro.WriteLine(string.Empty);

            ficheiro.WriteLine("Cliente: " + clienteSelected.Nome);
            ficheiro.WriteLine("Contacto: " + clienteSelected.Contacto);
            ficheiro.WriteLine(string.Empty);

            ficheiro.WriteLine("Carro(Matrícula): " + carroSelected.Matricula);
            ficheiro.WriteLine("Serviço: " + servicoSelected.Tipo);
            ficheiro.WriteLine("Entrada: " + servicoSelected.DataEntrada.ToString("MM/dd/yyyy"));
            ficheiro.WriteLine("Saída: " + servicoSelected.DataSaida.ToString("MM/dd/yyyy"));
            ficheiro.WriteLine(string.Empty);

            ficheiro.WriteLine("Parcelas: ");
            foreach (Parcela parcela in servicoSelected.Parcela)
            {
                ficheiro.WriteLine(parcela.Valor + "€" + " - " + parcela.Descricao);
            }



            ficheiro.Close();
            MessageBox.Show("Dados Exportados!");
        }

        private void LIST_Parcelas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
