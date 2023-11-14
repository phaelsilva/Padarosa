namespace Padarosa.Views
{
    partial class GerenciamentoUsuarios
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
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.grbCadastro = new System.Windows.Forms.GroupBox();
            this.lblNomecad = new System.Windows.Forms.Label();
            this.lblEmailcad = new System.Windows.Forms.Label();
            this.lblSenhacad = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblSenhaedi = new System.Windows.Forms.Label();
            this.lblEmailedi = new System.Windows.Forms.Label();
            this.lblNomecompletoedi = new System.Windows.Forms.Label();
            this.txbNomecad = new System.Windows.Forms.TextBox();
            this.txbEmailcad = new System.Windows.Forms.TextBox();
            this.txbSenhacad = new System.Windows.Forms.TextBox();
            this.txbNomecompletoedi = new System.Windows.Forms.TextBox();
            this.txbEmailedi = new System.Windows.Forms.TextBox();
            this.txbNovasenha = new System.Windows.Forms.TextBox();
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.lblApagar = new System.Windows.Forms.Label();
            this.btnApagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.grbCadastro.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.grbApagar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.AllowUserToAddRows = false;
            this.dgvUsuario.AllowUserToDeleteRows = false;
            this.dgvUsuario.AllowUserToResizeColumns = false;
            this.dgvUsuario.AllowUserToResizeRows = false;
            this.dgvUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Location = new System.Drawing.Point(40, 24);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.ReadOnly = true;
            this.dgvUsuario.Size = new System.Drawing.Size(493, 232);
            this.dgvUsuario.TabIndex = 0;
            this.dgvUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuario_CellClick);
            // 
            // grbCadastro
            // 
            this.grbCadastro.Controls.Add(this.txbSenhacad);
            this.grbCadastro.Controls.Add(this.txbEmailcad);
            this.grbCadastro.Controls.Add(this.txbNomecad);
            this.grbCadastro.Controls.Add(this.btnCadastrar);
            this.grbCadastro.Controls.Add(this.lblSenhacad);
            this.grbCadastro.Controls.Add(this.lblEmailcad);
            this.grbCadastro.Controls.Add(this.lblNomecad);
            this.grbCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCadastro.Location = new System.Drawing.Point(40, 263);
            this.grbCadastro.Name = "grbCadastro";
            this.grbCadastro.Size = new System.Drawing.Size(237, 129);
            this.grbCadastro.TabIndex = 1;
            this.grbCadastro.TabStop = false;
            this.grbCadastro.Text = "Cadastro:";
            // 
            // lblNomecad
            // 
            this.lblNomecad.AutoSize = true;
            this.lblNomecad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomecad.Location = new System.Drawing.Point(7, 20);
            this.lblNomecad.Name = "lblNomecad";
            this.lblNomecad.Size = new System.Drawing.Size(85, 13);
            this.lblNomecad.TabIndex = 0;
            this.lblNomecad.Text = "Nome Completo:";
            // 
            // lblEmailcad
            // 
            this.lblEmailcad.AutoSize = true;
            this.lblEmailcad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailcad.Location = new System.Drawing.Point(57, 43);
            this.lblEmailcad.Name = "lblEmailcad";
            this.lblEmailcad.Size = new System.Drawing.Size(35, 13);
            this.lblEmailcad.TabIndex = 1;
            this.lblEmailcad.Text = "Email:";
            // 
            // lblSenhacad
            // 
            this.lblSenhacad.AutoSize = true;
            this.lblSenhacad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhacad.Location = new System.Drawing.Point(51, 65);
            this.lblSenhacad.Name = "lblSenhacad";
            this.lblSenhacad.Size = new System.Drawing.Size(41, 13);
            this.lblSenhacad.TabIndex = 2;
            this.lblSenhacad.Text = "Senha:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(34, 90);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(163, 33);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.txbNovasenha);
            this.grbEditar.Controls.Add(this.txbEmailedi);
            this.grbEditar.Controls.Add(this.txbNomecompletoedi);
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.lblSenhaedi);
            this.grbEditar.Controls.Add(this.lblEmailedi);
            this.grbEditar.Controls.Add(this.lblNomecompletoedi);
            this.grbEditar.Enabled = false;
            this.grbEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEditar.Location = new System.Drawing.Point(283, 263);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(250, 129);
            this.grbEditar.TabIndex = 4;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar:";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(34, 90);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(163, 33);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // lblSenhaedi
            // 
            this.lblSenhaedi.AutoSize = true;
            this.lblSenhaedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaedi.Location = new System.Drawing.Point(22, 65);
            this.lblSenhaedi.Name = "lblSenhaedi";
            this.lblSenhaedi.Size = new System.Drawing.Size(70, 13);
            this.lblSenhaedi.TabIndex = 2;
            this.lblSenhaedi.Text = "Nova Senha:";
            // 
            // lblEmailedi
            // 
            this.lblEmailedi.AutoSize = true;
            this.lblEmailedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailedi.Location = new System.Drawing.Point(57, 43);
            this.lblEmailedi.Name = "lblEmailedi";
            this.lblEmailedi.Size = new System.Drawing.Size(35, 13);
            this.lblEmailedi.TabIndex = 1;
            this.lblEmailedi.Text = "Email:";
            // 
            // lblNomecompletoedi
            // 
            this.lblNomecompletoedi.AutoSize = true;
            this.lblNomecompletoedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomecompletoedi.Location = new System.Drawing.Point(7, 20);
            this.lblNomecompletoedi.Name = "lblNomecompletoedi";
            this.lblNomecompletoedi.Size = new System.Drawing.Size(85, 13);
            this.lblNomecompletoedi.TabIndex = 0;
            this.lblNomecompletoedi.Text = "Nome Completo:";
            // 
            // txbNomecad
            // 
            this.txbNomecad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomecad.Location = new System.Drawing.Point(98, 17);
            this.txbNomecad.Name = "txbNomecad";
            this.txbNomecad.Size = new System.Drawing.Size(132, 20);
            this.txbNomecad.TabIndex = 4;
            // 
            // txbEmailcad
            // 
            this.txbEmailcad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmailcad.Location = new System.Drawing.Point(98, 40);
            this.txbEmailcad.Name = "txbEmailcad";
            this.txbEmailcad.Size = new System.Drawing.Size(132, 20);
            this.txbEmailcad.TabIndex = 5;
            // 
            // txbSenhacad
            // 
            this.txbSenhacad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSenhacad.Location = new System.Drawing.Point(98, 62);
            this.txbSenhacad.Name = "txbSenhacad";
            this.txbSenhacad.Size = new System.Drawing.Size(132, 20);
            this.txbSenhacad.TabIndex = 6;
            // 
            // txbNomecompletoedi
            // 
            this.txbNomecompletoedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomecompletoedi.Location = new System.Drawing.Point(97, 17);
            this.txbNomecompletoedi.Name = "txbNomecompletoedi";
            this.txbNomecompletoedi.Size = new System.Drawing.Size(147, 20);
            this.txbNomecompletoedi.TabIndex = 4;
            // 
            // txbEmailedi
            // 
            this.txbEmailedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmailedi.Location = new System.Drawing.Point(97, 43);
            this.txbEmailedi.Name = "txbEmailedi";
            this.txbEmailedi.Size = new System.Drawing.Size(147, 20);
            this.txbEmailedi.TabIndex = 5;
            // 
            // txbNovasenha
            // 
            this.txbNovasenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNovasenha.Location = new System.Drawing.Point(97, 65);
            this.txbNovasenha.Name = "txbNovasenha";
            this.txbNovasenha.Size = new System.Drawing.Size(147, 20);
            this.txbNovasenha.TabIndex = 6;
            // 
            // grbApagar
            // 
            this.grbApagar.Controls.Add(this.btnApagar);
            this.grbApagar.Controls.Add(this.lblApagar);
            this.grbApagar.Enabled = false;
            this.grbApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbApagar.Location = new System.Drawing.Point(84, 412);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Size = new System.Drawing.Size(406, 55);
            this.grbApagar.TabIndex = 5;
            this.grbApagar.TabStop = false;
            this.grbApagar.Text = "Apagar";
            // 
            // lblApagar
            // 
            this.lblApagar.AutoSize = true;
            this.lblApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApagar.Location = new System.Drawing.Point(51, 25);
            this.lblApagar.Name = "lblApagar";
            this.lblApagar.Size = new System.Drawing.Size(160, 13);
            this.lblApagar.TabIndex = 0;
            this.lblApagar.Text = "Selecione o usuário para apagar";
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(269, 20);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 1;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // GerenciamentoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 501);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbCadastro);
            this.Controls.Add(this.dgvUsuario);
            this.Name = "GerenciamentoUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Usuarios";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.grbCadastro.ResumeLayout(false);
            this.grbCadastro.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.grbApagar.ResumeLayout(false);
            this.grbApagar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.GroupBox grbCadastro;
        private System.Windows.Forms.Label lblNomecad;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblSenhacad;
        private System.Windows.Forms.Label lblEmailcad;
        private System.Windows.Forms.TextBox txbSenhacad;
        private System.Windows.Forms.TextBox txbEmailcad;
        private System.Windows.Forms.TextBox txbNomecad;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.TextBox txbNomecompletoedi;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblSenhaedi;
        private System.Windows.Forms.Label lblEmailedi;
        private System.Windows.Forms.Label lblNomecompletoedi;
        private System.Windows.Forms.TextBox txbNovasenha;
        private System.Windows.Forms.TextBox txbEmailedi;
        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Label lblApagar;
        private System.Windows.Forms.Button btnApagar;
    }
}