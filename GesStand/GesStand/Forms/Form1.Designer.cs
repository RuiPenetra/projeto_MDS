namespace GesStand
{
    partial class Form1
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
            this.bt_gestClientes = new System.Windows.Forms.Button();
            this.bt_gestOficina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_gestClientes
            // 
            this.bt_gestClientes.Location = new System.Drawing.Point(83, 85);
            this.bt_gestClientes.Name = "bt_gestClientes";
            this.bt_gestClientes.Size = new System.Drawing.Size(113, 95);
            this.bt_gestClientes.TabIndex = 0;
            this.bt_gestClientes.Text = "Cliente";
            this.bt_gestClientes.UseVisualStyleBackColor = true;
            this.bt_gestClientes.Click += new System.EventHandler(this.bt_gestClientes_Click);
            // 
            // bt_gestOficina
            // 
            this.bt_gestOficina.Location = new System.Drawing.Point(251, 85);
            this.bt_gestOficina.Name = "bt_gestOficina";
            this.bt_gestOficina.Size = new System.Drawing.Size(113, 95);
            this.bt_gestOficina.TabIndex = 1;
            this.bt_gestOficina.Text = "Oficina";
            this.bt_gestOficina.UseVisualStyleBackColor = true;
            this.bt_gestOficina.Click += new System.EventHandler(this.bt_gestOficina_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_gestOficina);
            this.Controls.Add(this.bt_gestClientes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_gestClientes;
        private System.Windows.Forms.Button bt_gestOficina;
    }
}

