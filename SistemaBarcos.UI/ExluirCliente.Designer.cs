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
            label1 = new Label();
            TXTIdCliente = new TextBox();
            BTNExcluirCliente = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(560, 163);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "ID Cliente";
            // 
            // TXTIdCliente
            // 
            TXTIdCliente.Location = new Point(560, 181);
            TXTIdCliente.Name = "TXTIdCliente";
            TXTIdCliente.Size = new Size(100, 23);
            TXTIdCliente.TabIndex = 1;
            TXTIdCliente.TextChanged += TXTIdCliente_TextChanged;
            // 
            // BTNExcluirCliente
            // 
            BTNExcluirCliente.Location = new Point(573, 225);
            BTNExcluirCliente.Name = "BTNExcluirCliente";
            BTNExcluirCliente.Size = new Size(75, 23);
            BTNExcluirCliente.TabIndex = 2;
            BTNExcluirCliente.Text = "Excluir";
            BTNExcluirCliente.UseVisualStyleBackColor = true;
            BTNExcluirCliente.Click += BTNExcluirCliente_Click;
            // 
            // ExluirCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BTNExcluirCliente);
            Controls.Add(TXTIdCliente);
            Controls.Add(label1);
            Name = "ExluirCliente";
            Text = "ExluirCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TXTIdCliente;
        private Button BTNExcluirCliente;
    }
}