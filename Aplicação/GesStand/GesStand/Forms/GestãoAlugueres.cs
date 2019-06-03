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
            toolTip1.SetToolTip(BT_insCarro, "Guardar Registo");
            toolTip1.SetToolTip(BT_remCarro, "Remover Registo");
            toolTip1.SetToolTip(BT_exportar, "Exportar");
            #endregion
        }

        #region LER DADOS

        public void LerClientes()
        {
            LIST_clientes.DataSource = MdGesStand.Cliente.ToList<Cliente>();
        }

        private void List_clientes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = LIST_clientes.SelectedItem as Cliente;

            TB_inf_nome.Text = clienteSelecionado.Nome;
            TB_inf_nif.Text = clienteSelecionado.NIF;
            TB_inf_contacto.Text = clienteSelecionado.Contacto.ToString();

            LIST_aluguer.DataSource = null;

            if (clienteSelecionado != null)
            {
                LIST_aluguer.DataSource = clienteSelecionado.Aluguer.ToList<Aluguer>();

            }
        }

        private void List_aluguer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Aluguer aluguerSelecionada = LIST_aluguer.SelectedItem as Aluguer;

            if (aluguerSelecionada != null)
            {
                TB_inf_nchassi.Text = "NºChassi: " + aluguerSelecionada.CarroAluguer.NumeroChassis;
                TB_inf_modelo.Text = "Modelo: " + aluguerSelecionada.CarroAluguer.Modelo;
                TB_inf_modelo.Text = "Marca: " + aluguerSelecionada.CarroAluguer.Marca;
                TB_inf_combustivel.Text = "Combustivel: " + aluguerSelecionada.CarroAluguer.Combustivel;
                TB_inf_estado.Text = "Estado: " + aluguerSelecionada.CarroAluguer.Estado;

                TB_inf_dt_inicio.Text = "Data Inicio: " + aluguerSelecionada.DataInicio.ToString();
                TB_inf_dt_fim.Text = "Data Fim: " + aluguerSelecionada.DataFim.ToString();
                TB_inf_valor.Text = aluguerSelecionada.Valor.ToString() + " €";
            }
            else
            {
                TB_inf_nchassi.Text = "Nenhum";
                TB_inf_modelo.Text = "Nenhum";
                TB_inf_marca.Text = "Nenhum";
                TB_inf_combustivel.Text = "Nenhum";
                TB_inf_combustivel.Text = "Nenhum";

                TB_inf_dt_inicio.Text = "Nenhum";
                TB_inf_dt_fim.Text = "Nenhum";
                TB_inf_valor.Text = "0";
            }
        }

        #endregion


        private void bt_insCarro_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = LIST_clientes.SelectedItem as Cliente;

            Aluguer a = new Aluguer();

            a.CarroAluguer = new CarroAluguer();

            DialogResult guardar = MessageBox.Show("Tem a certeza que pertende inserir este aluguer ? ", "SALVAR", MessageBoxButtons.YesNo);

            if (guardar == DialogResult.Yes)
            {
                if (!ValidarTextBox(tb_chassi,tb_combustivel,tb_estado,tb_matricula,tb_marca,tb_estado,tb_modelo,tb_valor,tb_kms))
                    return;

                if (!decimal.TryParse(tb_valor.Text.Replace('.', ','), out decimal valor))
                {
                    tb_valor.Text = string.Empty;
                    tb_valor.Focus();
                    MessageBox.Show("Introduza um Valor!");
                    return;
                }

                a.Kms = Convert.ToInt32( tb_kms.Text);
                a.DataInicio = Convert.ToDateTime(dateTimePicker_data_inicio.Text);
                a.DataFim = Convert.ToDateTime(dateTimePicker_data_fim.Text);           
                a.Valor = Convert.ToDecimal(tb_valor.Text);


                a.CarroAluguer.NumeroChassis = tb_chassi.Text;
                a.CarroAluguer.Marca = tb_marca.Text;
                a.CarroAluguer.Modelo = tb_modelo.Text;
                a.CarroAluguer.Combustivel = tb_combustivel.Text;
                a.CarroAluguer.Estado = tb_estado.Text;
                a.CarroAluguer.Matricula = tb_matricula.Text;

                clienteSelecionado.Aluguer.Add(a);

                MdGesStand.SaveChanges();

                atualizar_listAluguerCarro();
            }
            else
            {
                
            }

           

        }

        private void bt_remCarro_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = LIST_clientes.SelectedItem as Cliente;

            CarroAluguer carroAluguerSelecionado= LIST_aluguer.SelectedItem as CarroAluguer;

           //Aluguer aluguer=

           // DialogResult remover = MessageBox.Show("Tem a certeza que pertende cancelar o aluguer ? ", "SALVAR", MessageBoxButtons.YesNo);

           // if (remover == DialogResult.Yes)
           // {
           //     if (LIST_aluguer.SelectedItem != null)
           //     {
           //         MdGesStand.aluguer.Remove(carroAluguerSelecionado);
           //         MdGesStand.SaveChanges();

           //         MessageBox.Show("Carro removido com sucesso!", "ALERTA", MessageBoxButtons.OK);

           //     }
           //     else
           //     {
           //         MessageBox.Show("[ATENÇÃO]-Não existe alugueres para remover!", "ALERTA", MessageBoxButtons.OK);
           //     }
           // }

        }

        #region ATUALIZAR
        public void atualizar_listAluguerCarro()
        {
            Cliente clienteSelecionado = LIST_clientes.SelectedItem as Cliente;

            TB_inf_nome.Text = clienteSelecionado.Nome;
            TB_inf_nif.Text = clienteSelecionado.NIF;
            TB_inf_contacto.Text = clienteSelecionado.Contacto.ToString();

            LIST_aluguer.DataSource = null;

            if (clienteSelecionado != null)
            {
                LIST_aluguer.DataSource = clienteSelecionado.Aluguer.ToList<Aluguer>();

            }
        }

        #endregion

        #region CONFIGURAÇÕES
        private void Form_Gestão_Alugueres_FormClosing(object sender, FormClosingEventArgs e)
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
        private void tb_kms_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        #endregion
    }
}

