namespace GesStand
{
    partial class Form_GestaoClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_GestaoClientes));
            System.Windows.Forms.Label contactoLabel;
            System.Windows.Forms.Label idClienteLabel;
            System.Windows.Forms.Label moradaLabel;
            System.Windows.Forms.Label nIFLabel;
            System.Windows.Forms.Label nomeLabel;
            this.clienteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bin_novo_registo = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bin_guardar = new System.Windows.Forms.ToolStripButton();
            this.bt_remover = new System.Windows.Forms.ToolStripButton();
            this.clienteDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_filtrar = new System.Windows.Forms.Button();
            this.tb_filtrar = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactoTextBox = new System.Windows.Forms.TextBox();
            this.idClienteTextBox = new System.Windows.Forms.TextBox();
            this.moradaTextBox = new System.Windows.Forms.TextBox();
            this.nIFTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.carroOficinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_carrosOficina = new System.Windows.Forms.TextBox();
            this.tb_carrosComprados = new System.Windows.Forms.TextBox();
            this.tb_carrosAluguer = new System.Windows.Forms.TextBox();
            contactoLabel = new System.Windows.Forms.Label();
            idClienteLabel = new System.Windows.Forms.Label();
            moradaLabel = new System.Windows.Forms.Label();
            nIFLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).BeginInit();
            this.clienteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroOficinaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // clienteBindingNavigator
            // 
            this.clienteBindingNavigator.AddNewItem = this.bin_novo_registo;
            this.clienteBindingNavigator.AutoSize = false;
            this.clienteBindingNavigator.BindingSource = this.clienteBindingSource;
            this.clienteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clienteBindingNavigator.DeleteItem = null;
            this.clienteBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.clienteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bin_novo_registo,
            this.bin_guardar,
            this.bt_remover});
            this.clienteBindingNavigator.Location = new System.Drawing.Point(15, 19);
            this.clienteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clienteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clienteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clienteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clienteBindingNavigator.Name = "clienteBindingNavigator";
            this.clienteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clienteBindingNavigator.Size = new System.Drawing.Size(545, 25);
            this.clienteBindingNavigator.TabIndex = 0;
            // 
            // bin_novo_registo
            // 
            this.bin_novo_registo.Image = global::GesStand.Properties.Resources.bt_add_client;
            this.bin_novo_registo.Name = "bin_novo_registo";
            this.bin_novo_registo.RightToLeftAutoMirrorImage = true;
            this.bin_novo_registo.Size = new System.Drawing.Size(59, 22);
            this.bin_novo_registo.Text = "Novo ";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bin_guardar
            // 
            this.bin_guardar.Image = global::GesStand.Properties.Resources.bt_gravar_client;
            this.bin_guardar.Name = "bin_guardar";
            this.bin_guardar.Size = new System.Drawing.Size(69, 22);
            this.bin_guardar.Text = "Guardar";
            this.bin_guardar.Click += new System.EventHandler(this.bin_guardar_Click);
            // 
            // bt_remover
            // 
            this.bt_remover.Image = global::GesStand.Properties.Resources.bt_remover_client;
            this.bt_remover.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_remover.Name = "bt_remover";
            this.bt_remover.Size = new System.Drawing.Size(74, 22);
            this.bt_remover.Text = "Remover";
            this.bt_remover.Click += new System.EventHandler(this.bt_remover_Click);
            // 
            // clienteDataGridView
            // 
            this.clienteDataGridView.AllowUserToAddRows = false;
            this.clienteDataGridView.AllowUserToDeleteRows = false;
            this.clienteDataGridView.AutoGenerateColumns = false;
            this.clienteDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.clienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.clienteDataGridView.DataSource = this.clienteBindingSource;
            this.clienteDataGridView.Location = new System.Drawing.Point(15, 59);
            this.clienteDataGridView.Name = "clienteDataGridView";
            this.clienteDataGridView.Size = new System.Drawing.Size(545, 306);
            this.clienteDataGridView.TabIndex = 1;
            this.clienteDataGridView.SelectionChanged += new System.EventHandler(this.clienteDataGridView_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.tb_carrosAluguer);
            this.groupBox1.Controls.Add(this.tb_carrosComprados);
            this.groupBox1.Controls.Add(this.tb_carrosOficina);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(contactoLabel);
            this.groupBox1.Controls.Add(this.contactoTextBox);
            this.groupBox1.Controls.Add(idClienteLabel);
            this.groupBox1.Controls.Add(this.idClienteTextBox);
            this.groupBox1.Controls.Add(moradaLabel);
            this.groupBox1.Controls.Add(this.moradaTextBox);
            this.groupBox1.Controls.Add(nIFLabel);
            this.groupBox1.Controls.Add(this.nIFTextBox);
            this.groupBox1.Controls.Add(nomeLabel);
            this.groupBox1.Controls.Add(this.nomeTextBox);
            this.groupBox1.Location = new System.Drawing.Point(659, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 336);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ficha Geral";
            // 
            // bt_filtrar
            // 
            this.bt_filtrar.Location = new System.Drawing.Point(483, 371);
            this.bt_filtrar.Name = "bt_filtrar";
            this.bt_filtrar.Size = new System.Drawing.Size(75, 23);
            this.bt_filtrar.TabIndex = 13;
            this.bt_filtrar.Text = "Filtrar";
            this.bt_filtrar.UseVisualStyleBackColor = true;
            this.bt_filtrar.Click += new System.EventHandler(this.bt_filtrar_Click);
            // 
            // tb_filtrar
            // 
            this.tb_filtrar.Location = new System.Drawing.Point(15, 374);
            this.tb_filtrar.Name = "tb_filtrar";
            this.tb_filtrar.Size = new System.Drawing.Size(462, 20);
            this.tb_filtrar.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.clienteBindingNavigator);
            this.groupBox2.Controls.Add(this.tb_filtrar);
            this.groupBox2.Controls.Add(this.bt_filtrar);
            this.groupBox2.Controls.Add(this.clienteDataGridView);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(41, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(575, 411);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista Clientes";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(GesStand.Cliente);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdCliente";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdCliente";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NIF";
            this.dataGridViewTextBoxColumn3.HeaderText = "NIF";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Morada";
            this.dataGridViewTextBoxColumn4.HeaderText = "Morada";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Contacto";
            this.dataGridViewTextBoxColumn5.HeaderText = "Contacto";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // contactoLabel
            // 
            contactoLabel.AutoSize = true;
            contactoLabel.Location = new System.Drawing.Point(75, 182);
            contactoLabel.Name = "contactoLabel";
            contactoLabel.Size = new System.Drawing.Size(53, 13);
            contactoLabel.TabIndex = 0;
            contactoLabel.Text = "Contacto:";
            // 
            // contactoTextBox
            // 
            this.contactoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Contacto", true));
            this.contactoTextBox.Enabled = false;
            this.contactoTextBox.Location = new System.Drawing.Point(135, 179);
            this.contactoTextBox.Name = "contactoTextBox";
            this.contactoTextBox.Size = new System.Drawing.Size(100, 20);
            this.contactoTextBox.TabIndex = 1;
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Location = new System.Drawing.Point(75, 33);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(54, 13);
            idClienteLabel.TabIndex = 2;
            idClienteLabel.Text = "Id Cliente:";
            // 
            // idClienteTextBox
            // 
            this.idClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "IdCliente", true));
            this.idClienteTextBox.Enabled = false;
            this.idClienteTextBox.Location = new System.Drawing.Point(135, 30);
            this.idClienteTextBox.Name = "idClienteTextBox";
            this.idClienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.idClienteTextBox.TabIndex = 3;
            // 
            // moradaLabel
            // 
            moradaLabel.AutoSize = true;
            moradaLabel.Location = new System.Drawing.Point(75, 145);
            moradaLabel.Name = "moradaLabel";
            moradaLabel.Size = new System.Drawing.Size(46, 13);
            moradaLabel.TabIndex = 4;
            moradaLabel.Text = "Morada:";
            // 
            // moradaTextBox
            // 
            this.moradaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Morada", true));
            this.moradaTextBox.Enabled = false;
            this.moradaTextBox.Location = new System.Drawing.Point(135, 142);
            this.moradaTextBox.Name = "moradaTextBox";
            this.moradaTextBox.Size = new System.Drawing.Size(100, 20);
            this.moradaTextBox.TabIndex = 5;
            // 
            // nIFLabel
            // 
            nIFLabel.AutoSize = true;
            nIFLabel.Location = new System.Drawing.Point(75, 109);
            nIFLabel.Name = "nIFLabel";
            nIFLabel.Size = new System.Drawing.Size(27, 13);
            nIFLabel.TabIndex = 6;
            nIFLabel.Text = "NIF:";
            // 
            // nIFTextBox
            // 
            this.nIFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "NIF", true));
            this.nIFTextBox.Enabled = false;
            this.nIFTextBox.Location = new System.Drawing.Point(135, 106);
            this.nIFTextBox.Name = "nIFTextBox";
            this.nIFTextBox.Size = new System.Drawing.Size(100, 20);
            this.nIFTextBox.TabIndex = 7;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(75, 72);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 8;
            nomeLabel.Text = "Nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Nome", true));
            this.nomeTextBox.Enabled = false;
            this.nomeTextBox.Location = new System.Drawing.Point(135, 69);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomeTextBox.TabIndex = 9;
            // 
            // carroOficinaBindingSource
            // 
            this.carroOficinaBindingSource.DataSource = typeof(GesStand.CarroOficina);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Carros na Oficina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Carros Comprados:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Carros Alugados:";
            // 
            // tb_carrosOficina
            // 
            this.tb_carrosOficina.Enabled = false;
            this.tb_carrosOficina.Location = new System.Drawing.Point(135, 220);
            this.tb_carrosOficina.Name = "tb_carrosOficina";
            this.tb_carrosOficina.Size = new System.Drawing.Size(100, 20);
            this.tb_carrosOficina.TabIndex = 13;
            // 
            // tb_carrosComprados
            // 
            this.tb_carrosComprados.Enabled = false;
            this.tb_carrosComprados.Location = new System.Drawing.Point(135, 251);
            this.tb_carrosComprados.Name = "tb_carrosComprados";
            this.tb_carrosComprados.Size = new System.Drawing.Size(100, 20);
            this.tb_carrosComprados.TabIndex = 14;
            // 
            // tb_carrosAluguer
            // 
            this.tb_carrosAluguer.Enabled = false;
            this.tb_carrosAluguer.Location = new System.Drawing.Point(135, 285);
            this.tb_carrosAluguer.Name = "tb_carrosAluguer";
            this.tb_carrosAluguer.Size = new System.Drawing.Size(100, 20);
            this.tb_carrosAluguer.TabIndex = 15;
            // 
            // Form_GestaoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::GesStand.Properties.Resources.logo_gesStand_fatura;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1037, 491);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "Form_GestaoClientes";
            this.Text = "Gestão Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_GestaoClientes_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).EndInit();
            this.clienteBindingNavigator.ResumeLayout(false);
            this.clienteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroOficinaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.BindingNavigator clienteBindingNavigator;
        private System.Windows.Forms.ToolStripButton bin_novo_registo;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bin_guardar;
        private System.Windows.Forms.DataGridView clienteDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_filtrar;
        private System.Windows.Forms.TextBox tb_filtrar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripButton bt_remover;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox tb_carrosAluguer;
        private System.Windows.Forms.TextBox tb_carrosComprados;
        private System.Windows.Forms.TextBox tb_carrosOficina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox contactoTextBox;
        private System.Windows.Forms.TextBox idClienteTextBox;
        private System.Windows.Forms.TextBox moradaTextBox;
        private System.Windows.Forms.TextBox nIFTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.BindingSource carroOficinaBindingSource;
    }
}