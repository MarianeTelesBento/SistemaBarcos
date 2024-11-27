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
            label1 = new Label();
            BTNExcluirFuncionario = new Button();
            TXTIdFuncionario = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(569, 167);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "ID Funcionario";
            // 
            // BTNExcluirFuncionario
            // 
            BTNExcluirFuncionario.Location = new Point(578, 236);
            BTNExcluirFuncionario.Name = "BTNExcluirFuncionario";
            BTNExcluirFuncionario.Size = new Size(75, 23);
            BTNExcluirFuncionario.TabIndex = 1;
            BTNExcluirFuncionario.Text = "Excluir";
            BTNExcluirFuncionario.UseVisualStyleBackColor = true;
            BTNExcluirFuncionario.Click += BTNExcluirFuncionario_Click;
            // 
            // TXTIdFuncionario
            // 
            TXTIdFuncionario.Location = new Point(566, 185);
            TXTIdFuncionario.Name = "TXTIdFuncionario";
            TXTIdFuncionario.Size = new Size(100, 23);
            TXTIdFuncionario.TabIndex = 2;
            TXTIdFuncionario.TextChanged += TXTIdFuncionario_TextChanged;
            // 
            // ExcluirFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TXTIdFuncionario);
            Controls.Add(BTNExcluirFuncionario);
            Controls.Add(label1);
            Name = "ExcluirFuncionario";
            Text = "ExcluirFuncionario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BTNExcluirFuncionario;
        private TextBox TXTIdFuncionario;
    }
}