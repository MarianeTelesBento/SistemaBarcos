namespace SistemaBarcos.UI
{
    partial class ExluirCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExluirCliente));
            this.label1 = new System.Windows.Forms.Label();
            this.TXTIdCliente = new System.Windows.Forms.TextBox();
            this.BTNExcluirCliente = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(592, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Cliente";
            // 
            // TXTIdCliente
            // 
            this.TXTIdCliente.Location = new System.Drawing.Point(592, 204);
            this.TXTIdCliente.Name = "TXTIdCliente";
            this.TXTIdCliente.Size = new System.Drawing.Size(100, 23);
            this.TXTIdCliente.TabIndex = 1;
            // 
            // BTNExcluirCliente
            // 
            this.BTNExcluirCliente.Location = new System.Drawing.Point(605, 248);
            this.BTNExcluirCliente.Name = "BTNExcluirCliente";
            this.BTNExcluirCliente.Size = new System.Drawing.Size(75, 23);
            this.BTNExcluirCliente.TabIndex = 2;
            this.BTNExcluirCliente.Text = "Excluir";
            this.BTNExcluirCliente.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-155, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(615, 460);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // ExluirCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTNExcluirCliente);
            this.Controls.Add(this.TXTIdCliente);
            this.Controls.Add(this.label1);
            this.Name = "ExluirCliente";
            this.Text = "ExluirCliente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox TXTIdCliente;
        private Button BTNExcluirCliente;
        private PictureBox pictureBox1;
    }
}