namespace SistemaBarcos.UI
{
    partial class ExcluirBarco
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TXTIdBarco = new System.Windows.Forms.TextBox();
            this.IdBarco = new System.Windows.Forms.Label();
            this.BTNExcluirBarco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TXTIdBarco
            // 
            this.TXTIdBarco.Location = new System.Drawing.Point(563, 173);
            this.TXTIdBarco.Name = "TXTIdBarco";
            this.TXTIdBarco.Size = new System.Drawing.Size(100, 23);
            this.TXTIdBarco.TabIndex = 1;
            this.TXTIdBarco.TextChanged += new System.EventHandler(this.TXTIdBarco_TextChanged);
            // 
            // IdBarco
            // 
            this.IdBarco.AutoSize = true;
            this.IdBarco.Location = new System.Drawing.Point(563, 155);
            this.IdBarco.Name = "IdBarco";
            this.IdBarco.Size = new System.Drawing.Size(51, 15);
            this.IdBarco.TabIndex = 2;
            this.IdBarco.Text = "ID Barco";
            // 
            // BTNExcluirBarco
            // 
            this.BTNExcluirBarco.Location = new System.Drawing.Point(577, 220);
            this.BTNExcluirBarco.Name = "BTNExcluirBarco";
            this.BTNExcluirBarco.Size = new System.Drawing.Size(75, 23);
            this.BTNExcluirBarco.TabIndex = 3;
            this.BTNExcluirBarco.Text = "Excluir";
            this.BTNExcluirBarco.UseVisualStyleBackColor = true;
            this.BTNExcluirBarco.Click += new System.EventHandler(this.BTNExcluirBarco_Click);
            // 
            // ExcluirBarco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNExcluirBarco);
            this.Controls.Add(this.IdBarco);
            this.Controls.Add(this.TXTIdBarco);
            this.Name = "ExcluirBarco";
            this.Text = "ExcluirBarco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private TextBox TXTIdBarco;
        private Label IdBarco;
        private Button BTNExcluirBarco;
    }
}