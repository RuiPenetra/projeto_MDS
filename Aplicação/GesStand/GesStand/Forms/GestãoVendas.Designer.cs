﻿namespace GesStand
{
    partial class Form_Gestao_Vendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Gestao_Vendas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LIST_clientes = new System.Windows.Forms.ListBox();
            this.CARRO = new System.Windows.Forms.GroupBox();
            this.LIST_venda = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_estado = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker_data = new System.Windows.Forms.DateTimePicker();
            this.tb_valor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BT_removerVenda = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_extras = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_combustivel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_modelo = new System.Windows.Forms.TextBox();
            this.tb_marca = new System.Windows.Forms.TextBox();
            this.tb_chassi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lb_extras = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.TB_inf_contacto = new System.Windows.Forms.TextBox();
            this.TB_inf_nif = new System.Windows.Forms.TextBox();
            this.TB_inf_nome = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.lb_clienteContacto = new System.Windows.Forms.Label();
            this.lb_clienteNif = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TB_inf_valor = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.TB_inf_extras = new System.Windows.Forms.TextBox();
            this.TB_inf_modelo = new System.Windows.Forms.TextBox();
            this.TB_inf_combustivel = new System.Windows.Forms.TextBox();
            this.TB_inf_marca = new System.Windows.Forms.TextBox();
            this.TB_inf_nchassi = new System.Windows.Forms.TextBox();
            this.lb_carroModelo = new System.Windows.Forms.Label();
            this.lb_carroCombustivel = new System.Windows.Forms.Label();
            this.lb_carroChassi = new System.Windows.Forms.Label();
            this.lb_carroMarca = new System.Windows.Forms.Label();
            this.TB_inf_data = new System.Windows.Forms.TextBox();
            this.TB_inf_estado = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.lb_parcelasValorTotal = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.BT_exportar = new System.Windows.Forms.Button();
            this.saveFileDialogFicheiroTexto = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BT_inserirVenda = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.CARRO.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.LIST_clientes);
            this.groupBox1.Location = new System.Drawing.Point(26, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 347);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SELECIONE UM CLIENTE";
            // 
            // LIST_clientes
            // 
            this.LIST_clientes.FormattingEnabled = true;
            this.LIST_clientes.Location = new System.Drawing.Point(16, 19);
            this.LIST_clientes.Name = "LIST_clientes";
            this.LIST_clientes.ScrollAlwaysVisible = true;
            this.LIST_clientes.Size = new System.Drawing.Size(202, 316);
            this.LIST_clientes.TabIndex = 1;
            this.LIST_clientes.SelectedIndexChanged += new System.EventHandler(this.List_clientes_SelectedIndexChanged);
            // 
            // CARRO
            // 
            this.CARRO.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CARRO.Controls.Add(this.LIST_venda);
            this.CARRO.Controls.Add(this.groupBox2);
            this.CARRO.Controls.Add(this.BT_removerVenda);
            this.CARRO.Controls.Add(this.BT_inserirVenda);
            this.CARRO.Controls.Add(this.groupBox3);
            this.CARRO.Location = new System.Drawing.Point(10, 15);
            this.CARRO.Name = "CARRO";
            this.CARRO.Size = new System.Drawing.Size(518, 530);
            this.CARRO.TabIndex = 7;
            this.CARRO.TabStop = false;
            this.CARRO.Text = "CARRO";
            // 
            // LIST_venda
            // 
            this.LIST_venda.FormattingEnabled = true;
            this.LIST_venda.Location = new System.Drawing.Point(93, 17);
            this.LIST_venda.Name = "LIST_venda";
            this.LIST_venda.ScrollAlwaysVisible = true;
            this.LIST_venda.Size = new System.Drawing.Size(320, 199);
            this.LIST_venda.TabIndex = 2;
            this.LIST_venda.SelectedIndexChanged += new System.EventHandler(this.List_venda_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Controls.Add(this.tb_estado);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dateTimePicker_data);
            this.groupBox2.Controls.Add(this.tb_valor);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(166, 363);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(171, 98);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "NOVO";
            // 
            // tb_estado
            // 
            this.tb_estado.Location = new System.Drawing.Point(55, 21);
            this.tb_estado.Name = "tb_estado";
            this.tb_estado.Size = new System.Drawing.Size(100, 20);
            this.tb_estado.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Estado :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Data :";
            // 
            // dateTimePicker_data
            // 
            this.dateTimePicker_data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_data.Location = new System.Drawing.Point(55, 47);
            this.dateTimePicker_data.Name = "dateTimePicker_data";
            this.dateTimePicker_data.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker_data.TabIndex = 6;
            // 
            // tb_valor
            // 
            this.tb_valor.Location = new System.Drawing.Point(55, 73);
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.Size = new System.Drawing.Size(100, 20);
            this.tb_valor.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Valor :";
            // 
            // BT_removerVenda
            // 
            this.BT_removerVenda.BackColor = System.Drawing.Color.Transparent;
            this.BT_removerVenda.BackgroundImage = global::GesStand.Properties.Resources.remover;
            this.BT_removerVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BT_removerVenda.Location = new System.Drawing.Point(283, 478);
            this.BT_removerVenda.Name = "BT_removerVenda";
            this.BT_removerVenda.Size = new System.Drawing.Size(38, 39);
            this.BT_removerVenda.TabIndex = 9;
            this.BT_removerVenda.UseVisualStyleBackColor = false;
            this.BT_removerVenda.Click += new System.EventHandler(this.BT_removerVenda_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Controls.Add(this.tb_extras);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tb_combustivel);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tb_modelo);
            this.groupBox3.Controls.Add(this.tb_marca);
            this.groupBox3.Controls.Add(this.tb_chassi);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(17, 222);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(473, 135);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "NOVO";
            // 
            // tb_extras
            // 
            this.tb_extras.Location = new System.Drawing.Point(247, 38);
            this.tb_extras.Multiline = true;
            this.tb_extras.Name = "tb_extras";
            this.tb_extras.Size = new System.Drawing.Size(220, 72);
            this.tb_extras.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(208, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Extras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Combustivel :";
            // 
            // tb_combustivel
            // 
            this.tb_combustivel.Location = new System.Drawing.Point(76, 103);
            this.tb_combustivel.Name = "tb_combustivel";
            this.tb_combustivel.Size = new System.Drawing.Size(115, 20);
            this.tb_combustivel.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Modelo :";
            // 
            // tb_modelo
            // 
            this.tb_modelo.Location = new System.Drawing.Point(76, 77);
            this.tb_modelo.Name = "tb_modelo";
            this.tb_modelo.Size = new System.Drawing.Size(115, 20);
            this.tb_modelo.TabIndex = 4;
            // 
            // tb_marca
            // 
            this.tb_marca.Location = new System.Drawing.Point(76, 51);
            this.tb_marca.Name = "tb_marca";
            this.tb_marca.Size = new System.Drawing.Size(115, 20);
            this.tb_marca.TabIndex = 3;
            // 
            // tb_chassi
            // 
            this.tb_chassi.Location = new System.Drawing.Point(76, 25);
            this.tb_chassi.Name = "tb_chassi";
            this.tb_chassi.Size = new System.Drawing.Size(115, 20);
            this.tb_chassi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nº Chassi :";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox6.Controls.Add(this.CARRO);
            this.groupBox6.Location = new System.Drawing.Point(279, 45);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(538, 554);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "VENDA";
            // 
            // lb_extras
            // 
            this.lb_extras.AutoSize = true;
            this.lb_extras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_extras.Location = new System.Drawing.Point(13, 108);
            this.lb_extras.Name = "lb_extras";
            this.lb_extras.Size = new System.Drawing.Size(42, 13);
            this.lb_extras.TabIndex = 8;
            this.lb_extras.Text = "Extras :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.groupBox11);
            this.panel2.Controls.Add(this.groupBox5);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.BT_exportar);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(834, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 545);
            this.panel2.TabIndex = 14;
            // 
            // groupBox11
            // 
            this.groupBox11.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox11.Controls.Add(this.TB_inf_contacto);
            this.groupBox11.Controls.Add(this.TB_inf_nif);
            this.groupBox11.Controls.Add(this.TB_inf_nome);
            this.groupBox11.Controls.Add(this.label18);
            this.groupBox11.Controls.Add(this.label29);
            this.groupBox11.Controls.Add(this.lb_clienteContacto);
            this.groupBox11.Controls.Add(this.lb_clienteNif);
            this.groupBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox11.Location = new System.Drawing.Point(18, 52);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(270, 111);
            this.groupBox11.TabIndex = 29;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "CLIENTE  (Selecionado)";
            // 
            // TB_inf_contacto
            // 
            this.TB_inf_contacto.Enabled = false;
            this.TB_inf_contacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_inf_contacto.Location = new System.Drawing.Point(76, 78);
            this.TB_inf_contacto.Name = "TB_inf_contacto";
            this.TB_inf_contacto.Size = new System.Drawing.Size(100, 20);
            this.TB_inf_contacto.TabIndex = 38;
            this.TB_inf_contacto.Text = "Nenhum";
            // 
            // TB_inf_nif
            // 
            this.TB_inf_nif.Enabled = false;
            this.TB_inf_nif.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_inf_nif.Location = new System.Drawing.Point(44, 48);
            this.TB_inf_nif.Name = "TB_inf_nif";
            this.TB_inf_nif.Size = new System.Drawing.Size(100, 20);
            this.TB_inf_nif.TabIndex = 37;
            this.TB_inf_nif.Text = "Nenhum";
            // 
            // TB_inf_nome
            // 
            this.TB_inf_nome.Enabled = false;
            this.TB_inf_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_inf_nome.Location = new System.Drawing.Point(58, 19);
            this.TB_inf_nome.Name = "TB_inf_nome";
            this.TB_inf_nome.Size = new System.Drawing.Size(183, 20);
            this.TB_inf_nome.TabIndex = 36;
            this.TB_inf_nome.Text = "Nenhum";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(14, 22);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "Nome :";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(11, -24);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(240, 24);
            this.label29.TabIndex = 34;
            this.label29.Text = "Sem cliente selecionado";
            // 
            // lb_clienteContacto
            // 
            this.lb_clienteContacto.AutoSize = true;
            this.lb_clienteContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_clienteContacto.Location = new System.Drawing.Point(16, 81);
            this.lb_clienteContacto.Name = "lb_clienteContacto";
            this.lb_clienteContacto.Size = new System.Drawing.Size(56, 13);
            this.lb_clienteContacto.TabIndex = 33;
            this.lb_clienteContacto.Text = "Contacto :";
            // 
            // lb_clienteNif
            // 
            this.lb_clienteNif.AutoSize = true;
            this.lb_clienteNif.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_clienteNif.Location = new System.Drawing.Point(16, 51);
            this.lb_clienteNif.Name = "lb_clienteNif";
            this.lb_clienteNif.Size = new System.Drawing.Size(26, 13);
            this.lb_clienteNif.TabIndex = 32;
            this.lb_clienteNif.Text = "Nif :";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox5.Controls.Add(this.TB_inf_valor);
            this.groupBox5.Controls.Add(this.groupBox10);
            this.groupBox5.Controls.Add(this.TB_inf_data);
            this.groupBox5.Controls.Add(this.TB_inf_estado);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.lb_parcelasValorTotal);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(18, 169);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(270, 297);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "VENDA  (Selecionada)";
            // 
            // TB_inf_valor
            // 
            this.TB_inf_valor.Enabled = false;
            this.TB_inf_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_inf_valor.Location = new System.Drawing.Point(155, 274);
            this.TB_inf_valor.Name = "TB_inf_valor";
            this.TB_inf_valor.Size = new System.Drawing.Size(86, 20);
            this.TB_inf_valor.TabIndex = 46;
            this.TB_inf_valor.Text = "Nenhum";
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox10.Controls.Add(this.TB_inf_extras);
            this.groupBox10.Controls.Add(this.TB_inf_modelo);
            this.groupBox10.Controls.Add(this.TB_inf_combustivel);
            this.groupBox10.Controls.Add(this.TB_inf_marca);
            this.groupBox10.Controls.Add(this.TB_inf_nchassi);
            this.groupBox10.Controls.Add(this.lb_carroModelo);
            this.groupBox10.Controls.Add(this.lb_carroCombustivel);
            this.groupBox10.Controls.Add(this.lb_carroChassi);
            this.groupBox10.Controls.Add(this.lb_carroMarca);
            this.groupBox10.Controls.Add(this.lb_extras);
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.Location = new System.Drawing.Point(11, 77);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(243, 195);
            this.groupBox10.TabIndex = 28;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "CARRO";
            // 
            // TB_inf_extras
            // 
            this.TB_inf_extras.Enabled = false;
            this.TB_inf_extras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_inf_extras.Location = new System.Drawing.Point(16, 122);
            this.TB_inf_extras.Multiline = true;
            this.TB_inf_extras.Name = "TB_inf_extras";
            this.TB_inf_extras.Size = new System.Drawing.Size(218, 62);
            this.TB_inf_extras.TabIndex = 43;
            this.TB_inf_extras.Text = "Nenhum";
            // 
            // TB_inf_modelo
            // 
            this.TB_inf_modelo.Enabled = false;
            this.TB_inf_modelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_inf_modelo.Location = new System.Drawing.Point(16, 79);
            this.TB_inf_modelo.Name = "TB_inf_modelo";
            this.TB_inf_modelo.Size = new System.Drawing.Size(75, 20);
            this.TB_inf_modelo.TabIndex = 42;
            this.TB_inf_modelo.Text = "Nenhum";
            // 
            // TB_inf_combustivel
            // 
            this.TB_inf_combustivel.Enabled = false;
            this.TB_inf_combustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_inf_combustivel.Location = new System.Drawing.Point(117, 79);
            this.TB_inf_combustivel.Name = "TB_inf_combustivel";
            this.TB_inf_combustivel.Size = new System.Drawing.Size(92, 20);
            this.TB_inf_combustivel.TabIndex = 41;
            this.TB_inf_combustivel.Text = "Nenhum";
            // 
            // TB_inf_marca
            // 
            this.TB_inf_marca.Enabled = false;
            this.TB_inf_marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_inf_marca.Location = new System.Drawing.Point(101, 33);
            this.TB_inf_marca.Name = "TB_inf_marca";
            this.TB_inf_marca.Size = new System.Drawing.Size(75, 20);
            this.TB_inf_marca.TabIndex = 40;
            this.TB_inf_marca.Text = "Nenhum";
            // 
            // TB_inf_nchassi
            // 
            this.TB_inf_nchassi.Enabled = false;
            this.TB_inf_nchassi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_inf_nchassi.Location = new System.Drawing.Point(12, 33);
            this.TB_inf_nchassi.Name = "TB_inf_nchassi";
            this.TB_inf_nchassi.Size = new System.Drawing.Size(64, 20);
            this.TB_inf_nchassi.TabIndex = 39;
            this.TB_inf_nchassi.Text = "Nenhum";
            // 
            // lb_carroModelo
            // 
            this.lb_carroModelo.AutoSize = true;
            this.lb_carroModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_carroModelo.Location = new System.Drawing.Point(13, 63);
            this.lb_carroModelo.Name = "lb_carroModelo";
            this.lb_carroModelo.Size = new System.Drawing.Size(48, 13);
            this.lb_carroModelo.TabIndex = 10;
            this.lb_carroModelo.Text = "Modelo :";
            // 
            // lb_carroCombustivel
            // 
            this.lb_carroCombustivel.AutoSize = true;
            this.lb_carroCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_carroCombustivel.Location = new System.Drawing.Point(114, 63);
            this.lb_carroCombustivel.Name = "lb_carroCombustivel";
            this.lb_carroCombustivel.Size = new System.Drawing.Size(70, 13);
            this.lb_carroCombustivel.TabIndex = 11;
            this.lb_carroCombustivel.Text = "Combustivel :";
            // 
            // lb_carroChassi
            // 
            this.lb_carroChassi.AutoSize = true;
            this.lb_carroChassi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_carroChassi.Location = new System.Drawing.Point(9, 17);
            this.lb_carroChassi.Name = "lb_carroChassi";
            this.lb_carroChassi.Size = new System.Drawing.Size(59, 13);
            this.lb_carroChassi.TabIndex = 9;
            this.lb_carroChassi.Text = "Nº Chassi :";
            // 
            // lb_carroMarca
            // 
            this.lb_carroMarca.AutoSize = true;
            this.lb_carroMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_carroMarca.Location = new System.Drawing.Point(98, 17);
            this.lb_carroMarca.Name = "lb_carroMarca";
            this.lb_carroMarca.Size = new System.Drawing.Size(43, 13);
            this.lb_carroMarca.TabIndex = 8;
            this.lb_carroMarca.Text = "Marca :";
            // 
            // TB_inf_data
            // 
            this.TB_inf_data.Enabled = false;
            this.TB_inf_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_inf_data.Location = new System.Drawing.Point(64, 19);
            this.TB_inf_data.Name = "TB_inf_data";
            this.TB_inf_data.Size = new System.Drawing.Size(110, 20);
            this.TB_inf_data.TabIndex = 45;
            this.TB_inf_data.Text = "Nenhum";
            // 
            // TB_inf_estado
            // 
            this.TB_inf_estado.Enabled = false;
            this.TB_inf_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_inf_estado.Location = new System.Drawing.Point(64, 45);
            this.TB_inf_estado.Name = "TB_inf_estado";
            this.TB_inf_estado.Size = new System.Drawing.Size(91, 20);
            this.TB_inf_estado.TabIndex = 44;
            this.TB_inf_estado.Text = "Nenhum";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(19, 48);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(46, 13);
            this.label24.TabIndex = 15;
            this.label24.Text = "Estado :";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_parcelasValorTotal
            // 
            this.lb_parcelasValorTotal.AutoSize = true;
            this.lb_parcelasValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_parcelasValorTotal.Location = new System.Drawing.Point(241, 277);
            this.lb_parcelasValorTotal.Name = "lb_parcelasValorTotal";
            this.lb_parcelasValorTotal.Size = new System.Drawing.Size(13, 13);
            this.lb_parcelasValorTotal.TabIndex = 13;
            this.lb_parcelasValorTotal.Text = "€";
            this.lb_parcelasValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(16, 22);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(36, 13);
            this.label23.TabIndex = 14;
            this.label23.Text = "Data :";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(106, 277);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(49, 13);
            this.label22.TabIndex = 12;
            this.label22.Text = "VALOR :";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "***************************************************************";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(112, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 27);
            this.label7.TabIndex = 18;
            this.label7.Text = "VENDA";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(22, 473);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(259, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "***************************************************************";
            // 
            // BT_exportar
            // 
            this.BT_exportar.BackColor = System.Drawing.Color.Transparent;
            this.BT_exportar.BackgroundImage = global::GesStand.Properties.Resources.bt_exportar;
            this.BT_exportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BT_exportar.ForeColor = System.Drawing.Color.Transparent;
            this.BT_exportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BT_exportar.Location = new System.Drawing.Point(130, 488);
            this.BT_exportar.Name = "BT_exportar";
            this.BT_exportar.Size = new System.Drawing.Size(46, 43);
            this.BT_exportar.TabIndex = 9;
            this.BT_exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BT_exportar.UseVisualStyleBackColor = false;
            this.BT_exportar.Click += new System.EventHandler(this.BT_exportar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::GesStand.Properties.Resources.logo_venda;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(73, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // BT_inserirVenda
            // 
            this.BT_inserirVenda.BackColor = System.Drawing.Color.Transparent;
            this.BT_inserirVenda.BackgroundImage = global::GesStand.Properties.Resources.guardar;
            this.BT_inserirVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BT_inserirVenda.Location = new System.Drawing.Point(188, 478);
            this.BT_inserirVenda.Name = "BT_inserirVenda";
            this.BT_inserirVenda.Size = new System.Drawing.Size(42, 39);
            this.BT_inserirVenda.TabIndex = 8;
            this.BT_inserirVenda.UseVisualStyleBackColor = false;
            this.BT_inserirVenda.Click += new System.EventHandler(this.bt_inserirVenda_Click);
            // 
            // Form_Gestao_Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1158, 631);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Gestao_Vendas";
            this.Text = "Gestão Vendas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Gestão_Vendas_FormClosing);
            this.Load += new System.EventHandler(this.Gestão_Vendas_Load);
            this.groupBox1.ResumeLayout(false);
            this.CARRO.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox CARRO;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BT_removerVenda;
        private System.Windows.Forms.Button BT_inserirVenda;
        private System.Windows.Forms.TextBox tb_extras;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_combustivel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_modelo;
        private System.Windows.Forms.TextBox tb_marca;
        private System.Windows.Forms.TextBox tb_chassi;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DateTimePicker dateTimePicker_data;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_valor;
        private System.Windows.Forms.TextBox tb_estado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lb_extras;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox LIST_venda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox TB_inf_contacto;
        private System.Windows.Forms.TextBox TB_inf_nif;
        private System.Windows.Forms.TextBox TB_inf_nome;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lb_clienteContacto;
        private System.Windows.Forms.Label lb_clienteNif;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox TB_inf_extras;
        private System.Windows.Forms.TextBox TB_inf_modelo;
        private System.Windows.Forms.TextBox TB_inf_combustivel;
        private System.Windows.Forms.TextBox TB_inf_marca;
        private System.Windows.Forms.TextBox TB_inf_nchassi;
        private System.Windows.Forms.Label lb_carroModelo;
        private System.Windows.Forms.Label lb_carroCombustivel;
        private System.Windows.Forms.Label lb_carroChassi;
        private System.Windows.Forms.Label lb_carroMarca;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox TB_inf_valor;
        private System.Windows.Forms.TextBox TB_inf_data;
        private System.Windows.Forms.TextBox TB_inf_estado;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lb_parcelasValorTotal;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button BT_exportar;
        private System.Windows.Forms.SaveFileDialog saveFileDialogFicheiroTexto;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ListBox LIST_clientes;
    }
}