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
            MdGesStand = new Model_GesStandContainer();

            dateTimePickerDataInicio.Text = DateTime.Today.ToString();
            dateTimePickerDataFim.Text = DateTime.Today.ToString();

            LerClientes();

            #region PASSAR O RATO SOBRE O BOTÃO
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
        }

        #region LER DADOS
        private void LerClientes()
        {
            LIST_clientes.DataSource = MdGesStand.Clientes.ToList<Cliente>();
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
                TB_inf_kms.Text = Convert.ToString(carroOficinaSelecionado.Kms);
                TB_inf_marca.Text = carroOficinaSelecionado.Marca;
                TB_inf_combustivel.Text = carroOficinaSelecionado.Combustivel;

            }
            else
            {
                TB_inf_nchassi.Text = "";
                TB_inf_kms.Text = "0";
                TB_inf_marca.Text = "";
                TB_inf_combustivel.Text = "";

            }
        }

        private void LB_Servicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Servico servicoSelecionado = LIST_servicos.SelectedItem as Servico;

            LIST_parcelas.DataSource = null;

            if (servicoSelecionado != null)
            {
                LIST_parcelas.DataSource = servicoSelecionado.Parcela.ToList<Parcela>();

                TB_inf_dt_inicio.Text = Convert.ToString(servicoSelecionado.DataEntrada.ToShortDateString());
                TB_inf_dt_fim.Text = servicoSelecionado.DataSaida.ToShortDateString();
                TB_inf_tipo.Text = Convert.ToString(servicoSelecionado.Tipo);
                TB_inf_valor.Text = Convert.ToString(servicoSelecionado.Total); //Total de parcelas

            }
            else
            {
                TB_inf_dt_inicio.Text = "";
                TB_inf_dt_fim.Text = "";
                TB_inf_tipo.Text = "";
                TB_inf_valor.Text = "0";

            }
        }

        #endregion

        #region INSERIR
        private void bt_addCarro_Click(object sender, EventArgs e)
        {

            Cliente clienteSelecionado = LIST_clientes.SelectedItem as Cliente;

            CarroOficina carroOficina = new CarroOficina();

            DialogResult guardar = MessageBox.Show("Tem a certeza que pertende inserir este carro ? ", "SALVAR", MessageBoxButtons.YesNo);

            if (guardar == DialogResult.Yes)
            {
                if (!ValidarTextBox(tb_c_nChassis, tb_c_matricula, tb_c_kms, tb_c_marca, tb_c_modelo, tb_c_combustivel,tb_c_kms))
                    return;

                carroOficina.NumeroChassis = tb_c_nChassis.Text;
                carroOficina.Marca = tb_c_marca.Text;
                carroOficina.Modelo = tb_c_modelo.Text;
                carroOficina.Combustivel = tb_c_combustivel.Text;
                carroOficina.Matricula = tb_c_matricula.Text;
                carroOficina.Kms = Convert.ToInt32(tb_c_kms.Text);

                clienteSelecionado.CarroOficina.Add(carroOficina);
                MdGesStand.SaveChanges();

                limparTextBoxsCarros();

                atualizarCarros();

            }
            else
            {
                limparTextBoxsCarros();
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

                limparTextBoxsServicos();
                atualizarServicos();
            }
            else
            {
                limparTextBoxsServicos();
            }
        }

        private void bt_addParcela_Click(object sender, EventArgs e)
        {
            if (!ValidarTextBox(tb_p_descricao, tb_p_valor))
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

                atualizarServicos();
                atualizarParcelas();

                limparTextBoxsParcelas();

            }
            else
            {
                limparTextBoxsParcelas();
            }

        }

        #endregion

        #region REMOVER
        private void bt_remvCarro_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = LIST_clientes.SelectedItem as Cliente;

            CarroOficina carroSelecionado = LIST_carros.SelectedItem as CarroOficina;

            DialogResult excluir = MessageBox.Show("Tem a certeza que pretende excluir o carro selecionado??", "EXCLUIR", MessageBoxButtons.YesNo);

            if (excluir == DialogResult.Yes)
            {
                if (LIST_servicos.SelectedItem == null)
                {
                    MdGesStand.Carros.Remove(carroSelecionado);
                    MdGesStand.SaveChanges();

                    MessageBox.Show("Carro removido com sucesso!", "REMOVER", MessageBoxButtons.OK);

                    atualizarCarros();
                }
                else
                {
                    MessageBox.Show("[ATENÇÃO]-Não pode excluir um carro com serviços associadas!", "ALERTA", MessageBoxButtons.OK);

                }
            }

        }

        private void bt_remvServico_Click(object sender, EventArgs e)
        {
            Servico servicoSelecionado = LIST_servicos.SelectedItem as Servico;

            DialogResult excluir = MessageBox.Show("Tem a certeza que pretende excluir o servico selecionado??", "EXCLUIR", MessageBoxButtons.YesNo);

            if (excluir == DialogResult.Yes)
            {
                if (LIST_parcelas.SelectedItem == null)
                {
                    MdGesStand.Servicos.Remove(servicoSelecionado);
                    MdGesStand.SaveChanges();

                    MessageBox.Show("Serviço removido com sucesso!", "ALERTA", MessageBoxButtons.OK);

                    atualizarServicos();
                }
                else
                {
                    MessageBox.Show("[ATENÇÃO]-Não pode excluir um servico com parcelas associadas!", "ALERTA", MessageBoxButtons.OK);

                }
            }
        }

        private void bt_remvParcela_Click(object sender, EventArgs e)
        {

            Parcela parcelaSelecionada = LIST_parcelas.SelectedItem as Parcela;
            DialogResult excluir = MessageBox.Show("Tem a certeza que pretende excluir a parcela selecionada??", "REMOVER", MessageBoxButtons.YesNo);

            if (excluir == DialogResult.Yes)
            {
                MdGesStand.Parcelas.Remove(parcelaSelecionada);
                MdGesStand.SaveChanges();

                MessageBox.Show("Parcela removida com sucesso!", "REMOVER", MessageBoxButtons.OK);
                atualizarParcelas();
            }
        }
        #endregion

        #region Limpar
        public void limparTextBoxsCarros()
        {
            tb_c_nChassis.Text = "";
            tb_c_marca.Text = "";
            tb_c_modelo.Text = "";
            tb_c_combustivel.Text = "";
            tb_c_matricula.Text = "";
            tb_c_matricula.Text = "";
            tb_c_matricula.Text = "";
            tb_c_kms.Text = "";
        }

        public void limparTextBoxsServicos()
        {
            tb_s_servicoTipo.Text = "";
        }
        public void limparTextBoxsParcelas()
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
        #endregion

        private void BT_exportar_Click(object sender, EventArgs e)
        {
            DialogResult exportar = MessageBox.Show("Tem a certeza que pertende exportar os dados selecionados ? ", "EXPORTAR", MessageBoxButtons.YesNo);

            if (exportar == DialogResult.Yes)
            {

                if (LIST_clientes.SelectedIndex == -1 || LIST_carros.SelectedIndex == -1 || LIST_servicos.SelectedIndex == -1)
                    return;



                Cliente clienteSelecionado = (Cliente)LIST_clientes.SelectedItem;
                CarroOficina carroSelecionado = (CarroOficina)LIST_carros.SelectedItem;
                Servico servicoSelecionado = (Servico)LIST_servicos.SelectedItem;

                string linha = "***************************************************************";


                saveFileDialogFicheiroTexto.Filter = "Arquivo de Texto (.txt)|.txt";
                saveFileDialogFicheiroTexto.FileName = clienteSelecionado.Nome + "" + carroSelecionado.Matricula + "" + servicoSelecionado.Tipo + ".txt";

                if (saveFileDialogFicheiroTexto.ShowDialog() != DialogResult.OK)
                    return;



                StreamWriter ficheiro = new StreamWriter(saveFileDialogFicheiroTexto.FileName, false);

                ficheiro.WriteLine("Data de Emissão: " + DateTime.Now.ToString());
                ficheiro.WriteLine(string.Empty);

                ficheiro.WriteLine("Cliente: " + clienteSelecionado.Nome);
                ficheiro.WriteLine("Contacto: " + clienteSelecionado.Contacto);
                ficheiro.WriteLine(string.Empty);
                ficheiro.WriteLine(linha);
                ficheiro.WriteLine(string.Empty);

                ficheiro.WriteLine("Carro(Matrícula): " + carroSelecionado.Matricula);
                ficheiro.WriteLine("Serviço: " + servicoSelecionado.Tipo);
                ficheiro.WriteLine("Entrada: " + servicoSelecionado.DataEntrada.ToString("MM/dd/yyyy"));
                ficheiro.WriteLine("Saída: " + servicoSelecionado.DataSaida.ToString("MM/dd/yyyy"));
                ficheiro.WriteLine(string.Empty);
                ficheiro.WriteLine(linha);
                ficheiro.WriteLine(string.Empty);

                ficheiro.WriteLine("Parcelas: ");
                foreach (Parcela parcela in servicoSelecionado.Parcela)
                {
                    ficheiro.WriteLine(parcela.Valor + "€" + " - " + parcela.Descricao);
                }

                ficheiro.Close();
                MessageBox.Show("Dados Exportados!");

            }
        }

    }
}
