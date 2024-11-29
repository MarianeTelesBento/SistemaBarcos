namespace SistemaBarcos.UI
{
    partial class BuscarBarco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarBarco));
            this.label1 = new System.Windows.Forms.Label();
            this.TXTIDBuscaBarco = new System.Windows.Forms.TextBox();
            this.TXTNomeBuscaBarco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTDescricaoBuscaBarco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BTNBuscarSalvar = new System.Windows.Forms.Button();
            this.BTNBuscar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar ID";
            // 
            // TXTIDBuscaBarco
            // 
            this.TXTIDBuscaBarco.Location = new System.Drawing.Point(557, 132);
            this.TXTIDBuscaBarco.Name = "TXTIDBuscaBarco";
            this.TXTIDBuscaBarco.Size = new System.Drawing.Size(100, 23);
            this.TXTIDBuscaBarco.TabIndex = 1;
            this.TXTIDBuscaBarco.TextChanged += new System.EventHandler(this.TXTIDBuscaBarco_TextChanged);
            // 
            // TXTNomeBuscaBarco
            // 
            this.TXTNomeBuscaBarco.Location = new System.Drawing.Point(557, 198);
            this.TXTNomeBuscaBarco.Name = "TXTNomeBuscaBarco";
            this.TXTNomeBuscaBarco.Size = new System.Drawing.Size(100, 23);
            this.TXTNomeBuscaBarco.TabIndex = 3;
            this.TXTNomeBuscaBarco.TextChanged += new System.EventHandler(this.TXTNomeBuscaBarco_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // TXTDescricaoBuscaBarco
            // 
            this.TXTDescricaoBuscaBarco.Location = new System.Drawing.Point(557, 227);
            this.TXTDescricaoBuscaBarco.Name = "TXTDescricaoBuscaBarco";
            this.TXTDescricaoBuscaBarco.Size = new System.Drawing.Size(100, 23);
            this.TXTDescricaoBuscaBarco.TabIndex = 5;
            this.TXTDescricaoBuscaBarco.TextChanged += new System.EventHandler(this.TXTDescricaoBuscaBarco_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descricao";
            // 
            // BTNBuscarSalvar
            // 
            this.BTNBuscarSalvar.Location = new System.Drawing.Point(567, 271);
            this.BTNBuscarSalvar.Name = "BTNBuscarSalvar";
            this.BTNBuscarSalvar.Size = new System.Drawing.Size(75, 23);
            this.BTNBuscarSalvar.TabIndex = 6;
            this.BTNBuscarSalvar.Text = "Salvar";
            this.BTNBuscarSalvar.UseVisualStyleBackColor = true;
            this.BTNBuscarSalvar.Click += new System.EventHandler(this.BTNBuscarSalvar_Click);
            // 
            // BTNBuscar
            // 
            this.BTNBuscar.Location = new System.Drawing.Point(695, 132);
            this.BTNBuscar.Name = "BTNBuscar";
            this.BTNBuscar.Size = new System.Drawing.Size(75, 23);
            this.BTNBuscar.TabIndex = 7;
            this.BTNBuscar.Text = "Buscar";
            this.BTNBuscar.UseVisualStyleBackColor = true;
            this.BTNBuscar.Click += new System.EventHandler(this.BTNBuscar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-227, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(653, 456);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // BuscarBarco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BTNBuscar);
            this.Controls.Add(this.BTNBuscarSalvar);
            this.Controls.Add(this.TXTDescricaoBuscaBarco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTNomeBuscaBarco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTIDBuscaBarco);
            this.Controls.Add(this.label1);
            this.Name = "BuscarBarco";
            this.Text = "BuscarBarco";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox TXTIDBuscaBarco;
        private TextBox TXTNomeBuscaBarco;
        private Label label2;
        private TextBox TXTDescricaoBuscaBarco;
        private Label label3;
        private Button BTNBuscarSalvar;
        private Button BTNBuscar;
        private PictureBox pictureBox2;
    }
}