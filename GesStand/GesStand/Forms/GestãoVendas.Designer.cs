namespace GesStand
{
    partial class Form_Gestão_Vendas
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
            this.List_clientes = new System.Windows.Forms.ListBox();
            this.CARRO = new System.Windows.Forms.GroupBox();
            this.List_venda = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_estado = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker_data = new System.Windows.Forms.DateTimePicker();
            this.tb_valor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bt_remCarro = new System.Windows.Forms.Button();
            this.bt_insCarro = new System.Windows.Forms.Button();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.bt_exportar = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lb_cl_nome = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_cl_nif = new System.Windows.Forms.Label();
            this.lb_contacto = new System.Windows.Forms.Label();
            this.lb_valor = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lb_modelo = new System.Windows.Forms.Label();
            this.lb_data = new System.Windows.Forms.Label();
            this.lb_combustivel = new System.Windows.Forms.Label();
            this.lb_estado = new System.Windows.Forms.Label();
            this.lb_extras = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lb_nChassi = new System.Windows.Forms.Label();
            this.lb_marca = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.CARRO.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.List_clientes);
            this.groupBox1.Location = new System.Drawing.Point(29, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 347);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SELECIONE UM CLIENTE";
            // 
            // List_clientes
            // 
            this.List_clientes.FormattingEnabled = true;
            this.List_clientes.Location = new System.Drawing.Point(15, 19);
            this.List_clientes.Name = "List_clientes";
            this.List_clientes.Size = new System.Drawing.Size(192, 316);
            this.List_clientes.TabIndex = 1;
            this.List_clientes.SelectedIndexChanged += new System.EventHandler(this.List_clientes_SelectedIndexChanged);
            // 
            // CARRO
            // 
            this.CARRO.BackColor = System.Drawing.Color.LightGray;
            this.CARRO.Controls.Add(this.List_venda);
            this.CARRO.Controls.Add(this.groupBox2);
            this.CARRO.Controls.Add(this.bt_remCarro);
            this.CARRO.Controls.Add(this.bt_insCarro);
            this.CARRO.Controls.Add(this.groupBox3);
            this.CARRO.Location = new System.Drawing.Point(10, 15);
            this.CARRO.Name = "CARRO";
            this.CARRO.Size = new System.Drawing.Size(518, 550);
            this.CARRO.TabIndex = 7;
            this.CARRO.TabStop = false;
            this.CARRO.Text = "CARRO";
            // 
            // List_venda
            // 
            this.List_venda.FormattingEnabled = true;
            this.List_venda.Location = new System.Drawing.Point(93, 17);
            this.List_venda.Name = "List_venda";
            this.List_venda.Size = new System.Drawing.Size(320, 199);
            this.List_venda.TabIndex = 2;
            this.List_venda.SelectedIndexChanged += new System.EventHandler(this.List_venda_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.tb_valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_valor_KeyPress);
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
            // bt_remCarro
            // 
            this.bt_remCarro.BackColor = System.Drawing.Color.Transparent;
            this.bt_remCarro.BackgroundImage = global::GesStand.Properties.Resources.bt_remover_client;
            this.bt_remCarro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_remCarro.Location = new System.Drawing.Point(283, 478);
            this.bt_remCarro.Name = "bt_remCarro";
            this.bt_remCarro.Size = new System.Drawing.Size(54, 52);
            this.bt_remCarro.TabIndex = 9;
            this.bt_remCarro.UseVisualStyleBackColor = false;
            // 
            // bt_insCarro
            // 
            this.bt_insCarro.BackColor = System.Drawing.Color.Transparent;
            this.bt_insCarro.BackgroundImage = global::GesStand.Properties.Resources.bt_gravar_client;
            this.bt_insCarro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_insCarro.Location = new System.Drawing.Point(166, 478);
            this.bt_insCarro.Name = "bt_insCarro";
            this.bt_insCarro.Size = new System.Drawing.Size(54, 52);
            this.bt_insCarro.TabIndex = 8;
            this.bt_insCarro.UseVisualStyleBackColor = false;
            this.bt_insCarro.Click += new System.EventHandler(this.bt_insCarro_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.groupBox6.Size = new System.Drawing.Size(538, 581);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "VENDA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::GesStand.Properties.Resources.logo_gesStand_fatura;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.bt_exportar);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.lb_cl_nome);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lb_cl_nif);
            this.panel1.Controls.Add(this.lb_contacto);
            this.panel1.Controls.Add(this.lb_valor);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.lb_modelo);
            this.panel1.Controls.Add(this.lb_data);
            this.panel1.Controls.Add(this.lb_combustivel);
            this.panel1.Controls.Add(this.lb_estado);
            this.panel1.Controls.Add(this.lb_extras);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.lb_nChassi);
            this.panel1.Controls.Add(this.lb_marca);
            this.panel1.Location = new System.Drawing.Point(837, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 503);
            this.panel1.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 420);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(259, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "***************************************************************";
            // 
            // bt_exportar
            // 
            this.bt_exportar.BackColor = System.Drawing.Color.Transparent;
            this.bt_exportar.BackgroundImage = global::GesStand.Properties.Resources.export1;
            this.bt_exportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_exportar.ForeColor = System.Drawing.Color.Transparent;
            this.bt_exportar.Location = new System.Drawing.Point(126, 436);
            this.bt_exportar.Name = "bt_exportar";
            this.bt_exportar.Size = new System.Drawing.Size(47, 48);
            this.bt_exportar.TabIndex = 22;
            this.bt_exportar.UseVisualStyleBackColor = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(12, 62);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(259, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "***************************************************************";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(100, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 27);
            this.label15.TabIndex = 20;
            this.label15.Text = "VENDA";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.White;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(16, 158);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 13);
            this.label21.TabIndex = 15;
            this.label21.Text = "Contacto : ";
            // 
            // lb_cl_nome
            // 
            this.lb_cl_nome.AutoSize = true;
            this.lb_cl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cl_nome.Location = new System.Drawing.Point(11, 87);
            this.lb_cl_nome.Name = "lb_cl_nome";
            this.lb_cl_nome.Size = new System.Drawing.Size(240, 24);
            this.lb_cl_nome.TabIndex = 0;
            this.lb_cl_nome.Text = "Sem cliente selecionado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nif :";
            // 
            // lb_cl_nif
            // 
            this.lb_cl_nif.AutoSize = true;
            this.lb_cl_nif.BackColor = System.Drawing.Color.White;
            this.lb_cl_nif.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cl_nif.Location = new System.Drawing.Point(39, 127);
            this.lb_cl_nif.Name = "lb_cl_nif";
            this.lb_cl_nif.Size = new System.Drawing.Size(63, 13);
            this.lb_cl_nif.TabIndex = 1;
            this.lb_cl_nif.Text = "########";
            // 
            // lb_contacto
            // 
            this.lb_contacto.AutoSize = true;
            this.lb_contacto.BackColor = System.Drawing.Color.White;
            this.lb_contacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_contacto.Location = new System.Drawing.Point(72, 158);
            this.lb_contacto.Name = "lb_contacto";
            this.lb_contacto.Size = new System.Drawing.Size(63, 13);
            this.lb_contacto.TabIndex = 2;
            this.lb_contacto.Text = "########";
            // 
            // lb_valor
            // 
            this.lb_valor.AutoSize = true;
            this.lb_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_valor.Location = new System.Drawing.Point(231, 385);
            this.lb_valor.Name = "lb_valor";
            this.lb_valor.Size = new System.Drawing.Size(37, 13);
            this.lb_valor.TabIndex = 13;
            this.lb_valor.Text = "_,__ €";
            this.lb_valor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(259, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "***************************************************************";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(225, 359);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 13);
            this.label19.TabIndex = 12;
            this.label19.Text = "VALOR";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_modelo
            // 
            this.lb_modelo.AutoSize = true;
            this.lb_modelo.BackColor = System.Drawing.Color.White;
            this.lb_modelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_modelo.Location = new System.Drawing.Point(16, 255);
            this.lb_modelo.Name = "lb_modelo";
            this.lb_modelo.Size = new System.Drawing.Size(110, 13);
            this.lb_modelo.TabIndex = 6;
            this.lb_modelo.Text = "Modelo :  ########";
            // 
            // lb_data
            // 
            this.lb_data.AutoSize = true;
            this.lb_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_data.Location = new System.Drawing.Point(21, 385);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(98, 13);
            this.lb_data.TabIndex = 11;
            this.lb_data.Text = "Data :  ########";
            // 
            // lb_combustivel
            // 
            this.lb_combustivel.AutoSize = true;
            this.lb_combustivel.BackColor = System.Drawing.Color.White;
            this.lb_combustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_combustivel.Location = new System.Drawing.Point(150, 255);
            this.lb_combustivel.Name = "lb_combustivel";
            this.lb_combustivel.Size = new System.Drawing.Size(132, 13);
            this.lb_combustivel.TabIndex = 7;
            this.lb_combustivel.Text = "Combustivel :  ########";
            // 
            // lb_estado
            // 
            this.lb_estado.AutoSize = true;
            this.lb_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_estado.Location = new System.Drawing.Point(21, 359);
            this.lb_estado.Name = "lb_estado";
            this.lb_estado.Size = new System.Drawing.Size(108, 13);
            this.lb_estado.TabIndex = 10;
            this.lb_estado.Text = "Estado :  ########";
            // 
            // lb_extras
            // 
            this.lb_extras.AutoSize = true;
            this.lb_extras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_extras.Location = new System.Drawing.Point(16, 296);
            this.lb_extras.Name = "lb_extras";
            this.lb_extras.Size = new System.Drawing.Size(118, 13);
            this.lb_extras.TabIndex = 8;
            this.lb_extras.Text = "EXTRAS :  ########";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(16, 333);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(259, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "***************************************************************";
            // 
            // lb_nChassi
            // 
            this.lb_nChassi.AutoSize = true;
            this.lb_nChassi.BackColor = System.Drawing.Color.White;
            this.lb_nChassi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nChassi.Location = new System.Drawing.Point(16, 214);
            this.lb_nChassi.Name = "lb_nChassi";
            this.lb_nChassi.Size = new System.Drawing.Size(121, 13);
            this.lb_nChassi.TabIndex = 5;
            this.lb_nChassi.Text = "Nº Chassi :  ########";
            // 
            // lb_marca
            // 
            this.lb_marca.AutoSize = true;
            this.lb_marca.BackColor = System.Drawing.Color.White;
            this.lb_marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_marca.Location = new System.Drawing.Point(163, 214);
            this.lb_marca.Name = "lb_marca";
            this.lb_marca.Size = new System.Drawing.Size(105, 13);
            this.lb_marca.TabIndex = 2;
            this.lb_marca.Text = "Marca :  ########";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GesStand.Properties.Resources.venda;
            this.pictureBox1.Location = new System.Drawing.Point(73, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Gestão_Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::GesStand.Properties.Resources.logo_gesStand_fatura;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1158, 638);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "Form_Gestão_Vendas";
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox List_clientes;
        private System.Windows.Forms.GroupBox CARRO;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_remCarro;
        private System.Windows.Forms.Button bt_insCarro;
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
        private System.Windows.Forms.Label lb_valor;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lb_data;
        private System.Windows.Forms.Label lb_estado;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lb_marca;
        private System.Windows.Forms.Label lb_nChassi;
        private System.Windows.Forms.Label lb_extras;
        private System.Windows.Forms.Label lb_combustivel;
        private System.Windows.Forms.Label lb_modelo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lb_cl_nome;
        private System.Windows.Forms.Label lb_contacto;
        private System.Windows.Forms.Label lb_cl_nif;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox List_venda;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button bt_exportar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}