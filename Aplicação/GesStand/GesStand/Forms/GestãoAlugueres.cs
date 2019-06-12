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
    public partial class Form_Gestão_Alugueres : Form
    {
        private Model_GesStandContainer MdGesStand;
        public Form_Gestão_Alugueres()
        {
            InitializeComponent();
        }

        private void Form_Gestão_Alugueres_Load(object sender, EventArgs e) 
        {
            MdGesStand = new Model_GesStandContainer();
            LerClientes();
            LerCarros();

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
            toolTip1.SetToolTip(BT_inserirCarro, "Guardar");
            toolTip1.SetToolTip(BT_removerCarro, "Remover");
            toolTip1.SetToolTip(BT_inserirAluguer, "Guardar");
            toolTip1.SetToolTip(BT_removerAluguer, "Remover");
            toolTip1.SetToolTip(BT_exportar, "Exportar");
            #endregion
        }

        #region LER DADOS

        public void LerClientes()
        {
            LIST_clientes.DataSource = MdGesStand.Clientes.ToList<Cliente>();
        }

        public void LerCarros()
        {
            LIST_carros.DataSource = MdGesStand.Carros.OfType<CarroAluguer>().ToList();

        }


        private void List_clientes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = LIST_clientes.SelectedItem as Cliente;

            TB_inf_nome.Text = clienteSelecionado.Nome;
            TB_inf_nif.Text = clienteSelecionado.NIF;
            TB_inf_contacto.Text = clienteSelecionado.Contacto.ToString();

            LIST_alugueres.DataSource = null;

            if (clienteSelecionado != null)
            {
                LIST_alugueres.DataSource = clienteSelecionado.Aluguer.ToList<Aluguer>();

            }
        }

        private void List_aluguer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Aluguer aluguerSelecionada = LIST_alugueres.SelectedItem as Aluguer;

            if (aluguerSelecionada != null)
            {
                TB_inf_nchassi.Text = aluguerSelecionada.CarroAluguer.NumeroChassis;
                TB_inf_modelo.Text = aluguerSelecionada.CarroAluguer.Modelo;
                TB_inf_marca.Text = aluguerSelecionada.CarroAluguer.Marca;
                TB_inf_combustivel.Text = aluguerSelecionada.CarroAluguer.Combustivel;
                TB_inf_matricula.Text = aluguerSelecionada.CarroAluguer.Matricula;

                TB_inf_dt_inicio.Text = aluguerSelecionada.DataInicio.ToShortDateString();
                TB_inf_dt_fim.Text = aluguerSelecionada.DataFim.ToShortDateString();
                TB_inf_kms.Text = aluguerSelecionada.Kms.ToString();
                TB_inf_valor.Text = aluguerSelecionada.Valor.ToString() + " €";
            }
            else
            {
                TB_inf_nchassi.Text = "";
                TB_inf_modelo.Text = "";
                TB_inf_marca.Text = "";
                TB_inf_matricula.Text = "";
                TB_inf_combustivel.Text = "";
                TB_inf_kms.Text = "";

                TB_inf_dt_inicio.Text = "";
                TB_inf_dt_fim.Text = "";
                TB_inf_valor.Text = "0";
            }
        }

        #endregion

        #region INSERIR
        private void BT_inserirCarro_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = LIST_clientes.SelectedItem as Cliente;

            CarroAluguer carroAluguer = new CarroAluguer();


            DialogResult guardar = MessageBox.Show("Tem a certeza que pertende inserir este carro ? ", "SALVAR", MessageBoxButtons.YesNo);

            if (guardar == DialogResult.Yes)
            {
                if (!ValidarTextBox(tb_chassi, tb_combustivel, tb_matricula, tb_marca, tb_modelo))
                    return;

                carroAluguer.NumeroChassis = tb_chassi.Text;
                carroAluguer.Marca = tb_marca.Text;
                carroAluguer.Modelo = tb_modelo.Text;
                carroAluguer.Combustivel = tb_combustivel.Text;
                carroAluguer.Matricula = tb_matricula.Text;
                carroAluguer.Estado = "DISPONIVEL";

                MdGesStand.Carros.Add(carroAluguer);

                MdGesStand.SaveChanges();

                limpar_textBox_carros();
                atualizar_listCarro();
                MessageBox.Show("Carro inserido com sucesso!", "SUCESSO");
            }


        }

        private void BT_inserirAluguer_Click(object sender, EventArgs e)
        {

            Cliente clienteSelecionado = LIST_clientes.SelectedItem as Cliente;

            CarroAluguer carroAluguerSelecionado = LIST_carros.SelectedItem as CarroAluguer;

            Aluguer aluguer = new Aluguer();


            DialogResult guardar = MessageBox.Show("Tem a certeza que pertende efectuar o aluguer deste carro ? ", "SALVAR", MessageBoxButtons.YesNo);

            if (guardar == DialogResult.Yes)
            {
                if (carroAluguerSelecionado.Estado == "INDISPONIVEL")
                {
                    MessageBox.Show("O carro que pertende alugar já se encontra alugado!", "INDISPONIVEL");
                }
                else
                {
                    if (!ValidarTextBox(tb_kms, tb_valor))
                        return;

                    if (!decimal.TryParse(tb_valor.Text.Replace('.', ','), out decimal valor))
                    {
                        tb_valor.Text = string.Empty;
                        tb_valor.Focus();
                        MessageBox.Show("Introduza um Valor!");
                        return;
                    }

                    carroAluguerSelecionado.Estado = "INDISPONIVEL";
                    aluguer.DataInicio = Convert.ToDateTime(dateTimePicker_data_inicio.Text);
                    aluguer.DataFim = Convert.ToDateTime(dateTimePicker_data_fim.Text);
                    aluguer.Valor = valor;
                    aluguer.Kms = Convert.ToInt32(tb_kms.Text);
                    aluguer.Cliente = clienteSelecionado;
                    aluguer.CarroAluguer = carroAluguerSelecionado;

                    MdGesStand.Alugueres.Add(aluguer);

                    MdGesStand.SaveChanges();

                    limpar_textBox_aluguer();

                    atualizar_listCarro();
                    atualizar_listAluguer();

                    MessageBox.Show("Aluguer inserido com sucesso!", "SUCESSO");

                }

            }
        }

        #endregion

        #region REMOVER
        private void BT_removerAluguer_Click(object sender, EventArgs e)
        {
            Aluguer aluguer = LIST_alugueres.SelectedItem as Aluguer;

            DialogResult remover = MessageBox.Show("Tem a certeza que remover remover este aluguer? ", "REMOVER", MessageBoxButtons.YesNo);

            if (remover == DialogResult.Yes)
            {
                aluguer.CarroAluguer.Estado = "DISPONIVEL";
                MdGesStand.Alugueres.Remove(aluguer);


                MdGesStand.SaveChanges();
                atualizar_listAluguer();
                atualizar_listCarro();

                MessageBox.Show("Aluguer removido com sucesso!", "SUCESSO");
            }

        }

        private void BT_removerCarro_Click(object sender, EventArgs e)
        {
            CarroAluguer carroAluguer = LIST_carros.SelectedItem as CarroAluguer;

            DialogResult remover = MessageBox.Show("Tem a certeza que remover remover este carro? ", "REMOVER", MessageBoxButtons.YesNo);

            if (remover == DialogResult.Yes)
            {
                if (carroAluguer.Estado == "INDISPONIVEL")
                {
                    MessageBox.Show("Não foi possivel remover o carro pois este encontra se alugado a um cliente! Caso prentenda remover ele terá que cancelar(apagar) o aluguer do mesmo!!", "AVISO");
                }
                else
                {
                    MdGesStand.Carros.Remove(carroAluguer);

                    MdGesStand.SaveChanges();

                    atualizar_listCarro();

                    MessageBox.Show("Carro removido com sucesso!", "SUCESSO");
                }
            }
        }

        #endregion

        #region ATUALIZAR
        public void atualizar_listCarro()
        {
            LIST_carros.DataSource = MdGesStand.Carros.OfType<CarroAluguer>().ToList();

        }

        public void atualizar_listAluguer()
        {
            Cliente clienteSelecionado = LIST_clientes.SelectedItem as Cliente;

            LIST_alugueres.DataSource = clienteSelecionado.Aluguer.ToList();
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
        private void tb_kms_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        #endregion
               
        #region LIMPAR
        public void limpar_textBox_carros()
        {
            tb_chassi.Clear();
            tb_marca.Clear();
            tb_modelo.Clear();
            tb_combustivel.Clear();
            tb_matricula.Clear();
        }

        public void limpar_textBox_aluguer()
        {
            dateTimePicker_data_inicio.ResetText();
            dateTimePicker_data_fim.ResetText();
            tb_valor.Clear();
            tb_kms.Clear();
        }



        #endregion

        #region EXPORTAR
        private void BT_exportar_Click(object sender, EventArgs e)
        {
            DialogResult exportar = MessageBox.Show("Tem a certeza que pertende exportar os dados selecionados ? ", "EXPORTAR", MessageBoxButtons.YesNo);

            if (exportar == DialogResult.Yes)
            {

                if (LIST_clientes.SelectedIndex == -1 || LIST_carros.SelectedIndex == -1 || LIST_alugueres.SelectedIndex == -1)
                {
                    MessageBox.Show("Para Exporta será necssario selecionar um cliente e um respetivo aluguer");
                    return;
                }
                else
                {
                    Cliente clienteSelecionado = LIST_clientes.SelectedItem as Cliente;
                    Aluguer aluguerSelecionado = LIST_alugueres.SelectedItem as Aluguer;

                    string linha = "***************************************************************";


                    saveFileDialogFicheiroTexto.Filter = "Arquivo de Texto (.txt)|.txt";
                    saveFileDialogFicheiroTexto.FileName = "(ALUGUER)" + clienteSelecionado.Nome + "" + aluguerSelecionado.CarroAluguer.Matricula + ".txt";

                    if (saveFileDialogFicheiroTexto.ShowDialog() != DialogResult.OK)
                        return;

                    StreamWriter ficheiro = new StreamWriter(saveFileDialogFicheiroTexto.FileName, false);

                    ficheiro.WriteLine(string.Empty);
                    ficheiro.WriteLine(linha);
                    ficheiro.WriteLine("          <<  FATURA ALUGUER  >>");
                    ficheiro.WriteLine(linha);

                    ficheiro.WriteLine("# CLIENTE #");
                    ficheiro.WriteLine("Cliente: " + clienteSelecionado.Nome);
                    ficheiro.WriteLine("Nif: " + clienteSelecionado.NIF);
                    ficheiro.WriteLine("Contacto: " + clienteSelecionado.Contacto);
                    ficheiro.WriteLine(string.Empty);
                    ficheiro.WriteLine(linha);
                    ficheiro.WriteLine(string.Empty);

                    ficheiro.WriteLine("# CARRO #");
                    ficheiro.WriteLine("---> Marca: " + aluguerSelecionado.CarroAluguer.Marca);
                    ficheiro.WriteLine("---> Modelo: " + aluguerSelecionado.CarroAluguer.Modelo);
                    ficheiro.WriteLine("---> Matrícula: " + aluguerSelecionado.CarroAluguer.Matricula);
                    ficheiro.WriteLine(string.Empty);
                    ficheiro.WriteLine(linha);
                    ficheiro.WriteLine(string.Empty);

                    ficheiro.WriteLine("# Aluguer #");
                    ficheiro.WriteLine("---> Data da entrega: " + aluguerSelecionado.DataInicio.ToString("MM/dd/yyyy"));
                    ficheiro.WriteLine("---> Data de devolução: " + aluguerSelecionado.DataFim.ToString("MM/dd/yyyy"));
                    ficheiro.WriteLine("---> KMS: " + aluguerSelecionado.Kms);
                    ficheiro.WriteLine(string.Empty);
                    ficheiro.WriteLine(linha);
                    ficheiro.WriteLine(string.Empty);


                    ficheiro.WriteLine(" Valor: " + aluguerSelecionado.Valor + "€");

                    ficheiro.WriteLine(aluguerSelecionado.Valor + "€");

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
        private void Form_Gestão_Alugueres_FormClosing(object sender, FormClosingEventArgs e)
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

