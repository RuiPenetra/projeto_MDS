namespace GesStand.Forms
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
            this.LB_clientes = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.bt_remvParcela = new System.Windows.Forms.Button();
            this.tb_p_valor = new System.Windows.Forms.TextBox();
            this.bt_addParcela = new System.Windows.Forms.Button();
            this.tb_p_descricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_Parcelas = new System.Windows.Forms.ListBox();
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
            this.LB_Servicos = new System.Windows.Forms.ListBox();
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
            this.LB_carros = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label29 = new System.Windows.Forms.Label();
            this.lb_clienteContacto = new System.Windows.Forms.Label();
            this.lb_clienteNif = new System.Windows.Forms.Label();
            this.lb_clienteNome = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.lb_carroModelo = new System.Windows.Forms.Label();
            this.lb_carroCombustivel = new System.Windows.Forms.Label();
            this.lb_carroChassi = new System.Windows.Forms.Label();
            this.lb_carroMarca = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.lb_servicoTipo = new System.Windows.Forms.Label();
            this.lb_servicoDataSaida = new System.Windows.Forms.Label();
            this.lb_servicoDataEntrada = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.lb_parcelasValorTotal = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_exportar = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.LB_clientes);
            this.groupBox1.Location = new System.Drawing.Point(26, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 445);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione um cliente";
            // 
            // LB_clientes
            // 
            this.LB_clientes.FormattingEnabled = true;
            this.LB_clientes.Location = new System.Drawing.Point(11, 28);
            this.LB_clientes.Name = "LB_clientes";
            this.LB_clientes.Size = new System.Drawing.Size(212, 394);
            this.LB_clientes.TabIndex = 1;
            this.LB_clientes.SelectedIndexChanged += new System.EventHandler(this.LB_clientes_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox4.Controls.Add(this.groupBox8);
            this.groupBox4.Controls.Add(this.LB_Parcelas);
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
            // LB_Parcelas
            // 
            this.LB_Parcelas.FormattingEnabled = true;
            this.LB_Parcelas.Location = new System.Drawing.Point(11, 22);
            this.LB_Parcelas.Name = "LB_Parcelas";
            this.LB_Parcelas.Size = new System.Drawing.Size(191, 303);
            this.LB_Parcelas.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.LB_Servicos);
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
            // LB_Servicos
            // 
            this.LB_Servicos.FormattingEnabled = true;
            this.LB_Servicos.Location = new System.Drawing.Point(12, 19);
            this.LB_Servicos.Name = "LB_Servicos";
            this.LB_Servicos.Size = new System.Drawing.Size(181, 303);
            this.LB_Servicos.TabIndex = 0;
            this.LB_Servicos.SelectedIndexChanged += new System.EventHandler(this.LB_Servicos_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.LB_carros);
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
            // LB_carros
            // 
            this.LB_carros.FormattingEnabled = true;
            this.LB_carros.Location = new System.Drawing.Point(20, 19);
            this.LB_carros.Name = "LB_carros";
            this.LB_carros.Size = new System.Drawing.Size(207, 238);
            this.LB_carros.TabIndex = 0;
            this.LB_carros.SelectedIndexChanged += new System.EventHandler(this.LB_carros_SelectedIndexChanged);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.groupBox11);
            this.panel2.Controls.Add(this.groupBox10);
            this.panel2.Controls.Add(this.groupBox9);
            this.panel2.Controls.Add(this.groupBox5);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.bt_exportar);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(1019, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 495);
            this.panel2.TabIndex = 13;
            // 
            // groupBox11
            // 
            this.groupBox11.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox11.Controls.Add(this.label29);
            this.groupBox11.Controls.Add(this.lb_clienteContacto);
            this.groupBox11.Controls.Add(this.lb_clienteNif);
            this.groupBox11.Controls.Add(this.lb_clienteNome);
            this.groupBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox11.Location = new System.Drawing.Point(13, 52);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(263, 111);
            this.groupBox11.TabIndex = 29;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "CLIENTE";
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
            this.lb_clienteContacto.Location = new System.Drawing.Point(14, 86);
            this.lb_clienteContacto.Name = "lb_clienteContacto";
            this.lb_clienteContacto.Size = new System.Drawing.Size(115, 13);
            this.lb_clienteContacto.TabIndex = 33;
            this.lb_clienteContacto.Text = "Contacto : ########";
            // 
            // lb_clienteNif
            // 
            this.lb_clienteNif.AutoSize = true;
            this.lb_clienteNif.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_clienteNif.Location = new System.Drawing.Point(14, 55);
            this.lb_clienteNif.Name = "lb_clienteNif";
            this.lb_clienteNif.Size = new System.Drawing.Size(85, 13);
            this.lb_clienteNif.TabIndex = 32;
            this.lb_clienteNif.Text = "Nif : ########";
            // 
            // lb_clienteNome
            // 
            this.lb_clienteNome.AutoSize = true;
            this.lb_clienteNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_clienteNome.Location = new System.Drawing.Point(16, 25);
            this.lb_clienteNome.Name = "lb_clienteNome";
            this.lb_clienteNome.Size = new System.Drawing.Size(122, 13);
            this.lb_clienteNome.TabIndex = 29;
            this.lb_clienteNome.Text = "Sem cliente selecionado";
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox10.Controls.Add(this.lb_carroModelo);
            this.groupBox10.Controls.Add(this.lb_carroCombustivel);
            this.groupBox10.Controls.Add(this.lb_carroChassi);
            this.groupBox10.Controls.Add(this.lb_carroMarca);
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.Location = new System.Drawing.Point(13, 169);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(263, 92);
            this.groupBox10.TabIndex = 28;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "CARRO";
            // 
            // lb_carroModelo
            // 
            this.lb_carroModelo.AutoSize = true;
            this.lb_carroModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_carroModelo.Location = new System.Drawing.Point(10, 62);
            this.lb_carroModelo.Name = "lb_carroModelo";
            this.lb_carroModelo.Size = new System.Drawing.Size(110, 13);
            this.lb_carroModelo.TabIndex = 10;
            this.lb_carroModelo.Text = "Modelo :  ########";
            // 
            // lb_carroCombustivel
            // 
            this.lb_carroCombustivel.AutoSize = true;
            this.lb_carroCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_carroCombustivel.Location = new System.Drawing.Point(126, 62);
            this.lb_carroCombustivel.Name = "lb_carroCombustivel";
            this.lb_carroCombustivel.Size = new System.Drawing.Size(132, 13);
            this.lb_carroCombustivel.TabIndex = 11;
            this.lb_carroCombustivel.Text = "Combustivel :  ########";
            // 
            // lb_carroChassi
            // 
            this.lb_carroChassi.AutoSize = true;
            this.lb_carroChassi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_carroChassi.Location = new System.Drawing.Point(10, 21);
            this.lb_carroChassi.Name = "lb_carroChassi";
            this.lb_carroChassi.Size = new System.Drawing.Size(121, 13);
            this.lb_carroChassi.TabIndex = 9;
            this.lb_carroChassi.Text = "Nº Chassi :  ########";
            // 
            // lb_carroMarca
            // 
            this.lb_carroMarca.AutoSize = true;
            this.lb_carroMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_carroMarca.Location = new System.Drawing.Point(146, 21);
            this.lb_carroMarca.Name = "lb_carroMarca";
            this.lb_carroMarca.Size = new System.Drawing.Size(105, 13);
            this.lb_carroMarca.TabIndex = 8;
            this.lb_carroMarca.Text = "Marca :  ########";
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox9.Controls.Add(this.lb_servicoTipo);
            this.groupBox9.Controls.Add(this.lb_servicoDataSaida);
            this.groupBox9.Controls.Add(this.lb_servicoDataEntrada);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(13, 267);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(263, 75);
            this.groupBox9.TabIndex = 15;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "SERVICO";
            // 
            // lb_servicoTipo
            // 
            this.lb_servicoTipo.AutoSize = true;
            this.lb_servicoTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_servicoTipo.Location = new System.Drawing.Point(154, 35);
            this.lb_servicoTipo.Name = "lb_servicoTipo";
            this.lb_servicoTipo.Size = new System.Drawing.Size(86, 13);
            this.lb_servicoTipo.TabIndex = 27;
            this.lb_servicoTipo.Text = "Tipo : #######";
            // 
            // lb_servicoDataSaida
            // 
            this.lb_servicoDataSaida.AutoSize = true;
            this.lb_servicoDataSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_servicoDataSaida.Location = new System.Drawing.Point(18, 47);
            this.lb_servicoDataSaida.Name = "lb_servicoDataSaida";
            this.lb_servicoDataSaida.Size = new System.Drawing.Size(128, 13);
            this.lb_servicoDataSaida.TabIndex = 26;
            this.lb_servicoDataSaida.Text = "Data Saida :  ########";
            // 
            // lb_servicoDataEntrada
            // 
            this.lb_servicoDataEntrada.AutoSize = true;
            this.lb_servicoDataEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_servicoDataEntrada.Location = new System.Drawing.Point(9, 22);
            this.lb_servicoDataEntrada.Name = "lb_servicoDataEntrada";
            this.lb_servicoDataEntrada.Size = new System.Drawing.Size(138, 13);
            this.lb_servicoDataEntrada.TabIndex = 24;
            this.lb_servicoDataEntrada.Text = "Data Entrada :  ########";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.LightGray;
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.lb_parcelasValorTotal);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(14, 351);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(262, 58);
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
            this.label22.Size = new System.Drawing.Size(84, 13);
            this.label22.TabIndex = 12;
            this.label22.Text = "VALOR TOTAL ";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_parcelasValorTotal
            // 
            this.lb_parcelasValorTotal.AutoSize = true;
            this.lb_parcelasValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_parcelasValorTotal.Location = new System.Drawing.Point(136, 25);
            this.lb_parcelasValorTotal.Name = "lb_parcelasValorTotal";
            this.lb_parcelasValorTotal.Size = new System.Drawing.Size(37, 13);
            this.lb_parcelasValorTotal.TabIndex = 13;
            this.lb_parcelasValorTotal.Text = "_,__ €";
            this.lb_parcelasValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(17, 32);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(259, 13);
            this.label17.TabIndex = 19;
            this.label17.Text = "***************************************************************";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 27);
            this.label3.TabIndex = 18;
            this.label3.Text = "OFICINA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "***************************************************************";
            // 
            // bt_exportar
            // 
            this.bt_exportar.BackColor = System.Drawing.Color.Transparent;
            this.bt_exportar.BackgroundImage = global::GesStand.Properties.Resources.export1;
            this.bt_exportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_exportar.ForeColor = System.Drawing.Color.Transparent;
            this.bt_exportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_exportar.Location = new System.Drawing.Point(122, 439);
            this.bt_exportar.Name = "bt_exportar";
            this.bt_exportar.Size = new System.Drawing.Size(47, 44);
            this.bt_exportar.TabIndex = 9;
            this.bt_exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_exportar.UseVisualStyleBackColor = false;
            this.bt_exportar.Click += new System.EventHandler(this.bt_exportar_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(17, 171);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(259, 13);
            this.label20.TabIndex = 1;
            this.label20.Text = "***************************************************************";
            // 
            // Form_GestaoOficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::GesStand.Properties.Resources.logo_gesStand_fatura;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1336, 689);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox LB_clientes;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button bt_remvParcela;
        private System.Windows.Forms.TextBox tb_p_valor;
        private System.Windows.Forms.Button bt_addParcela;
        private System.Windows.Forms.TextBox tb_p_descricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LB_Parcelas;
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
        private System.Windows.Forms.ListBox LB_Servicos;
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
        private System.Windows.Forms.ListBox LB_carros;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_exportar;
        private System.Windows.Forms.Label lb_parcelasValorTotal;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lb_clienteContacto;
        private System.Windows.Forms.Label lb_clienteNif;
        private System.Windows.Forms.Label lb_clienteNome;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label lb_carroModelo;
        private System.Windows.Forms.Label lb_carroCombustivel;
        private System.Windows.Forms.Label lb_carroChassi;
        private System.Windows.Forms.Label lb_carroMarca;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label lb_servicoTipo;
        private System.Windows.Forms.Label lb_servicoDataSaida;
        private System.Windows.Forms.Label lb_servicoDataEntrada;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}