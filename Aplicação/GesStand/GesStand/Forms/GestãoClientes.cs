using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace GesStand
{
    [Serializable]
    public partial class Form_GestaoClientes : Form
    {
        private Model_GesStandContainer MdGesStand;
        public Form_GestaoClientes()
        {
            InitializeComponent();

            MdGesStand = new Model_GesStandContainer();
            timer1.Start();

            //PASSAR O RATO SOBRE O BOTÃO
            #region BUTTON HOVER

            ToolTip toolTip1 = new ToolTip();

            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;

            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(BT_filtrar, "Filtrar");
            #endregion

            (from Cliente in MdGesStand.Clientes
             orderby Cliente.Nome
             select Cliente).Load();

            clienteBindingSource.DataSource = MdGesStand.Clientes.Local.ToBindingList();// ??????
        }

        #region Verificações

        //CONSTANTEMENTE VERIFICA SE EXISTE UMA LINHA VAZIA POR PREENCHER SE SIM BLOQUEIA O BOTÃO ADICIONAR
        private void timer1_Tick(object sender, EventArgs e)
        {
            int celula = -1;

            foreach (DataGridViewRow row in clienteDataGridView.Rows)
            {
                // Guardar valor da célula

                celula = Convert.ToInt32(row.Cells[0].Value);

                if (celula == 0)
                {
                    BT_novo_registo.Enabled = false;
                }
                else
                {
                    BT_novo_registo.Enabled = true;
                }
            }

            if (tb_filtrar.Text == "")
            {
                (from Cliente in MdGesStand.Clientes
                 orderby Cliente.Nome
                 select Cliente).Load();

                clienteBindingSource.DataSource = MdGesStand.Clientes.Local.ToBindingList();// ??????
            }

        }

        #endregion
        
        //FECHAR FORMULÁRIO
        private void Form_GestaoClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult fechar = MessageBox.Show("Tem a certeza que pertende sair ? ", "Sair", MessageBoxButtons.YesNo);

            if (fechar == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void BT_guardar_Click(object sender, EventArgs e)
        {
            DialogResult guardar = MessageBox.Show("Tem a certeza que pertende guardar/editar o cliente? ? ", "SALVAR", MessageBoxButtons.YesNo);


            //string verificar_nif = Convert.ToString(clienteDataGridView.CurrentRow.Cells[3].Value);

            //int conta = (from cliente in MdGesStand.Cliente
            //             where cliente.NIF.Contains(nIFTextBox.Text)
            //             orderby cliente.Nome
            //             select cliente).ToList().Count();

            if (guardar == DialogResult.Yes)
            {


                clienteDataGridView.Focus();
                clienteDataGridView.Rows[0].Selected = true;
                clienteDataGridView.CurrentCell = clienteDataGridView.Rows[0].Cells[0];

                MdGesStand.SaveChanges();
                MessageBox.Show("O cliente foi guardado/alterado com sucesso!", "SUCESSO");

            }
        }

        //REMOVER CLIENTE
        private void BT_remover_Click(object sender, EventArgs e)
        {
            DialogResult remover = MessageBox.Show("Tem a certeza que pertende exclui o cliente selecionado? ", "REMOVER", MessageBoxButtons.YesNo);

            if (remover == DialogResult.Yes)
            {

                try
                {
                    clienteDataGridView.Rows.Remove(clienteDataGridView.CurrentRow);

                    MdGesStand.SaveChanges();

                    MessageBox.Show("Cliente removido com sucesso!", "Sucesso");


                }
                catch (System.Data.Entity.Infrastructure.DbUpdateException)
                {
                    MessageBox.Show("Este Cliente não pode ser apagado, uma vez que tem registos associados!");

                }
            }

            (from Cliente in MdGesStand.Clientes
             orderby Cliente.IdCliente
             select Cliente).Load();

            clienteBindingSource.DataSource = MdGesStand.Clientes.Local.ToBindingList();
        }

        //PROCURAR CLIENTE
        private void BT_filtrar_Click(object sender, EventArgs e)
        {
            if (tb_filtrar.Text.Length > 0)
            {
                BT_novo_registo.Enabled = false;

                MdGesStand.Dispose();
                MdGesStand = new Model_GesStandContainer();

                (from cliente in MdGesStand.Clientes
                 where cliente.Nome.ToUpper().Contains(tb_filtrar.Text)
                 orderby cliente.Nome
                 select cliente).ToList();

                clienteBindingSource.DataSource = MdGesStand.Clientes.Local.ToBindingList();
            }
            else
            {
                BT_filtrar.Enabled = true;

                MdGesStand.Dispose();
                MdGesStand = new Model_GesStandContainer();

                (from cliente in MdGesStand.Clientes
                 orderby cliente.Nome
                 select cliente).ToList();

                clienteBindingSource.DataSource = MdGesStand.Clientes.Local.ToBindingList();

            }
        }

    }
}
