namespace SistemaBarcos.UI
{
    partial class Iniciar
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
            this.BTNCadastroBarco = new System.Windows.Forms.Button();
            this.BTNCadastrarCliente = new System.Windows.Forms.Button();
            this.BTNExcluirCliente = new System.Windows.Forms.Button();
            this.BTNExcluirBarco = new System.Windows.Forms.Button();
            this.BTNCadastrarFuncionario = new System.Windows.Forms.Button();
            this.BTNExcluirFuncionario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTNCadastroBarco
            // 
            this.BTNCadastroBarco.Location = new System.Drawing.Point(45, 198);
            this.BTNCadastroBarco.Name = "BTNCadastroBarco";
            this.BTNCadastroBarco.Size = new System.Drawing.Size(75, 23);
            this.BTNCadastroBarco.TabIndex = 0;
            this.BTNCadastroBarco.Text = "Cadastro ";
            this.BTNCadastroBarco.UseVisualStyleBackColor = true;
            this.BTNCadastroBarco.Click += new System.EventHandler(this.BTNCadastroBarco_Click);
            // 
            // BTNCadastrarCliente
            // 
            this.BTNCadastrarCliente.Location = new System.Drawing.Point(217, 198);
            this.BTNCadastrarCliente.Name = "BTNCadastrarCliente";
            this.BTNCadastrarCliente.Size = new System.Drawing.Size(75, 23);
            this.BTNCadastrarCliente.TabIndex = 1;
            this.BTNCadastrarCliente.Text = "Cadastrar";
            this.BTNCadastrarCliente.UseVisualStyleBackColor = true;
            this.BTNCadastrarCliente.Click += new System.EventHandler(this.BTNCadastrarCliente_Click);
            // 
            // BTNExcluirCliente
            // 
            this.BTNExcluirCliente.Location = new System.Drawing.Point(217, 240);
            this.BTNExcluirCliente.Name = "BTNExcluirCliente";
            this.BTNExcluirCliente.Size = new System.Drawing.Size(75, 23);
            this.BTNExcluirCliente.TabIndex = 2;
            this.BTNExcluirCliente.Text = "Excluir";
            this.BTNExcluirCliente.UseVisualStyleBackColor = true;
            this.BTNExcluirCliente.Click += new System.EventHandler(this.BTNExcluirCliente_Click);
            // 
            // BTNExcluirBarco
            // 
            this.BTNExcluirBarco.Location = new System.Drawing.Point(45, 240);
            this.BTNExcluirBarco.Name = "BTNExcluirBarco";
            this.BTNExcluirBarco.Size = new System.Drawing.Size(75, 23);
            this.BTNExcluirBarco.TabIndex = 3;
            this.BTNExcluirBarco.Text = "Excluir";
            this.BTNExcluirBarco.UseVisualStyleBackColor = true;
            this.BTNExcluirBarco.Click += new System.EventHandler(this.BTNExcluirBarco_Click);
            // 
            // BTNCadastrarFuncionario
            // 
            this.BTNCadastrarFuncionario.Location = new System.Drawing.Point(394, 198);
            this.BTNCadastrarFuncionario.Name = "BTNCadastrarFuncionario";
            this.BTNCadastrarFuncionario.Size = new System.Drawing.Size(75, 23);
            this.BTNCadastrarFuncionario.TabIndex = 4;
            this.BTNCadastrarFuncionario.Text = "Cadastrar";
            this.BTNCadastrarFuncionario.UseVisualStyleBackColor = true;
            this.BTNCadastrarFuncionario.Click += new System.EventHandler(this.BTNCadastrarFuncionario_Click);
            // 
            // BTNExcluirFuncionario
            // 
            this.BTNExcluirFuncionario.Location = new System.Drawing.Point(394, 240);
            this.BTNExcluirFuncionario.Name = "BTNExcluirFuncionario";
            this.BTNExcluirFuncionario.Size = new System.Drawing.Size(75, 23);
            this.BTNExcluirFuncionario.TabIndex = 5;
            this.BTNExcluirFuncionario.Text = "Excluir";
            this.BTNExcluirFuncionario.UseVisualStyleBackColor = true;
            this.BTNExcluirFuncionario.Click += new System.EventHandler(this.BTNExcluirFuncionario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Barco";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Funcionário";
            // 
            // Iniciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNExcluirFuncionario);
            this.Controls.Add(this.BTNCadastrarFuncionario);
            this.Controls.Add(this.BTNExcluirBarco);
            this.Controls.Add(this.BTNExcluirCliente);
            this.Controls.Add(this.BTNCadastrarCliente);
            this.Controls.Add(this.BTNCadastroBarco);
            this.Name = "Iniciar";
            this.Text = "Iniciar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BTNCadastroBarco;
        private Button BTNCadastrarCliente;
        private Button BTNExcluirCliente;
        private Button BTNExcluirBarco;
        private Button BTNCadastrarFuncionario;
        private Button BTNExcluirFuncionario;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}