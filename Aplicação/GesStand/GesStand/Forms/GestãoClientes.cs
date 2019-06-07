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
    public partial class Form_GestaoClientes : Form
    {
        private Model_GesStandContainer MdGesStand;
        public Form_GestaoClientes()
        {
            InitializeComponent();

            MdGesStand = new Model_GesStandContainer();// ??????
            timer1.Start();

            (from Cliente in MdGesStand.Clientes
             orderby Cliente.Nome
             select Cliente).Load();

            clienteBindingSource.DataSource = MdGesStand.Clientes.Local.ToBindingList();// ??????
        }

        #region Verificações
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

        //public int ver_textbox_clientes()
        //{
        //    if (String.IsNullOrEmpty(nomeTextBox.Text))
        //    {
        //        MessageBox.Show("O campo < Nome > não foi preenchido!", "ERRO");

        //        return 1;
        //    }

        //    if (String.IsNullOrEmpty(nIFTextBox.Text))
        //    {
        //        MessageBox.Show("O campo < Nif > não foi preenchido!", "ERRO");

        //        return 1;
        //    }

        //    if (String.IsNullOrEmpty(moradaTextBox.Text))
        //    {
        //        MessageBox.Show("O campo < Morada > não foi preenchido!", "ERRO");

        //        return 1;
        //    }

        //    if (String.IsNullOrEmpty(contactoTextBox.Text))
        //    {
        //        MessageBox.Show("O campo < Contacto > não foi preenchido!", "ERRO");

        //        return 1;
        //    }

        //    return 0;

        //}

        #endregion

        //#region Configurações
        //private void contactoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
        //    {
        //        e.Handled = true;
        //    }
        //}

        //#endregion

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

        private void BT_remover_Click(object sender, EventArgs e)
        {
            DialogResult remover = MessageBox.Show("Tem a certeza que pertende exclui o cliente selecionado? ", "REMOVER", MessageBoxButtons.YesNo);

            if (remover == DialogResult.Yes)
            {
    
                try
                {
                    clienteDataGridView.Rows.Remove(clienteDataGridView.CurrentRow);
                   
                    MdGesStand.SaveChanges();
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateException)
                {
                    MessageBox.Show("Este Cliente não pode ser apagado, uma vez que tem registos associados!");
                }
                MessageBox.Show("Cliente removido com sucesso!", "Sucesso");
            }

        }


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
