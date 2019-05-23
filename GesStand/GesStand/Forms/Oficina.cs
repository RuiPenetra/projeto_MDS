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
    public partial class Form_GestãoOficina : Form
    {
        private Model_GesStandContainer MdGesStand;
        public Form_GestãoOficina()
        {
            InitializeComponent();
        }

        private void Oficina_Load(object sender, EventArgs e)
        {
            MdGesStand = new Model_GesStandContainer();
            LerClientes();
        }


        #region Inserir
        private void bt_addCarro_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = LB_clientes.SelectedItem as Cliente;

            CarroOficina co = new CarroOficina();

            co.NumeroChassis = tb_c_nChassis.Text;
            co.Marca = tb_c_marca.Text;
            co.Modelo = tb_c_modelo.Text;
            co.Combustivel = tb_c_combustivel.Text;
            co.Matricula = tb_c_matricula.Text;
            co.Kms = tb_c_kms.Text;

            clienteSelecionado.CarroOficina.Add(co);
            MdGesStand.SaveChanges();

            atualizarCarros();

            limparLabelsCarros();
        }

        private void bt_addServico_Click(object sender, EventArgs e)
        {

            CarroOficina CarroOficinaSelecionado = LB_carros.SelectedItem as CarroOficina;
            Servico s = new Servico();

            s.DataEntrada = Convert.ToDateTime(dateTimePickerDataInicio.Text);
            s.DataSaida = Convert.ToDateTime(dateTimePickerDataFim.Text);
            s.Tipo = tb_s_servicoTipo.Text;

            CarroOficinaSelecionado.Servico.Add(s);

            MdGesStand.SaveChanges();

            atualizarServicos();

            limparLabelsServicos();

        }

        private void tb_addParcela_Click(object sender, EventArgs e)
        {
            Parcela p = new Parcela();

            Servico ServicoSelecionado = LB_Servicos.SelectedItem as Servico;

            p.Valor = Convert.ToDecimal(tb_p_valor.Text);
            p.Descricao = tb_p_descricao.Text;

            ServicoSelecionado.Parcela.Add(p);

            MdGesStand.SaveChanges();

            atualizarParcelas();

            limparLabelsParcelas();

        }
        #endregion


        #region CarregarDados

        private void LerClientes()
        {
            LB_clientes.DataSource = MdGesStand.Cliente.ToList<Cliente>();
        }

        private void LB_clientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = LB_clientes.SelectedItem as Cliente;

            lb_cl_nome.Text = clienteSelecionado.Nome;
            lb_cl_nif.Text = clienteSelecionado.NIF;

            LB_carros.DataSource = null;

            if (clienteSelecionado != null)
            {
                LB_carros.DataSource = clienteSelecionado.CarroOficina.ToList<CarroOficina>();
            }
        }

        private void LB_carros_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarroOficina carroOficinaSelecionado = LB_carros.SelectedItem as CarroOficina;

            LB_Servicos.DataSource = null;

            if (carroOficinaSelecionado != null)
            {

                LB_Servicos.DataSource = carroOficinaSelecionado.Servico.ToList<Servico>();
            }
        }
        private void LB_Servicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Servico servicoSelecionado = LB_Servicos.SelectedItem as Servico;

            LB_Parcelas.DataSource = null;

            if (servicoSelecionado != null)
            {
                LB_Parcelas.DataSource = servicoSelecionado.Parcela.ToList<Parcela>();
                Parcela p = LB_Parcelas.SelectedItem as Parcela;
                lb_valTotal.Text = Convert.ToString(total()) + "€";
            }

        }

        public Decimal total()
        {
            int index = 0;
            Decimal soma = 0;

            for (index = 0; index < LB_Parcelas.Items.Count; index++)
            {
                Parcela p = LB_Parcelas.Items[index] as Parcela;
                soma += p.Valor;
            }

            return soma;
        }
        #endregion


        #region Atualizar
        public void atualizarCarros()
        {
            Cliente clienteSelecionado = LB_clientes.SelectedItem as Cliente;
            LB_carros.DataSource = null;
            if (clienteSelecionado != null)
            {
                LB_carros.DataSource = clienteSelecionado.CarroOficina.ToList<CarroOficina>();
            }
        }

        public void atualizarServicos()
        {
            CarroOficina carroOficinaSelecionado = LB_carros.SelectedItem as CarroOficina;

            if (carroOficinaSelecionado != null)
            {
                LB_Servicos.DataSource = null;
                LB_Servicos.DataSource = carroOficinaSelecionado.Servico.ToList<Servico>();
            }
        }

        public void atualizarParcelas()
        {
            Servico servicoSelecionado = LB_Servicos.SelectedItem as Servico;

            LB_Parcelas.DataSource = null;

            if (servicoSelecionado != null)
            {
                LB_Parcelas.DataSource = servicoSelecionado.Parcela.ToList<Parcela>();
                Parcela p = LB_Parcelas.SelectedItem as Parcela;
                lb_valTotal.Text = Convert.ToString(total()) + "€"; ;
            }
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


    }
}
