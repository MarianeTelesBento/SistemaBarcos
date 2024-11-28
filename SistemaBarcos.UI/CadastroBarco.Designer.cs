namespace SistemaBarcos.UI
{
    partial class CadastroBarco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroBarco));
            this.TXTNomeBarco = new System.Windows.Forms.TextBox();
            this.TXTFabricacaoBarco = new System.Windows.Forms.TextBox();
            this.TXTCapacidadeBarco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BTNCadastrarBarco = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTNomeBarco
            // 
            this.TXTNomeBarco.Location = new System.Drawing.Point(570, 145);
            this.TXTNomeBarco.Name = "TXTNomeBarco";
            this.TXTNomeBarco.Size = new System.Drawing.Size(100, 23);
            this.TXTNomeBarco.TabIndex = 0;
            this.TXTNomeBarco.TextChanged += new System.EventHandler(this.TXTNomeBarco_TextChanged);
            // 
            // TXTFabricacaoBarco
            // 
            this.TXTFabricacaoBarco.Location = new System.Drawing.Point(570, 189);
            this.TXTFabricacaoBarco.Name = "TXTFabricacaoBarco";
            this.TXTFabricacaoBarco.Size = new System.Drawing.Size(100, 23);
            this.TXTFabricacaoBarco.TabIndex = 1;
            this.TXTFabricacaoBarco.TextChanged += new System.EventHandler(this.TXTFabricacaoBarco_TextChanged);
            // 
            // TXTCapacidadeBarco
            // 
            this.TXTCapacidadeBarco.Location = new System.Drawing.Point(570, 244);
            this.TXTCapacidadeBarco.Name = "TXTCapacidadeBarco";
            this.TXTCapacidadeBarco.Size = new System.Drawing.Size(100, 23);
            this.TXTCapacidadeBarco.TabIndex = 2;
            this.TXTCapacidadeBarco.TextChanged += new System.EventHandler(this.TXTCapacidadeBarco_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(570, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(570, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fabricacao";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(570, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Capacidade";
            // 
            // BTNCadastrarBarco
            // 
            this.BTNCadastrarBarco.Location = new System.Drawing.Point(581, 308);
            this.BTNCadastrarBarco.Name = "BTNCadastrarBarco";
            this.BTNCadastrarBarco.Size = new System.Drawing.Size(75, 23);
            this.BTNCadastrarBarco.TabIndex = 6;
            this.BTNCadastrarBarco.Text = "Cadastrar";
            this.BTNCadastrarBarco.UseVisualStyleBackColor = true;
            this.BTNCadastrarBarco.Click += new System.EventHandler(this.BTNCadastrarBarco_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-236, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-214, -3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(653, 456);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // CadastroBarco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTNCadastrarBarco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTCapacidadeBarco);
            this.Controls.Add(this.TXTFabricacaoBarco);
            this.Controls.Add(this.TXTNomeBarco);
            this.Name = "CadastroBarco";
            this.Text = "CadastroBarco";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TXTNomeBarco;
        private TextBox TXTFabricacaoBarco;
        private TextBox TXTCapacidadeBarco;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button BTNCadastrarBarco;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}