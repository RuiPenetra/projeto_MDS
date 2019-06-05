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

            (from Cliente in MdGesStand.Cliente
             orderby Cliente.Nome
             select Cliente).Load();

            clienteBindingSource.DataSource = MdGesStand.Cliente.Local.ToBindingList();// ??????
        }
                
        private void BT_filtrar_Click(object sender, EventArgs e)
        {
            if (tb_filtrar.Text.Length > 0)
            {
                BT_novo_registo.Enabled = false;

                MdGesStand.Dispose();
                MdGesStand = new Model_GesStandContainer();

                (from cliente in MdGesStand.Cliente
                 where cliente.Nome.ToUpper().Contains(tb_filtrar.Text)
                 orderby cliente.Nome
                 select cliente).ToList();

                clienteBindingSource.DataSource = MdGesStand.Cliente.Local.ToBindingList();
            }
            else
            {
                BT_filtrar.Enabled = true;

                MdGesStand.Dispose();
                MdGesStand = new Model_GesStandContainer();

                (from cliente in MdGesStand.Cliente
                 orderby cliente.Nome
                 select cliente).ToList();

                clienteBindingSource.DataSource = MdGesStand.Cliente.Local.ToBindingList();

            }
        }

        #region Verificações
        private void timer1_Tick(object sender, EventArgs e)
        {
            int celula = -1;

            // Percorrer as linhas do DataGrid
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


            clienteDataGridView.Focus();
            clienteDataGridView.Rows[0].Selected = true;
            clienteDataGridView.CurrentCell = clienteDataGridView.Rows[0].Cells[0];

            if (guardar == DialogResult.Yes)
            {

                MdGesStand.SaveChanges();

                MessageBox.Show("O cliente foi guardado/alterado com sucesso!", "SUCESSO");

                //atualizarDatagrid();                
            }
        }

        private void BT_remover_Click(object sender, EventArgs e)
        {
            DialogResult ver_eliminar = MessageBox.Show("Tem a certeza que pertende exclui o cliente selecionado? ", "EXCLUIR", MessageBoxButtons.YesNo);

            if (ver_eliminar == DialogResult.Yes)
            {
                clienteDataGridView.Rows.Remove(clienteDataGridView.CurrentRow);
                MessageBox.Show("Cliente excluido com sucesso!", "Sucesso");
                MdGesStand.SaveChanges();

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
