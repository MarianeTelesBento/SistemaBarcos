namespace SistemaBarcos.UI
{
    partial class ExcluirFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcluirFuncionario));
            this.label1 = new System.Windows.Forms.Label();
            this.BTNExcluirFuncionario = new System.Windows.Forms.Button();
            this.TXTIdFuncionario = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(597, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Funcionario";
            // 
            // BTNExcluirFuncionario
            // 
            this.BTNExcluirFuncionario.Location = new System.Drawing.Point(606, 250);
            this.BTNExcluirFuncionario.Name = "BTNExcluirFuncionario";
            this.BTNExcluirFuncionario.Size = new System.Drawing.Size(75, 23);
            this.BTNExcluirFuncionario.TabIndex = 1;
            this.BTNExcluirFuncionario.Text = "Excluir";
            this.BTNExcluirFuncionario.UseVisualStyleBackColor = true;
            // 
            // TXTIdFuncionario
            // 
            this.TXTIdFuncionario.Location = new System.Drawing.Point(594, 199);
            this.TXTIdFuncionario.Name = "TXTIdFuncionario";
            this.TXTIdFuncionario.Size = new System.Drawing.Size(100, 23);
            this.TXTIdFuncionario.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-237, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(710, 460);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // ExcluirFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TXTIdFuncionario);
            this.Controls.Add(this.BTNExcluirFuncionario);
            this.Controls.Add(this.label1);
            this.Name = "ExcluirFuncionario";
            this.Text = "ExcluirFuncionario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button BTNExcluirFuncionario;
        private TextBox TXTIdFuncionario;
        private PictureBox pictureBox1;
    }
}