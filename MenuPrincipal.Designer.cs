namespace Padarosa
{
    partial class MenuPrincipal
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
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblSaldacao = new System.Windows.Forms.Label();
            this.btnComandas = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnCaixas = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(143, 29);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(290, 25);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "Menu Principal : Padarosa";
            // 
            // lblSaldacao
            // 
            this.lblSaldacao.AutoSize = true;
            this.lblSaldacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldacao.Location = new System.Drawing.Point(45, 118);
            this.lblSaldacao.Name = "lblSaldacao";
            this.lblSaldacao.Size = new System.Drawing.Size(305, 18);
            this.lblSaldacao.TabIndex = 1;
            this.lblSaldacao.Text = "Olá consagrado! Escolha uma opção abaixo:";
            // 
            // btnComandas
            // 
            this.btnComandas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComandas.Location = new System.Drawing.Point(48, 148);
            this.btnComandas.Name = "btnComandas";
            this.btnComandas.Size = new System.Drawing.Size(232, 87);
            this.btnComandas.TabIndex = 2;
            this.btnComandas.Text = "Comandas";
            this.btnComandas.UseVisualStyleBackColor = true;
            // 
            // btnProdutos
            // 
            this.btnProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutos.Location = new System.Drawing.Point(286, 148);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(222, 87);
            this.btnProdutos.TabIndex = 3;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.UseVisualStyleBackColor = true;
            // 
            // btnCaixas
            // 
            this.btnCaixas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaixas.Location = new System.Drawing.Point(48, 241);
            this.btnCaixas.Name = "btnCaixas";
            this.btnCaixas.Size = new System.Drawing.Size(460, 55);
            this.btnCaixas.TabIndex = 4;
            this.btnCaixas.Text = "Caixas";
            this.btnCaixas.UseVisualStyleBackColor = true;
            // 
            // btnUsuario
            // 
            this.btnUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.Location = new System.Drawing.Point(48, 302);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(460, 60);
            this.btnUsuario.TabIndex = 5;
            this.btnUsuario.Text = "Usuários";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 438);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnCaixas);
            this.Controls.Add(this.btnProdutos);
            this.Controls.Add(this.btnComandas);
            this.Controls.Add(this.lblSaldacao);
            this.Controls.Add(this.lblMenu);
            this.Name = "MenuPrincipal";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblSaldacao;
        private System.Windows.Forms.Button btnComandas;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnCaixas;
        private System.Windows.Forms.Button btnUsuario;
    }
}