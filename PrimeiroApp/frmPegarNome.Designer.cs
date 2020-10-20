namespace PrimeiroApp
{
    partial class frmPegarNome
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
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblDigiteseuNome = new System.Windows.Forms.Label();
            this.lblMostrarNome = new System.Windows.Forms.Label();
            this.txtDigiteseuNome = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.Black;
            this.btnMostrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.Color.White;
            this.btnMostrar.Location = new System.Drawing.Point(48, 153);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(117, 34);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "&Imprimir";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Black;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(322, 153);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(119, 34);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblDigiteseuNome
            // 
            this.lblDigiteseuNome.AutoSize = true;
            this.lblDigiteseuNome.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigiteseuNome.Location = new System.Drawing.Point(65, 65);
            this.lblDigiteseuNome.Name = "lblDigiteseuNome";
            this.lblDigiteseuNome.Size = new System.Drawing.Size(144, 22);
            this.lblDigiteseuNome.TabIndex = 3;
            this.lblDigiteseuNome.Text = "Digite seu Nome";
            // 
            // lblMostrarNome
            // 
            this.lblMostrarNome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMostrarNome.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarNome.Location = new System.Drawing.Point(215, 107);
            this.lblMostrarNome.Name = "lblMostrarNome";
            this.lblMostrarNome.Size = new System.Drawing.Size(226, 23);
            this.lblMostrarNome.TabIndex = 4;
            this.lblMostrarNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDigiteseuNome
            // 
            this.txtDigiteseuNome.Location = new System.Drawing.Point(215, 65);
            this.txtDigiteseuNome.Name = "txtDigiteseuNome";
            this.txtDigiteseuNome.Size = new System.Drawing.Size(226, 20);
            this.txtDigiteseuNome.TabIndex = 0;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Black;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Transparent;
            this.btnLimpar.Location = new System.Drawing.Point(187, 153);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(118, 34);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmPegarNome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(511, 223);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtDigiteseuNome);
            this.Controls.Add(this.lblMostrarNome);
            this.Controls.Add(this.lblDigiteseuNome);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnMostrar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmPegarNome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PegarNome";
            this.Load += new System.EventHandler(this.frmPegarNome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblDigiteseuNome;
        private System.Windows.Forms.Label lblMostrarNome;
        private System.Windows.Forms.TextBox txtDigiteseuNome;
        private System.Windows.Forms.Button btnLimpar;
    }
}