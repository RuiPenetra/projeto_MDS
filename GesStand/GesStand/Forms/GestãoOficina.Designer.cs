﻿namespace GesStand.Forms
{
    partial class Form_GestaoOficina
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LIST_clientes = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.bt_remvParcela = new System.Windows.Forms.Button();
            this.tb_p_valor = new System.Windows.Forms.TextBox();
            this.bt_addParcela = new System.Windows.Forms.Button();
            this.tb_p_descricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LIST_Parcelas = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tb_s_servicoTipo = new System.Windows.Forms.TextBox();
            this.bt_addServico = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePickerDataFim = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDataInicio = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.bt_remvServico = new System.Windows.Forms.Button();
            this.LIST_Servicos = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tb_c_combustivel = new System.Windows.Forms.TextBox();
            this.bt_remvCarro = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_c_modelo = new System.Windows.Forms.TextBox();
            this.tb_c_marca = new System.Windows.Forms.TextBox();
            this.tb_c_nChassis = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_c_kms = new System.Windows.Forms.TextBox();
            this.bt_addCarro = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_c_matricula = new System.Windows.Forms.TextBox();
            this.LIST_carros = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.TB_inf_contacto = new System.Windows.Forms.TextBox();
            this.TB_inf_nif = new System.Windows.Forms.TextBox();
            this.TB_inf_nome = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.TB_inf_modelo = new System.Windows.Forms.TextBox();
            this.TB_inf_combustivel = new System.Windows.Forms.TextBox();
            this.TB_inf_marca = new System.Windows.Forms.TextBox();
            this.TB_inf_nchassi = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.TB_inf_valor = new System.Windows.Forms.TextBox();
            this.TB_inf_dt_fim = new System.Windows.Forms.TextBox();
            this.TB_inf_dt_inicio = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.BT_exportar = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.TB_inf_tipo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.LIST_clientes);
            this.groupBox1.Location = new System.Drawing.Point(26, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 445);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione um cliente";
            // 
            // LIST_clientes
            // 
            this.LIST_clientes.FormattingEnabled = true;
            this.LIST_clientes.Location = new System.Drawing.Point(11, 28);
            this.LIST_clientes.Name = "LIST_clientes";
            this.LIST_clientes.Size = new System.Drawing.Size(212, 394);
            this.LIST_clientes.TabIndex = 1;
            this.LIST_clientes.SelectedIndexChanged += new System.EventHandler(this.LB_clientes_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox4.Controls.Add(this.groupBox8);
            this.groupBox4.Controls.Add(this.LIST_Parcelas);
            this.groupBox4.Location = new System.Drawing.Point(784, 76);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(213, 503);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parcelas";
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.White;
            this.groupBox8.Controls.Add(this.bt_remvParcela);
            this.groupBox8.Controls.Add(this.tb_p_valor);
            this.groupBox8.Controls.Add(this.bt_addParcela);
            this.groupBox8.Controls.Add(this.tb_p_descricao);
            this.groupBox8.Controls.Add(this.label2);
            this.groupBox8.Controls.Add(this.label1);
            this.groupBox8.Location = new System.Drawing.Point(15, 336);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(187, 155);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Novo";
            // 
            // bt_remvParcela
            // 
            this.bt_remvParcela.BackColor = System.Drawing.Color.Transparent;
            this.bt_remvParcela.BackgroundImage = global::GesStand.Properties.Resources.bt_remover_client;
            this.bt_remvParcela.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_remvParcela.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_remvParcela.Location = new System.Drawing.Point(110, 97);
            this.bt_remvParcela.Name = "bt_remvParcela";
            this.bt_remvParcela.Size = new System.Drawing.Size(44, 42);
            this.bt_remvParcela.TabIndex = 7;
            this.bt_remvParcela.UseVisualStyleBackColor = false;
            this.bt_remvParcela.Click += new System.EventHandler(this.bt_remvParcela_Click);
            // 
            // tb_p_valor
            // 
            this.tb_p_valor.Location = new System.Drawing.Point(70, 56);
            this.tb_p_valor.Name = "tb_p_valor";
            this.tb_p_valor.Size = new System.Drawing.Size(100, 20);
            this.tb_p_valor.TabIndex = 5;
            // 
            // bt_addParcela
            // 
            this.bt_addParcela.BackColor = System.Drawing.Color.Transparent;
            this.bt_addParcela.BackgroundImage = global::GesStand.Properties.Resources.bt_gravar_client;
            this.bt_addParcela.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_addParcela.Location = new System.Drawing.Point(49, 96);
            this.bt_addParcela.Name = "bt_addParcela";
            this.bt_addParcela.Size = new System.Drawing.Size(39, 42);
            this.bt_addParcela.TabIndex = 1;
            this.bt_addParcela.UseVisualStyleBackColor = false;
            this.bt_addParcela.Click += new System.EventHandler(this.bt_addParcela_Click);
            // 
            // tb_p_descricao
            // 
            this.tb_p_descricao.Location = new System.Drawing.Point(70, 27);
            this.tb_p_descricao.Name = "tb_p_descricao";
            this.tb_p_descricao.Size = new System.Drawing.Size(100, 20);
            this.tb_p_descricao.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descrição :";
            // 
            // LIST_Parcelas
            // 
            this.LIST_Parcelas.FormattingEnabled = true;
            this.LIST_Parcelas.Location = new System.Drawing.Point(11, 22);
            this.LIST_Parcelas.Name = "LIST_Parcelas";
            this.LIST_Parcelas.Size = new System.Drawing.Size(191, 303);
            this.LIST_Parcelas.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.LIST_Servicos);
            this.groupBox3.Location = new System.Drawing.Point(556, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox3.Size = new System.Drawing.Size(209, 524);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Serviços";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.White;
            this.groupBox7.Controls.Add(this.tb_s_servicoTipo);
            this.groupBox7.Controls.Add(this.bt_addServico);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.dateTimePickerDataFim);
            this.groupBox7.Controls.Add(this.dateTimePickerDataInicio);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.bt_remvServico);
            this.groupBox7.Location = new System.Drawing.Point(14, 335);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(179, 175);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Novo";
            // 
            // tb_s_servicoTipo
            // 
            this.tb_s_servicoTipo.Location = new System.Drawing.Point(61, 94);
            this.tb_s_servicoTipo.Name = "tb_s_servicoTipo";
            this.tb_s_servicoTipo.Size = new System.Drawing.Size(95, 20);
            this.tb_s_servicoTipo.TabIndex = 16;
            // 
            // bt_addServico
            // 
            this.bt_addServico.BackColor = System.Drawing.Color.Transparent;
            this.bt_addServico.BackgroundImage = global::GesStand.Properties.Resources.bt_gravar_client;
            this.bt_addServico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_addServico.Location = new System.Drawing.Point(44, 125);
            this.bt_addServico.Name = "bt_addServico";
            this.bt_addServico.Size = new System.Drawing.Size(39, 42);
            this.bt_addServico.TabIndex = 6;
            this.bt_addServico.UseVisualStyleBackColor = false;
            this.bt_addServico.Click += new System.EventHandler(this.bt_addServico_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(28, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "Tipo :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Data Inicio :";
            // 
            // dateTimePickerDataFim
            // 
            this.dateTimePickerDataFim.CustomFormat = "";
            this.dateTimePickerDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataFim.Location = new System.Drawing.Point(75, 62);
            this.dateTimePickerDataFim.Name = "dateTimePickerDataFim";
            this.dateTimePickerDataFim.Size = new System.Drawing.Size(95, 20);
            this.dateTimePickerDataFim.TabIndex = 7;
            this.dateTimePickerDataFim.Value = new System.DateTime(2019, 5, 24, 0, 0, 0, 0);
            // 
            // dateTimePickerDataInicio
            // 
            this.dateTimePickerDataInicio.CustomFormat = "";
            this.dateTimePickerDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataInicio.Location = new System.Drawing.Point(75, 36);
            this.dateTimePickerDataInicio.Name = "dateTimePickerDataInicio";
            this.dateTimePickerDataInicio.Size = new System.Drawing.Size(95, 20);
            this.dateTimePickerDataInicio.TabIndex = 6;
            this.dateTimePickerDataInicio.Value = new System.DateTime(2019, 5, 24, 0, 3, 20, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Data Fim :";
            // 
            // bt_remvServico
            // 
            this.bt_remvServico.BackColor = System.Drawing.Color.Transparent;
            this.bt_remvServico.BackgroundImage = global::GesStand.Properties.Resources.bt_remover_client;
            this.bt_remvServico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_remvServico.Location = new System.Drawing.Point(101, 125);
            this.bt_remvServico.Name = "bt_remvServico";
            this.bt_remvServico.Size = new System.Drawing.Size(44, 42);
            this.bt_remvServico.TabIndex = 1;
            this.bt_remvServico.UseVisualStyleBackColor = false;
            this.bt_remvServico.Click += new System.EventHandler(this.bt_remvServico_Click);
            // 
            // LIST_Servicos
            // 
            this.LIST_Servicos.FormattingEnabled = true;
            this.LIST_Servicos.Location = new System.Drawing.Point(12, 19);
            this.LIST_Servicos.Name = "LIST_Servicos";
            this.LIST_Servicos.Size = new System.Drawing.Size(181, 303);
            this.LIST_Servicos.TabIndex = 0;
            this.LIST_Servicos.SelectedIndexChanged += new System.EventHandler(this.LB_Servicos_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.LIST_carros);
            this.groupBox2.Location = new System.Drawing.Point(291, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 530);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Carros";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.White;
            this.groupBox6.Controls.Add(this.tb_c_combustivel);
            this.groupBox6.Controls.Add(this.bt_remvCarro);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.tb_c_modelo);
            this.groupBox6.Controls.Add(this.tb_c_marca);
            this.groupBox6.Controls.Add(this.tb_c_nChassis);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.tb_c_kms);
            this.groupBox6.Controls.Add(this.bt_addCarro);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.tb_c_matricula);
            this.groupBox6.Location = new System.Drawing.Point(21, 265);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(206, 253);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Novo";
            // 
            // tb_c_combustivel
            // 
            this.tb_c_combustivel.Location = new System.Drawing.Point(76, 108);
            this.tb_c_combustivel.Name = "tb_c_combustivel";
            this.tb_c_combustivel.Size = new System.Drawing.Size(119, 20);
            this.tb_c_combustivel.TabIndex = 15;
            // 
            // bt_remvCarro
            // 
            this.bt_remvCarro.BackColor = System.Drawing.Color.Transparent;
            this.bt_remvCarro.BackgroundImage = global::GesStand.Properties.Resources.bt_remover_client;
            this.bt_remvCarro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_remvCarro.Location = new System.Drawing.Point(111, 202);
            this.bt_remvCarro.Name = "bt_remvCarro";
            this.bt_remvCarro.Size = new System.Drawing.Size(44, 42);
            this.bt_remvCarro.TabIndex = 2;
            this.bt_remvCarro.UseVisualStyleBackColor = false;
            this.bt_remvCarro.Click += new System.EventHandler(this.bt_remvCarro_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 111);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Combustivel";
            // 
            // tb_c_modelo
            // 
            this.tb_c_modelo.Location = new System.Drawing.Point(76, 79);
            this.tb_c_modelo.Name = "tb_c_modelo";
            this.tb_c_modelo.Size = new System.Drawing.Size(119, 20);
            this.tb_c_modelo.TabIndex = 13;
            // 
            // tb_c_marca
            // 
            this.tb_c_marca.Location = new System.Drawing.Point(76, 50);
            this.tb_c_marca.Name = "tb_c_marca";
            this.tb_c_marca.Size = new System.Drawing.Size(119, 20);
            this.tb_c_marca.TabIndex = 12;
            // 
            // tb_c_nChassis
            // 
            this.tb_c_nChassis.Location = new System.Drawing.Point(76, 21);
            this.tb_c_nChassis.Name = "tb_c_nChassis";
            this.tb_c_nChassis.Size = new System.Drawing.Size(119, 20);
            this.tb_c_nChassis.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Modelo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Marca";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Kms";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "NºChassis";
            // 
            // tb_c_kms
            // 
            this.tb_c_kms.Location = new System.Drawing.Point(76, 166);
            this.tb_c_kms.Name = "tb_c_kms";
            this.tb_c_kms.Size = new System.Drawing.Size(119, 20);
            this.tb_c_kms.TabIndex = 6;
            this.tb_c_kms.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_c_kms_KeyPress);
            // 
            // bt_addCarro
            // 
            this.bt_addCarro.BackColor = System.Drawing.Color.Transparent;
            this.bt_addCarro.BackgroundImage = global::GesStand.Properties.Resources.bt_gravar_client;
            this.bt_addCarro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_addCarro.Location = new System.Drawing.Point(55, 202);
            this.bt_addCarro.Name = "bt_addCarro";
            this.bt_addCarro.Size = new System.Drawing.Size(39, 42);
            this.bt_addCarro.TabIndex = 1;
            this.bt_addCarro.UseVisualStyleBackColor = false;
            this.bt_addCarro.Click += new System.EventHandler(this.bt_addCarro_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Matricula";
            // 
            // tb_c_matricula
            // 
            this.tb_c_matricula.Location = new System.Drawing.Point(76, 137);
            this.tb_c_matricula.Name = "tb_c_matricula";
            this.tb_c_matricula.Size = new System.Drawing.Size(119, 20);
            this.tb_c_matricula.TabIndex = 3;
            // 
            // LIST_carros
            // 
            this.LIST_carros.FormattingEnabled = true;
            this.LIST_carros.Location = new System.Drawing.Point(20, 19);
            this.LIST_carros.Name = "LIST_carros";
            this.LIST_carros.Size = new System.Drawing.Size(207, 238);
            this.LIST_carros.TabIndex = 0;
            this.LIST_carros.SelectedIndexChanged += new System.EventHandler(this.LB_carros_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GesStand.Properties.Resources.rep;
            this.pictureBox1.Location = new System.Drawing.Point(64, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.LightGray;
            this.groupBox5.Controls.Add(this.TB_inf_valor);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(19, 406);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(270, 58);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "PARCELAS";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(20, 25);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(87, 13);
            this.label22.TabIndex = 12;
            this.label22.Text = "VALOR TOTAL :";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.groupBox12);
            this.panel1.Controls.Add(this.groupBox13);
            this.panel1.Controls.Add(this.groupBox14);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.label30);
            this.panel1.Controls.Add(this.label31);
            this.panel1.Controls.Add(this.label32);
            this.panel1.Controls.Add(this.BT_exportar);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(1021, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 545);
            this.panel1.TabIndex = 15;
            // 
            // groupBox12
            // 
            this.groupBox12.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox12.Controls.Add(this.TB_inf_contacto);
            this.groupBox12.Controls.Add(this.TB_inf_nif);
            this.groupBox12.Controls.Add(this.TB_inf_nome);
            this.groupBox12.Controls.Add(this.label18);
            this.groupBox12.Controls.Add(this.label5);
            this.groupBox12.Controls.Add(this.label6);
            this.groupBox12.Controls.Add(this.label16);
            this.groupBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox12.Location = new System.Drawing.Point(18, 52);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(270, 111);
            this.groupBox12.TabIndex = 29;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "CLIENTE";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, -24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 24);
            this.label5.TabIndex = 34;
            this.label5.Text = "Sem cliente selecionado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Contacto :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(16, 51);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Nif :";
            // 
            // groupBox13
            // 
            this.groupBox13.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox13.Controls.Add(this.TB_inf_modelo);
            this.groupBox13.Controls.Add(this.TB_inf_combustivel);
            this.groupBox13.Controls.Add(this.TB_inf_marca);
            this.groupBox13.Controls.Add(this.TB_inf_nchassi);
            this.groupBox13.Controls.Add(this.label19);
            this.groupBox13.Controls.Add(this.label21);
            this.groupBox13.Controls.Add(this.label23);
            this.groupBox13.Controls.Add(this.label24);
            this.groupBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox13.Location = new System.Drawing.Point(18, 169);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(271, 105);
            this.groupBox13.TabIndex = 28;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "CARRO";
            // 
            // TB_inf_modelo
            // 
            this.TB_inf_modelo.Enabled = false;
            this.TB_inf_modelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_inf_modelo.Location = new System.Drawing.Point(182, 43);
            this.TB_inf_modelo.Name = "TB_inf_modelo";
            this.TB_inf_modelo.Size = new System.Drawing.Size(75, 20);
            this.TB_inf_modelo.TabIndex = 42;
            this.TB_inf_modelo.Text = "Nenhum";
            // 
            // TB_inf_combustivel
            // 
            this.TB_inf_combustivel.Enabled = false;
            this.TB_inf_combustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_inf_combustivel.Location = new System.Drawing.Point(82, 69);
            this.TB_inf_combustivel.Name = "TB_inf_combustivel";
            this.TB_inf_combustivel.Size = new System.Drawing.Size(92, 20);
            this.TB_inf_combustivel.TabIndex = 41;
            this.TB_inf_combustivel.Text = "Nenhum";
            // 
            // TB_inf_marca
            // 
            this.TB_inf_marca.Enabled = false;
            this.TB_inf_marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_inf_marca.Location = new System.Drawing.Point(56, 44);
            this.TB_inf_marca.Name = "TB_inf_marca";
            this.TB_inf_marca.Size = new System.Drawing.Size(75, 20);
            this.TB_inf_marca.TabIndex = 40;
            this.TB_inf_marca.Text = "Nenhum";
            // 
            // TB_inf_nchassi
            // 
            this.TB_inf_nchassi.Enabled = false;
            this.TB_inf_nchassi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_inf_nchassi.Location = new System.Drawing.Point(69, 18);
            this.TB_inf_nchassi.Name = "TB_inf_nchassi";
            this.TB_inf_nchassi.Size = new System.Drawing.Size(87, 20);
            this.TB_inf_nchassi.TabIndex = 39;
            this.TB_inf_nchassi.Text = "Nenhum";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(137, 46);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 13);
            this.label19.TabIndex = 10;
            this.label19.Text = "Modelo :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(12, 71);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(70, 13);
            this.label21.TabIndex = 11;
            this.label21.Text = "Combustivel :";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(10, 21);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(59, 13);
            this.label23.TabIndex = 9;
            this.label23.Text = "Nº Chassi :";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(12, 47);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(43, 13);
            this.label24.TabIndex = 8;
            this.label24.Text = "Marca :";
            // 
            // groupBox14
            // 
            this.groupBox14.BackColor = System.Drawing.Color.LightGray;
            this.groupBox14.Controls.Add(this.TB_inf_tipo);
            this.groupBox14.Controls.Add(this.label33);
            this.groupBox14.Controls.Add(this.TB_inf_dt_fim);
            this.groupBox14.Controls.Add(this.TB_inf_dt_inicio);
            this.groupBox14.Controls.Add(this.label25);
            this.groupBox14.Controls.Add(this.label27);
            this.groupBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox14.Location = new System.Drawing.Point(19, 281);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(270, 114);
            this.groupBox14.TabIndex = 14;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "SERVIÇO";
            // 
            // TB_inf_valor
            // 
            this.TB_inf_valor.Enabled = false;
            this.TB_inf_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_inf_valor.Location = new System.Drawing.Point(113, 22);
            this.TB_inf_valor.Name = "TB_inf_valor";
            this.TB_inf_valor.Size = new System.Drawing.Size(93, 20);
            this.TB_inf_valor.TabIndex = 46;
            this.TB_inf_valor.Text = "Nenhum";
            // 
            // TB_inf_dt_fim
            // 
            this.TB_inf_dt_fim.Enabled = false;
            this.TB_inf_dt_fim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_inf_dt_fim.Location = new System.Drawing.Point(70, 47);
            this.TB_inf_dt_fim.Name = "TB_inf_dt_fim";
            this.TB_inf_dt_fim.Size = new System.Drawing.Size(110, 20);
            this.TB_inf_dt_fim.TabIndex = 45;
            this.TB_inf_dt_fim.Text = "Nenhum";
            // 
            // TB_inf_dt_inicio
            // 
            this.TB_inf_dt_inicio.Enabled = false;
            this.TB_inf_dt_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_inf_dt_inicio.Location = new System.Drawing.Point(77, 21);
            this.TB_inf_dt_inicio.Name = "TB_inf_dt_inicio";
            this.TB_inf_dt_inicio.Size = new System.Drawing.Size(110, 20);
            this.TB_inf_dt_inicio.TabIndex = 44;
            this.TB_inf_dt_inicio.Text = "Nenhum";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(14, 24);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(64, 13);
            this.label25.TabIndex = 15;
            this.label25.Text = "Data Inicio :";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(207, 26);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(13, 13);
            this.label26.TabIndex = 13;
            this.label26.Text = "€";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(16, 49);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(55, 13);
            this.label27.TabIndex = 14;
            this.label27.Text = "Data Fim :";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(22, 36);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(259, 13);
            this.label30.TabIndex = 19;
            this.label30.Text = "***************************************************************";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(99, 6);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(100, 27);
            this.label31.TabIndex = 18;
            this.label31.Text = "OFICINA";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(22, 473);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(259, 13);
            this.label32.TabIndex = 16;
            this.label32.Text = "***************************************************************";
            // 
            // BT_exportar
            // 
            this.BT_exportar.BackColor = System.Drawing.Color.Transparent;
            this.BT_exportar.BackgroundImage = global::GesStand.Properties.Resources.export1;
            this.BT_exportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BT_exportar.ForeColor = System.Drawing.Color.Transparent;
            this.BT_exportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_exportar.Location = new System.Drawing.Point(133, 489);
            this.BT_exportar.Name = "BT_exportar";
            this.BT_exportar.Size = new System.Drawing.Size(47, 44);
            this.BT_exportar.TabIndex = 9;
            this.BT_exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BT_exportar.UseVisualStyleBackColor = false;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(16, 77);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(34, 13);
            this.label33.TabIndex = 46;
            this.label33.Text = "Tipo :";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_inf_tipo
            // 
            this.TB_inf_tipo.Enabled = false;
            this.TB_inf_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_inf_tipo.Location = new System.Drawing.Point(74, 74);
            this.TB_inf_tipo.Name = "TB_inf_tipo";
            this.TB_inf_tipo.Size = new System.Drawing.Size(110, 20);
            this.TB_inf_tipo.TabIndex = 47;
            this.TB_inf_tipo.Text = "Nenhum";
            // 
            // Form_GestaoOficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::GesStand.Properties.Resources.logo_gesStand_fatura;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1336, 689);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.DoubleBuffered = true;
            this.Name = "Form_GestaoOficina";
            this.Text = "Gestão Oficina";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_GestaoOficina_FormClosing);
            this.Load += new System.EventHandler(this.GestãoOficina_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox LIST_clientes;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button bt_remvParcela;
        private System.Windows.Forms.TextBox tb_p_valor;
        private System.Windows.Forms.Button bt_addParcela;
        private System.Windows.Forms.TextBox tb_p_descricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LIST_Parcelas;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox tb_s_servicoTipo;
        private System.Windows.Forms.Button bt_addServico;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataFim;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataInicio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bt_remvServico;
        private System.Windows.Forms.ListBox LIST_Servicos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox tb_c_combustivel;
        private System.Windows.Forms.Button bt_remvCarro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_c_modelo;
        private System.Windows.Forms.TextBox tb_c_marca;
        private System.Windows.Forms.TextBox tb_c_nChassis;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_c_kms;
        private System.Windows.Forms.Button bt_addCarro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_c_matricula;
        private System.Windows.Forms.ListBox LIST_carros;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TB_inf_valor;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.TextBox TB_inf_contacto;
        private System.Windows.Forms.TextBox TB_inf_nif;
        private System.Windows.Forms.TextBox TB_inf_nome;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.TextBox TB_inf_modelo;
        private System.Windows.Forms.TextBox TB_inf_combustivel;
        private System.Windows.Forms.TextBox TB_inf_marca;
        private System.Windows.Forms.TextBox TB_inf_nchassi;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.TextBox TB_inf_tipo;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox TB_inf_dt_fim;
        private System.Windows.Forms.TextBox TB_inf_dt_inicio;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Button BT_exportar;
    }
}