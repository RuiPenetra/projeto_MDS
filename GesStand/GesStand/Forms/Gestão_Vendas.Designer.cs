namespace GesStand
{
    partial class Gestão_Vendas
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tb_removerParcela = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.tb_p_valor = new System.Windows.Forms.TextBox();
            this.tb_addParcela = new System.Windows.Forms.Button();
            this.tb_p_descricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_Parcelas = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_cl_nif = new System.Windows.Forms.Label();
            this.lb_cl_nome = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LB_clientes);
            this.groupBox1.Location = new System.Drawing.Point(-56, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 539);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione um cliente";
            // 
            // LB_clientes
            // 
            this.LB_clientes.FormattingEnabled = true;
            this.LB_clientes.Location = new System.Drawing.Point(6, 15);
            this.LB_clientes.Name = "LB_clientes";
            this.LB_clientes.Size = new System.Drawing.Size(212, 472);
            this.LB_clientes.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox4);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.lb_cl_nif);
            this.groupBox5.Controls.Add(this.lb_cl_nome);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(195, 24);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(726, 585);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tb_removerParcela);
            this.groupBox4.Controls.Add(this.groupBox8);
            this.groupBox4.Controls.Add(this.LB_Parcelas);
            this.groupBox4.Location = new System.Drawing.Point(493, 95);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(205, 424);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parcelas";
            // 
            // tb_removerParcela
            // 
            this.tb_removerParcela.Location = new System.Drawing.Point(7, 16);
            this.tb_removerParcela.Name = "tb_removerParcela";
            this.tb_removerParcela.Size = new System.Drawing.Size(192, 31);
            this.tb_removerParcela.TabIndex = 7;
            this.tb_removerParcela.Text = "Remover";
            this.tb_removerParcela.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.tb_p_valor);
            this.groupBox8.Controls.Add(this.tb_addParcela);
            this.groupBox8.Controls.Add(this.tb_p_descricao);
            this.groupBox8.Controls.Add(this.label2);
            this.groupBox8.Controls.Add(this.label1);
            this.groupBox8.Location = new System.Drawing.Point(6, 312);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(193, 106);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Novo";
            // 
            // tb_p_valor
            // 
            this.tb_p_valor.Location = new System.Drawing.Point(84, 42);
            this.tb_p_valor.Name = "tb_p_valor";
            this.tb_p_valor.Size = new System.Drawing.Size(100, 22);
            this.tb_p_valor.TabIndex = 5;
            // 
            // tb_addParcela
            // 
            this.tb_addParcela.Location = new System.Drawing.Point(6, 68);
            this.tb_addParcela.Name = "tb_addParcela";
            this.tb_addParcela.Size = new System.Drawing.Size(178, 31);
            this.tb_addParcela.TabIndex = 1;
            this.tb_addParcela.Text = "Adicionar";
            this.tb_addParcela.UseVisualStyleBackColor = true;
            // 
            // tb_p_descricao
            // 
            this.tb_p_descricao.Location = new System.Drawing.Point(84, 13);
            this.tb_p_descricao.Name = "tb_p_descricao";
            this.tb_p_descricao.Size = new System.Drawing.Size(100, 22);
            this.tb_p_descricao.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descrição";
            // 
            // LB_Parcelas
            // 
            this.LB_Parcelas.FormattingEnabled = true;
            this.LB_Parcelas.ItemHeight = 16;
            this.LB_Parcelas.Location = new System.Drawing.Point(7, 54);
            this.LB_Parcelas.Name = "LB_Parcelas";
            this.LB_Parcelas.Size = new System.Drawing.Size(192, 244);
            this.LB_Parcelas.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(615, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Valor Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "-.";
            // 
            // lb_cl_nif
            // 
            this.lb_cl_nif.AutoSize = true;
            this.lb_cl_nif.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cl_nif.Location = new System.Drawing.Point(6, 44);
            this.lb_cl_nif.Name = "lb_cl_nif";
            this.lb_cl_nif.Size = new System.Drawing.Size(10, 13);
            this.lb_cl_nif.TabIndex = 1;
            this.lb_cl_nif.Text = "-";
            // 
            // lb_cl_nome
            // 
            this.lb_cl_nome.AutoSize = true;
            this.lb_cl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cl_nome.Location = new System.Drawing.Point(6, 16);
            this.lb_cl_nome.Name = "lb_cl_nome";
            this.lb_cl_nome.Size = new System.Drawing.Size(237, 24);
            this.lb_cl_nome.TabIndex = 0;
            this.lb_cl_nome.Text = "sem cliente selecionado";
            // 
            // Gestão_Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Name = "Gestão_Vendas";
            this.Text = "Gestão_Vendas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox LB_clientes;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button tb_removerParcela;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox tb_p_valor;
        private System.Windows.Forms.Button tb_addParcela;
        private System.Windows.Forms.TextBox tb_p_descricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LB_Parcelas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_cl_nif;
        private System.Windows.Forms.Label lb_cl_nome;
    }
}