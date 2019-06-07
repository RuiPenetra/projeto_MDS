namespace GesStand.Forms
{
    partial class Form_Gestão_Alugueres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Gestão_Alugueres));
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.LIST_aluguer = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BT_removerAluguer = new System.Windows.Forms.Button();
            this.tb_kms = new System.Windows.Forms.TextBox();
            this.BT_inserirAluguer = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker_data_fim = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker_data_inicio = new System.Windows.Forms.DateTimePicker();
            this.tb_valor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CARRO = new System.Windows.Forms.GroupBox();
            this.LIST_carro = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_matricula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_combustivel = new System.Windows.Forms.TextBox();
            this.BT_removerCarro = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BT_inserirCarro = new System.Windows.Forms.Button();
            this.tb_modelo = new System.Windows.Forms.TextBox();
            this.tb_marca = new System.Windows.Forms.TextBox();
            this.tb_chassi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LIST_clientes = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.TB_inf_contacto = new System.Windows.Forms.TextBox();
            this.TB_inf_nif = new System.Windows.Forms.TextBox();
            this.TB_inf_nome = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.lb_clienteContacto = new System.Windows.Forms.Label();
            this.lb_clienteNif = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.TB_inf_matricula = new System.Windows.Forms.TextBox();
            this.TB_inf_modelo = new System.Windows.Forms.TextBox();
            this.TB_inf_combustivel = new System.Windows.Forms.TextBox();
            this.TB_inf_marca = new System.Windows.Forms.TextBox();
            this.TB_inf_nchassi = new System.Windows.Forms.TextBox();
            this.lb_carroModelo = new System.Windows.Forms.Label();
            this.lb_carroCombustivel = new System.Windows.Forms.Label();
            this.lb_carroChassi = new System.Windows.Forms.Label();
            this.lb_carroMarca = new System.Windows.Forms.Label();
            this.lb_extras = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TB_inf_kms = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_inf_valor = new System.Windows.Forms.TextBox();
            this.TB_inf_dt_fim = new System.Windows.Forms.TextBox();
            this.TB_inf_dt_inicio = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.lb_parcelasValorTotal = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.BT_exportar = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.CARRO.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox6.Controls.Add(this.LIST_aluguer);
            this.groupBox6.Controls.Add(this.groupBox2);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox6.Location = new System.Drawing.Point(640, 43);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(263, 429);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "ALUGUER";
            // 
            // LIST_aluguer
            // 
            this.LIST_aluguer.FormattingEnabled = true;
            this.LIST_aluguer.Location = new System.Drawing.Point(21, 19);
            this.LIST_aluguer.Name = "LIST_aluguer";
            this.LIST_aluguer.ScrollAlwaysVisible = true;
            this.LIST_aluguer.Size = new System.Drawing.Size(221, 199);
            this.LIST_aluguer.TabIndex = 2;
            this.LIST_aluguer.SelectedIndexChanged += new System.EventHandler(this.List_aluguer_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.BT_removerAluguer);
            this.groupBox2.Controls.Add(this.tb_kms);
            this.groupBox2.Controls.Add(this.BT_inserirAluguer);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.dateTimePicker_data_fim);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dateTimePicker_data_inicio);
            this.groupBox2.Controls.Add(this.tb_valor);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(21, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 186);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "INSERIR";
            // 
            // BT_removerAluguer
            // 
            this.BT_removerAluguer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_removerAluguer.BackgroundImage")));
            this.BT_removerAluguer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BT_removerAluguer.Location = new System.Drawing.Point(119, 134);
            this.BT_removerAluguer.Name = "BT_removerAluguer";
            this.BT_removerAluguer.Size = new System.Drawing.Size(40, 36);
            this.BT_removerAluguer.TabIndex = 11;
            this.BT_removerAluguer.UseVisualStyleBackColor = true;
            this.BT_removerAluguer.Click += new System.EventHandler(this.BT_removerAluguer_Click);
            // 
            // tb_kms
            // 
            this.tb_kms.Location = new System.Drawing.Point(89, 103);
            this.tb_kms.Name = "tb_kms";
            this.tb_kms.Size = new System.Drawing.Size(100, 20);
            this.tb_kms.TabIndex = 9;
            this.tb_kms.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_kms_KeyPress);
            // 
            // BT_inserirAluguer
            // 
            this.BT_inserirAluguer.BackColor = System.Drawing.Color.Transparent;
            this.BT_inserirAluguer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_inserirAluguer.BackgroundImage")));
            this.BT_inserirAluguer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BT_inserirAluguer.Location = new System.Drawing.Point(73, 134);
            this.BT_inserirAluguer.Name = "BT_inserirAluguer";
            this.BT_inserirAluguer.Size = new System.Drawing.Size(40, 36);
            this.BT_inserirAluguer.TabIndex = 11;
            this.BT_inserirAluguer.UseVisualStyleBackColor = false;
            this.BT_inserirAluguer.Click += new System.EventHandler(this.BT_inserirAluguer_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(56, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Kms :";
            // 
            // dateTimePicker_data_fim
            // 
            this.dateTimePicker_data_fim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_data_fim.Location = new System.Drawing.Point(89, 49);
            this.dateTimePicker_data_fim.Name = "dateTimePicker_data_fim";
            this.dateTimePicker_data_fim.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker_data_fim.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Data Fim :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Data Inicio :";
            // 
            // dateTimePicker_data_inicio
            // 
            this.dateTimePicker_data_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_data_inicio.Location = new System.Drawing.Point(89, 23);
            this.dateTimePicker_data_inicio.Name = "dateTimePicker_data_inicio";
            this.dateTimePicker_data_inicio.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker_data_inicio.TabIndex = 6;
            // 
            // tb_valor
            // 
            this.tb_valor.Location = new System.Drawing.Point(89, 75);
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.Size = new System.Drawing.Size(100, 20);
            this.tb_valor.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Valor :";
            // 
            // CARRO
            // 
            this.CARRO.BackColor = System.Drawing.SystemColors.Control;
            this.CARRO.Controls.Add(this.LIST_carro);
            this.CARRO.Controls.Add(this.groupBox3);
            this.CARRO.ForeColor = System.Drawing.Color.Black;
            this.CARRO.Location = new System.Drawing.Point(287, 43);
            this.CARRO.Name = "CARRO";
            this.CARRO.Size = new System.Drawing.Size(331, 495);
            this.CARRO.TabIndex = 7;
            this.CARRO.TabStop = false;
            this.CARRO.Text = "CARRO";
            // 
            // LIST_carro
            // 
            this.LIST_carro.FormattingEnabled = true;
            this.LIST_carro.Location = new System.Drawing.Point(24, 19);
            this.LIST_carro.Name = "LIST_carro";
            this.LIST_carro.ScrollAlwaysVisible = true;
            this.LIST_carro.Size = new System.Drawing.Size(280, 199);
            this.LIST_carro.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Controls.Add(this.tb_matricula);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tb_combustivel);
            this.groupBox3.Controls.Add(this.BT_removerCarro);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.BT_inserirCarro);
            this.groupBox3.Controls.Add(this.tb_modelo);
            this.groupBox3.Controls.Add(this.tb_marca);
            this.groupBox3.Controls.Add(this.tb_chassi);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(24, 262);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 218);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "INSERIR";
            // 
            // tb_matricula
            // 
            this.tb_matricula.Location = new System.Drawing.Point(144, 78);
            this.tb_matricula.Name = "tb_matricula";
            this.tb_matricula.Size = new System.Drawing.Size(115, 20);
            this.tb_matricula.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Matricula :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Combustivel :";
            // 
            // tb_combustivel
            // 
            this.tb_combustivel.Location = new System.Drawing.Point(74, 127);
            this.tb_combustivel.Name = "tb_combustivel";
            this.tb_combustivel.Size = new System.Drawing.Size(115, 20);
            this.tb_combustivel.TabIndex = 6;
            // 
            // BT_removerCarro
            // 
            this.BT_removerCarro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_removerCarro.BackgroundImage")));
            this.BT_removerCarro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BT_removerCarro.Location = new System.Drawing.Point(149, 169);
            this.BT_removerCarro.Name = "BT_removerCarro";
            this.BT_removerCarro.Size = new System.Drawing.Size(40, 36);
            this.BT_removerCarro.TabIndex = 9;
            this.BT_removerCarro.UseVisualStyleBackColor = true;
            this.BT_removerCarro.Click += new System.EventHandler(this.BT_removerCarro_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Modelo :";
            // 
            // BT_inserirCarro
            // 
            this.BT_inserirCarro.BackColor = System.Drawing.Color.Transparent;
            this.BT_inserirCarro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_inserirCarro.BackgroundImage")));
            this.BT_inserirCarro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BT_inserirCarro.Location = new System.Drawing.Point(98, 169);
            this.BT_inserirCarro.Name = "BT_inserirCarro";
            this.BT_inserirCarro.Size = new System.Drawing.Size(40, 36);
            this.BT_inserirCarro.TabIndex = 8;
            this.BT_inserirCarro.UseVisualStyleBackColor = false;
            this.BT_inserirCarro.Click += new System.EventHandler(this.BT_inserirCarro_Click);
            // 
            // tb_modelo
            // 
            this.tb_modelo.Location = new System.Drawing.Point(144, 34);
            this.tb_modelo.Name = "tb_modelo";
            this.tb_modelo.Size = new System.Drawing.Size(115, 20);
            this.tb_modelo.TabIndex = 4;
            // 
            // tb_marca
            // 
            this.tb_marca.Location = new System.Drawing.Point(14, 78);
            this.tb_marca.Name = "tb_marca";
            this.tb_marca.Size = new System.Drawing.Size(115, 20);
            this.tb_marca.TabIndex = 3;
            // 
            // tb_chassi
            // 
            this.tb_chassi.Location = new System.Drawing.Point(14, 34);
            this.tb_chassi.Name = "tb_chassi";
            this.tb_chassi.Size = new System.Drawing.Size(115, 20);
            this.tb_chassi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nº Chassi :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.LIST_clientes);
            this.groupBox1.Location = new System.Drawing.Point(22, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 344);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SELECIONE UM CLIENTE";
            // 
            // LIST_clientes
            // 
            this.LIST_clientes.FormattingEnabled = true;
            this.LIST_clientes.Location = new System.Drawing.Point(14, 18);
            this.LIST_clientes.Name = "LIST_clientes";
            this.LIST_clientes.ScrollAlwaysVisible = true;
            this.LIST_clientes.Size = new System.Drawing.Size(212, 303);
            this.LIST_clientes.TabIndex = 1;
            this.LIST_clientes.SelectedIndexChanged += new System.EventHandler(this.List_clientes_SelectedIndexChanged_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.groupBox11);
            this.panel2.Controls.Add(this.groupBox10);
            this.panel2.Controls.Add(this.groupBox5);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label25);
            this.panel2.Controls.Add(this.BT_exportar);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(920, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 517);
            this.panel2.TabIndex = 22;
            // 
            // groupBox11
            // 
            this.groupBox11.BackColor = System.Drawing.Color.Gainsboro;
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
            this.groupBox11.Text = "CLIENTE";
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
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox10.Controls.Add(this.TB_inf_matricula);
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
            this.groupBox10.Location = new System.Drawing.Point(18, 169);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(271, 132);
            this.groupBox10.TabIndex = 28;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "CARRO";
            // 
            // TB_inf_matricula
            // 
            this.TB_inf_matricula.Enabled = false;
            this.TB_inf_matricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_inf_matricula.Location = new System.Drawing.Point(69, 96);
            this.TB_inf_matricula.Name = "TB_inf_matricula";
            this.TB_inf_matricula.Size = new System.Drawing.Size(87, 20);
            this.TB_inf_matricula.TabIndex = 43;
            this.TB_inf_matricula.Text = "Nenhum";
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
            // lb_carroModelo
            // 
            this.lb_carroModelo.AutoSize = true;
            this.lb_carroModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_carroModelo.Location = new System.Drawing.Point(137, 46);
            this.lb_carroModelo.Name = "lb_carroModelo";
            this.lb_carroModelo.Size = new System.Drawing.Size(48, 13);
            this.lb_carroModelo.TabIndex = 10;
            this.lb_carroModelo.Text = "Modelo :";
            // 
            // lb_carroCombustivel
            // 
            this.lb_carroCombustivel.AutoSize = true;
            this.lb_carroCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_carroCombustivel.Location = new System.Drawing.Point(12, 71);
            this.lb_carroCombustivel.Name = "lb_carroCombustivel";
            this.lb_carroCombustivel.Size = new System.Drawing.Size(70, 13);
            this.lb_carroCombustivel.TabIndex = 11;
            this.lb_carroCombustivel.Text = "Combustivel :";
            // 
            // lb_carroChassi
            // 
            this.lb_carroChassi.AutoSize = true;
            this.lb_carroChassi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_carroChassi.Location = new System.Drawing.Point(10, 21);
            this.lb_carroChassi.Name = "lb_carroChassi";
            this.lb_carroChassi.Size = new System.Drawing.Size(59, 13);
            this.lb_carroChassi.TabIndex = 9;
            this.lb_carroChassi.Text = "Nº Chassi :";
            // 
            // lb_carroMarca
            // 
            this.lb_carroMarca.AutoSize = true;
            this.lb_carroMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_carroMarca.Location = new System.Drawing.Point(12, 47);
            this.lb_carroMarca.Name = "lb_carroMarca";
            this.lb_carroMarca.Size = new System.Drawing.Size(43, 13);
            this.lb_carroMarca.TabIndex = 8;
            this.lb_carroMarca.Text = "Marca :";
            // 
            // lb_extras
            // 
            this.lb_extras.AutoSize = true;
            this.lb_extras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_extras.Location = new System.Drawing.Point(14, 98);
            this.lb_extras.Name = "lb_extras";
            this.lb_extras.Size = new System.Drawing.Size(56, 13);
            this.lb_extras.TabIndex = 8;
            this.lb_extras.Text = "Matricula :";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.LightGray;
            this.groupBox5.Controls.Add(this.TB_inf_kms);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.TB_inf_valor);
            this.groupBox5.Controls.Add(this.TB_inf_dt_fim);
            this.groupBox5.Controls.Add(this.TB_inf_dt_inicio);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.lb_parcelasValorTotal);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(18, 307);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(270, 135);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "ALUGUER";
            // 
            // TB_inf_kms
            // 
            this.TB_inf_kms.Enabled = false;
            this.TB_inf_kms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_inf_kms.Location = new System.Drawing.Point(82, 71);
            this.TB_inf_kms.Name = "TB_inf_kms";
            this.TB_inf_kms.Size = new System.Drawing.Size(110, 20);
            this.TB_inf_kms.TabIndex = 48;
            this.TB_inf_kms.Text = "Nenhum";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "kms :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_inf_valor
            // 
            this.TB_inf_valor.Enabled = false;
            this.TB_inf_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_inf_valor.Location = new System.Drawing.Point(155, 102);
            this.TB_inf_valor.Name = "TB_inf_valor";
            this.TB_inf_valor.Size = new System.Drawing.Size(86, 20);
            this.TB_inf_valor.TabIndex = 46;
            this.TB_inf_valor.Text = "Nenhum";
            // 
            // TB_inf_dt_fim
            // 
            this.TB_inf_dt_fim.Enabled = false;
            this.TB_inf_dt_fim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_inf_dt_fim.Location = new System.Drawing.Point(82, 46);
            this.TB_inf_dt_fim.Name = "TB_inf_dt_fim";
            this.TB_inf_dt_fim.Size = new System.Drawing.Size(110, 20);
            this.TB_inf_dt_fim.TabIndex = 45;
            this.TB_inf_dt_fim.Text = "Nenhum";
            // 
            // TB_inf_dt_inicio
            // 
            this.TB_inf_dt_inicio.Enabled = false;
            this.TB_inf_dt_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_inf_dt_inicio.Location = new System.Drawing.Point(82, 21);
            this.TB_inf_dt_inicio.Name = "TB_inf_dt_inicio";
            this.TB_inf_dt_inicio.Size = new System.Drawing.Size(110, 20);
            this.TB_inf_dt_inicio.TabIndex = 44;
            this.TB_inf_dt_inicio.Text = "Nenhum";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(14, 24);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(64, 13);
            this.label24.TabIndex = 15;
            this.label24.Text = "Data Inicio :";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_parcelasValorTotal
            // 
            this.lb_parcelasValorTotal.AutoSize = true;
            this.lb_parcelasValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_parcelasValorTotal.Location = new System.Drawing.Point(241, 105);
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
            this.label23.Location = new System.Drawing.Point(23, 49);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(55, 13);
            this.label23.TabIndex = 14;
            this.label23.Text = "Data Fim :";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(106, 105);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(43, 13);
            this.label22.TabIndex = 12;
            this.label22.Text = "VALOR";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(22, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(259, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "***************************************************************";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(112, 5);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(101, 27);
            this.label20.TabIndex = 18;
            this.label20.Text = "ALUGUER";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(22, 454);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(259, 13);
            this.label25.TabIndex = 16;
            this.label25.Text = "***************************************************************";
            // 
            // BT_exportar
            // 
            this.BT_exportar.BackColor = System.Drawing.Color.Transparent;
            this.BT_exportar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_exportar.BackgroundImage")));
            this.BT_exportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BT_exportar.ForeColor = System.Drawing.Color.Transparent;
            this.BT_exportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_exportar.Location = new System.Drawing.Point(126, 465);
            this.BT_exportar.Name = "BT_exportar";
            this.BT_exportar.Size = new System.Drawing.Size(47, 44);
            this.BT_exportar.TabIndex = 9;
            this.BT_exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BT_exportar.UseVisualStyleBackColor = false;
            // 
            // Form_Gestão_Alugueres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1245, 621);
            this.Controls.Add(this.CARRO);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "Form_Gestão_Alugueres";
            this.Text = "Gestão Aluguer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Gestão_Alugueres_FormClosing);
            this.Load += new System.EventHandler(this.Form_Gestão_Alugueres_Load);
            this.groupBox6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.CARRO.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox CARRO;
        private System.Windows.Forms.ListBox LIST_aluguer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker_data_inicio;
        private System.Windows.Forms.TextBox tb_valor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BT_removerCarro;
        private System.Windows.Forms.Button BT_inserirCarro;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_combustivel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_modelo;
        private System.Windows.Forms.TextBox tb_marca;
        private System.Windows.Forms.TextBox tb_chassi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox LIST_clientes;
        private System.Windows.Forms.TextBox tb_matricula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_kms;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker_data_fim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip toolTip1;
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
        private System.Windows.Forms.TextBox TB_inf_matricula;
        private System.Windows.Forms.TextBox TB_inf_modelo;
        private System.Windows.Forms.TextBox TB_inf_combustivel;
        private System.Windows.Forms.TextBox TB_inf_marca;
        private System.Windows.Forms.TextBox TB_inf_nchassi;
        private System.Windows.Forms.Label lb_carroModelo;
        private System.Windows.Forms.Label lb_carroCombustivel;
        private System.Windows.Forms.Label lb_carroChassi;
        private System.Windows.Forms.Label lb_carroMarca;
        private System.Windows.Forms.Label lb_extras;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox TB_inf_valor;
        private System.Windows.Forms.TextBox TB_inf_dt_fim;
        private System.Windows.Forms.TextBox TB_inf_dt_inicio;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lb_parcelasValorTotal;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button BT_exportar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button BT_removerAluguer;
        private System.Windows.Forms.Button BT_inserirAluguer;
        private System.Windows.Forms.ListBox LIST_carro;
        private System.Windows.Forms.TextBox TB_inf_kms;
        private System.Windows.Forms.Label label6;
    }
}