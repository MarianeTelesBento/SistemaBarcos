﻿namespace SistemaBarcos.UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Iniciar));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNExcluirFuncionario = new System.Windows.Forms.Button();
            this.BTNCadastrarFuncionario = new System.Windows.Forms.Button();
            this.BTNExcluirBarco = new System.Windows.Forms.Button();
            this.BTNExcluirCliente = new System.Windows.Forms.Button();
            this.BTNCadastrarCliente = new System.Windows.Forms.Button();
            this.BTNCadastroBarco = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(528, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Funcionário";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(224, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cliente";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(64, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Barco";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BTNExcluirFuncionario
            // 
            this.BTNExcluirFuncionario.Location = new System.Drawing.Point(401, 249);
            this.BTNExcluirFuncionario.Name = "BTNExcluirFuncionario";
            this.BTNExcluirFuncionario.Size = new System.Drawing.Size(75, 23);
            this.BTNExcluirFuncionario.TabIndex = 15;
            this.BTNExcluirFuncionario.Text = "Excluir";
            this.BTNExcluirFuncionario.UseVisualStyleBackColor = true;
            this.BTNExcluirFuncionario.Click += new System.EventHandler(this.BTNExcluirFuncionario_Click_1);
            // 
            // BTNCadastrarFuncionario
            // 
            this.BTNCadastrarFuncionario.Location = new System.Drawing.Point(401, 207);
            this.BTNCadastrarFuncionario.Name = "BTNCadastrarFuncionario";
            this.BTNCadastrarFuncionario.Size = new System.Drawing.Size(75, 23);
            this.BTNCadastrarFuncionario.TabIndex = 14;
            this.BTNCadastrarFuncionario.Text = "Cadastrar";
            this.BTNCadastrarFuncionario.UseVisualStyleBackColor = true;
            this.BTNCadastrarFuncionario.Click += new System.EventHandler(this.BTNCadastrarFuncionario_Click_1);
            // 
            // BTNExcluirBarco
            // 
            this.BTNExcluirBarco.Location = new System.Drawing.Point(64, 249);
            this.BTNExcluirBarco.Name = "BTNExcluirBarco";
            this.BTNExcluirBarco.Size = new System.Drawing.Size(75, 23);
            this.BTNExcluirBarco.TabIndex = 13;
            this.BTNExcluirBarco.Text = "Excluir";
            this.BTNExcluirBarco.UseVisualStyleBackColor = true;
            this.BTNExcluirBarco.Click += new System.EventHandler(this.BTNExcluirBarco_Click_1);
            // 
            // BTNExcluirCliente
            // 
            this.BTNExcluirCliente.Location = new System.Drawing.Point(224, 249);
            this.BTNExcluirCliente.Name = "BTNExcluirCliente";
            this.BTNExcluirCliente.Size = new System.Drawing.Size(75, 23);
            this.BTNExcluirCliente.TabIndex = 12;
            this.BTNExcluirCliente.Text = "Excluir";
            this.BTNExcluirCliente.UseVisualStyleBackColor = true;
            this.BTNExcluirCliente.Click += new System.EventHandler(this.BTNExcluirCliente_Click_1);
            // 
            // BTNCadastrarCliente
            // 
            this.BTNCadastrarCliente.Location = new System.Drawing.Point(224, 207);
            this.BTNCadastrarCliente.Name = "BTNCadastrarCliente";
            this.BTNCadastrarCliente.Size = new System.Drawing.Size(75, 23);
            this.BTNCadastrarCliente.TabIndex = 11;
            this.BTNCadastrarCliente.Text = "Cadastrar";
            this.BTNCadastrarCliente.UseVisualStyleBackColor = true;
            this.BTNCadastrarCliente.Click += new System.EventHandler(this.BTNCadastrarCliente_Click_1);
            // 
            // BTNCadastroBarco
            // 
            this.BTNCadastroBarco.Location = new System.Drawing.Point(64, 207);
            this.BTNCadastroBarco.Name = "BTNCadastroBarco";
            this.BTNCadastroBarco.Size = new System.Drawing.Size(75, 23);
            this.BTNCadastroBarco.TabIndex = 10;
            this.BTNCadastroBarco.Text = "Cadastro ";
            this.BTNCadastroBarco.UseVisualStyleBackColor = true;
            this.BTNCadastroBarco.Click += new System.EventHandler(this.BTNCadastroBarco_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Iniciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNExcluirFuncionario);
            this.Controls.Add(this.BTNCadastrarFuncionario);
            this.Controls.Add(this.BTNExcluirBarco);
            this.Controls.Add(this.BTNExcluirCliente);
            this.Controls.Add(this.BTNCadastrarCliente);
            this.Controls.Add(this.BTNCadastroBarco);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Iniciar";
            this.Text = "Iniciar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button BTNExcluirFuncionario;
        private Button BTNCadastrarFuncionario;
        private Button BTNExcluirBarco;
        private Button BTNExcluirCliente;
        private Button BTNCadastrarCliente;
        private Button BTNCadastroBarco;
        private Button button1;
    }
}