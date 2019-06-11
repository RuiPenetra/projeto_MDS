namespace GesStand.Forms
{
    partial class form_MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_MenuPrincipal));
            this.status_datetime = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_contador = new System.Windows.Forms.ToolStripStatusLabel();
            this.lb_clientes = new System.Windows.Forms.ToolStripStatusLabel();
            this.lb_totalVendas = new System.Windows.Forms.ToolStripStatusLabel();
            this.lb_totalAluguer = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lb_data_atual = new System.Windows.Forms.ToolStripStatusLabel();
            this.lb_cronometro = new System.Windows.Forms.ToolStripStatusLabel();
            this.lb_nClientes = new System.Windows.Forms.ToolStripStatusLabel();
            this.lb_nVenda = new System.Windows.Forms.ToolStripStatusLabel();
            this.lb_nAluguer = new System.Windows.Forms.ToolStripStatusLabel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.bt_gestAluguer = new System.Windows.Forms.Button();
            this.bt_gestOficina = new System.Windows.Forms.Button();
            this.bt_gestVenda = new System.Windows.Forms.Button();
            this.bt_gestClientes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // status_datetime
            // 
            this.status_datetime.BackColor = System.Drawing.Color.Transparent;
            this.status_datetime.Name = "status_datetime";
            this.status_datetime.Size = new System.Drawing.Size(71, 17);
            this.status_datetime.Text = "00 / 00 / 00  ";
            // 
            // status_contador
            // 
            this.status_contador.BackColor = System.Drawing.Color.Transparent;
            this.status_contador.Name = "status_contador";
            this.status_contador.Size = new System.Drawing.Size(55, 17);
            this.status_contador.Text = " 00:00:00 ";
            // 
            // lb_clientes
            // 
            this.lb_clientes.BackColor = System.Drawing.Color.Transparent;
            this.lb_clientes.Name = "lb_clientes";
            this.lb_clientes.Size = new System.Drawing.Size(73, 17);
            this.lb_clientes.Text = "  Clientes: 0  ";
            // 
            // lb_totalVendas
            // 
            this.lb_totalVendas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_totalVendas.Name = "lb_totalVendas";
            this.lb_totalVendas.Size = new System.Drawing.Size(97, 17);
            this.lb_totalVendas.Text = "  Total Vendas: 0  ";
            // 
            // lb_totalAluguer
            // 
            this.lb_totalAluguer.BackColor = System.Drawing.Color.Transparent;
            this.lb_totalAluguer.Name = "lb_totalAluguer";
            this.lb_totalAluguer.Size = new System.Drawing.Size(102, 17);
            this.lb_totalAluguer.Text = "  Total Aluguer: 0  ";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lb_data_atual,
            this.lb_cronometro,
            this.lb_nClientes,
            this.lb_nVenda,
            this.lb_nAluguer});
            this.statusStrip1.Location = new System.Drawing.Point(0, 523);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(903, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lb_data_atual
            // 
            this.lb_data_atual.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_data_atual.Name = "lb_data_atual";
            this.lb_data_atual.Size = new System.Drawing.Size(49, 17);
            this.lb_data_atual.Text = "00:00:00";
            // 
            // lb_cronometro
            // 
            this.lb_cronometro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_cronometro.Name = "lb_cronometro";
            this.lb_cronometro.Size = new System.Drawing.Size(49, 17);
            this.lb_cronometro.Text = "00:00:00";
            // 
            // lb_nClientes
            // 
            this.lb_nClientes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_nClientes.Name = "lb_nClientes";
            this.lb_nClientes.Size = new System.Drawing.Size(52, 17);
            this.lb_nClientes.Text = "Clientes:";
            // 
            // lb_nVenda
            // 
            this.lb_nVenda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_nVenda.Name = "lb_nVenda";
            this.lb_nVenda.Size = new System.Drawing.Size(76, 17);
            this.lb_nVenda.Text = "Total Vendas:";
            // 
            // lb_nAluguer
            // 
            this.lb_nAluguer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_nAluguer.Name = "lb_nAluguer";
            this.lb_nAluguer.Size = new System.Drawing.Size(81, 17);
            this.lb_nAluguer.Text = "Total Aluguer:";
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = global::GesStand.Properties.Resources.logo_gesStand;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Location = new System.Drawing.Point(255, 25);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(383, 237);
            this.logo.TabIndex = 33;
            this.logo.TabStop = false;
            // 
            // bt_gestAluguer
            // 
            this.bt_gestAluguer.BackColor = System.Drawing.Color.Silver;
            this.bt_gestAluguer.BackgroundImage = global::GesStand.Properties.Resources.logo_aluguer;
            this.bt_gestAluguer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_gestAluguer.Location = new System.Drawing.Point(612, 19);
            this.bt_gestAluguer.Name = "bt_gestAluguer";
            this.bt_gestAluguer.Size = new System.Drawing.Size(173, 145);
            this.bt_gestAluguer.TabIndex = 15;
            this.bt_gestAluguer.UseVisualStyleBackColor = false;
            this.bt_gestAluguer.Click += new System.EventHandler(this.bt_gestAluguer_Click);
            // 
            // bt_gestOficina
            // 
            this.bt_gestOficina.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_gestOficina.BackColor = System.Drawing.Color.Silver;
            this.bt_gestOficina.BackgroundImage = global::GesStand.Properties.Resources.logo_oficina;
            this.bt_gestOficina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_gestOficina.Location = new System.Drawing.Point(220, 19);
            this.bt_gestOficina.Name = "bt_gestOficina";
            this.bt_gestOficina.Size = new System.Drawing.Size(178, 145);
            this.bt_gestOficina.TabIndex = 14;
            this.bt_gestOficina.UseVisualStyleBackColor = false;
            this.bt_gestOficina.Click += new System.EventHandler(this.bt_gestOficina_Click);
            // 
            // bt_gestVenda
            // 
            this.bt_gestVenda.BackColor = System.Drawing.Color.Silver;
            this.bt_gestVenda.BackgroundImage = global::GesStand.Properties.Resources.logo_venda;
            this.bt_gestVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_gestVenda.Location = new System.Drawing.Point(416, 19);
            this.bt_gestVenda.Name = "bt_gestVenda";
            this.bt_gestVenda.Size = new System.Drawing.Size(173, 145);
            this.bt_gestVenda.TabIndex = 17;
            this.bt_gestVenda.UseVisualStyleBackColor = false;
            this.bt_gestVenda.Click += new System.EventHandler(this.bt_gestVenda_Click);
            // 
            // bt_gestClientes
            // 
            this.bt_gestClientes.BackColor = System.Drawing.Color.Silver;
            this.bt_gestClientes.BackgroundImage = global::GesStand.Properties.Resources.logo_clientes;
            this.bt_gestClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_gestClientes.Location = new System.Drawing.Point(23, 19);
            this.bt_gestClientes.Name = "bt_gestClientes";
            this.bt_gestClientes.Size = new System.Drawing.Size(173, 145);
            this.bt_gestClientes.TabIndex = 16;
            this.bt_gestClientes.UseVisualStyleBackColor = false;
            this.bt_gestClientes.Click += new System.EventHandler(this.bt_gestClientes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GesStand.Properties.Resources.gear;
            this.pictureBox1.Location = new System.Drawing.Point(-83, -124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 265);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.Image = global::GesStand.Properties.Resources.gear;
            this.pictureBox12.Location = new System.Drawing.Point(127, -191);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(226, 265);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox12.TabIndex = 31;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.Image = global::GesStand.Properties.Resources.gear;
            this.pictureBox11.Location = new System.Drawing.Point(317, -237);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(226, 265);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox11.TabIndex = 30;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = global::GesStand.Properties.Resources.gear;
            this.pictureBox10.Location = new System.Drawing.Point(533, -192);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(226, 265);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox10.TabIndex = 29;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Image = global::GesStand.Properties.Resources.gear;
            this.pictureBox9.Location = new System.Drawing.Point(740, -124);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(226, 265);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox9.TabIndex = 28;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::GesStand.Properties.Resources.gear;
            this.pictureBox6.Location = new System.Drawing.Point(529, 465);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(226, 265);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 25;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::GesStand.Properties.Resources.gear;
            this.pictureBox5.Location = new System.Drawing.Point(317, 444);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(226, 265);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 24;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::GesStand.Properties.Resources.gear;
            this.pictureBox4.Location = new System.Drawing.Point(138, 472);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(226, 265);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::GesStand.Properties.Resources.gear;
            this.pictureBox2.Location = new System.Drawing.Point(-132, 147);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(226, 265);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::GesStand.Properties.Resources.gear;
            this.pictureBox3.Location = new System.Drawing.Point(-38, 407);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(226, 265);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::GesStand.Properties.Resources.gear;
            this.pictureBox8.Location = new System.Drawing.Point(817, 141);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(226, 265);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox8.TabIndex = 27;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::GesStand.Properties.Resources.gear;
            this.pictureBox7.Location = new System.Drawing.Point(753, 411);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(226, 265);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 26;
            this.pictureBox7.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.bt_gestAluguer);
            this.groupBox1.Controls.Add(this.bt_gestVenda);
            this.groupBox1.Controls.Add(this.bt_gestOficina);
            this.groupBox1.Controls.Add(this.bt_gestClientes);
            this.groupBox1.Location = new System.Drawing.Point(44, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(803, 181);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // form_MenuPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(903, 545);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_MenuPrincipal";
            this.Text = "GesStand";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_MenuPrincipal_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_gestOficina;
        private System.Windows.Forms.Button bt_gestAluguer;
        private System.Windows.Forms.Button bt_gestClientes;
        private System.Windows.Forms.Button bt_gestVenda;
        private System.Windows.Forms.ToolStripStatusLabel status_datetime;
        private System.Windows.Forms.ToolStripStatusLabel lb_clientes;
        private System.Windows.Forms.ToolStripStatusLabel lb_totalVendas;
        private System.Windows.Forms.ToolStripStatusLabel lb_totalAluguer;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripStatusLabel status_contador;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lb_data_atual;
        private System.Windows.Forms.ToolStripStatusLabel lb_cronometro;
        private System.Windows.Forms.ToolStripStatusLabel lb_nClientes;
        private System.Windows.Forms.ToolStripStatusLabel lb_nVenda;
        private System.Windows.Forms.ToolStripStatusLabel lb_nAluguer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}