namespace SistemaBarcos.UI
{
    partial class CadastroFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroFuncionario));
            this.BTNCadastrarFuncionario = new System.Windows.Forms.Button();
            this.TXTAdmissaoFuncionario = new System.Windows.Forms.TextBox();
            this.TXTCargoFuncionario = new System.Windows.Forms.TextBox();
            this.TXTNomeFuncionario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNCadastrarFuncionario
            // 
            this.BTNCadastrarFuncionario.Location = new System.Drawing.Point(611, 282);
            this.BTNCadastrarFuncionario.Name = "BTNCadastrarFuncionario";
            this.BTNCadastrarFuncionario.Size = new System.Drawing.Size(75, 23);
            this.BTNCadastrarFuncionario.TabIndex = 0;
            this.BTNCadastrarFuncionario.Text = "Cadastrar";
            this.BTNCadastrarFuncionario.UseVisualStyleBackColor = true;
            this.BTNCadastrarFuncionario.Click += new System.EventHandler(this.BTNCadastrarFuncionario_Click);
            // 
            // TXTAdmissaoFuncionario
            // 
            this.TXTAdmissaoFuncionario.Location = new System.Drawing.Point(598, 241);
            this.TXTAdmissaoFuncionario.Name = "TXTAdmissaoFuncionario";
            this.TXTAdmissaoFuncionario.Size = new System.Drawing.Size(100, 23);
            this.TXTAdmissaoFuncionario.TabIndex = 1;
            this.TXTAdmissaoFuncionario.TextChanged += new System.EventHandler(this.TXTAdmissaoFuncionario_TextChanged);
            // 
            // TXTCargoFuncionario
            // 
            this.TXTCargoFuncionario.Location = new System.Drawing.Point(598, 197);
            this.TXTCargoFuncionario.Name = "TXTCargoFuncionario";
            this.TXTCargoFuncionario.Size = new System.Drawing.Size(100, 23);
            this.TXTCargoFuncionario.TabIndex = 2;
            this.TXTCargoFuncionario.TextChanged += new System.EventHandler(this.TXTCargoFuncionario_TextChanged);
            // 
            // TXTNomeFuncionario
            // 
            this.TXTNomeFuncionario.Location = new System.Drawing.Point(598, 153);
            this.TXTNomeFuncionario.Name = "TXTNomeFuncionario";
            this.TXTNomeFuncionario.Size = new System.Drawing.Size(100, 23);
            this.TXTNomeFuncionario.TabIndex = 3;
            this.TXTNomeFuncionario.TextChanged += new System.EventHandler(this.TXTNomeFuncionario_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(598, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(598, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cargo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(598, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Admissão";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-240, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(710, 460);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // CadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTNomeFuncionario);
            this.Controls.Add(this.TXTCargoFuncionario);
            this.Controls.Add(this.TXTAdmissaoFuncionario);
            this.Controls.Add(this.BTNCadastrarFuncionario);
            this.Name = "CadastroFuncionario";
            this.Text = "CadastroFuncionario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BTNCadastrarFuncionario;
        private TextBox TXTAdmissaoFuncionario;
        private TextBox TXTCargoFuncionario;
        private TextBox TXTNomeFuncionario;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
    }
}