namespace SistemaBarcos.UI
{
    partial class CadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCliente));
            this.TXTNomeCliente = new System.Windows.Forms.TextBox();
            this.BTNCadastrarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTEmailCliente = new System.Windows.Forms.TextBox();
            this.TXTTelefoneCliente = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTNomeCliente
            // 
            this.TXTNomeCliente.Location = new System.Drawing.Point(604, 158);
            this.TXTNomeCliente.Name = "TXTNomeCliente";
            this.TXTNomeCliente.Size = new System.Drawing.Size(100, 23);
            this.TXTNomeCliente.TabIndex = 0;
            this.TXTNomeCliente.TextChanged += new System.EventHandler(this.TXTNomeCliente_TextChanged);
            // 
            // BTNCadastrarCliente
            // 
            this.BTNCadastrarCliente.Location = new System.Drawing.Point(617, 312);
            this.BTNCadastrarCliente.Name = "BTNCadastrarCliente";
            this.BTNCadastrarCliente.Size = new System.Drawing.Size(75, 23);
            this.BTNCadastrarCliente.TabIndex = 3;
            this.BTNCadastrarCliente.Text = "Cadastrar";
            this.BTNCadastrarCliente.UseVisualStyleBackColor = true;
            this.BTNCadastrarCliente.Click += new System.EventHandler(this.BTNCadastrarCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(604, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(604, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(605, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            // 
            // TXTEmailCliente
            // 
            this.TXTEmailCliente.Location = new System.Drawing.Point(604, 257);
            this.TXTEmailCliente.Name = "TXTEmailCliente";
            this.TXTEmailCliente.Size = new System.Drawing.Size(100, 23);
            this.TXTEmailCliente.TabIndex = 7;
            this.TXTEmailCliente.TextChanged += new System.EventHandler(this.TXTEmailCliente_TextChanged);
            // 
            // TXTTelefoneCliente
            // 
            this.TXTTelefoneCliente.Location = new System.Drawing.Point(604, 207);
            this.TXTTelefoneCliente.Name = "TXTTelefoneCliente";
            this.TXTTelefoneCliente.Size = new System.Drawing.Size(100, 23);
            this.TXTTelefoneCliente.TabIndex = 8;
            this.TXTTelefoneCliente.TextChanged += new System.EventHandler(this.TXTTelefoneCliente_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-96, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(596, 460);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TXTTelefoneCliente);
            this.Controls.Add(this.TXTEmailCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNCadastrarCliente);
            this.Controls.Add(this.TXTNomeCliente);
            this.Name = "CadastroCliente";
            this.Text = "CadastroCliente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TXTNomeCliente;
        private Button BTNCadastrarCliente;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TXTEmailCliente;
        private TextBox TXTTelefoneCliente;
        private PictureBox pictureBox1;
    }
}