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
            BTNCadastrarFuncionario = new Button();
            TXTAdmissaoFuncionario = new TextBox();
            TXTCargoFuncionario = new TextBox();
            TXTNomeFuncionario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // BTNCadastrarFuncionario
            // 
            BTNCadastrarFuncionario.Location = new Point(584, 268);
            BTNCadastrarFuncionario.Name = "BTNCadastrarFuncionario";
            BTNCadastrarFuncionario.Size = new Size(75, 23);
            BTNCadastrarFuncionario.TabIndex = 0;
            BTNCadastrarFuncionario.Text = "Cadastrar";
            BTNCadastrarFuncionario.UseVisualStyleBackColor = true;
            BTNCadastrarFuncionario.Click += BTNCadastrarFuncionario_Click;
            // 
            // TXTAdmissaoFuncionario
            // 
            TXTAdmissaoFuncionario.Location = new Point(571, 227);
            TXTAdmissaoFuncionario.Name = "TXTAdmissaoFuncionario";
            TXTAdmissaoFuncionario.Size = new Size(100, 23);
            TXTAdmissaoFuncionario.TabIndex = 1;
            TXTAdmissaoFuncionario.TextChanged += TXTAdmissaoFuncionario_TextChanged;
            // 
            // TXTCargoFuncionario
            // 
            TXTCargoFuncionario.Location = new Point(571, 183);
            TXTCargoFuncionario.Name = "TXTCargoFuncionario";
            TXTCargoFuncionario.Size = new Size(100, 23);
            TXTCargoFuncionario.TabIndex = 2;
            TXTCargoFuncionario.TextChanged += TXTCargoFuncionario_TextChanged;
            // 
            // TXTNomeFuncionario
            // 
            TXTNomeFuncionario.Location = new Point(571, 139);
            TXTNomeFuncionario.Name = "TXTNomeFuncionario";
            TXTNomeFuncionario.Size = new Size(100, 23);
            TXTNomeFuncionario.TabIndex = 3;
            TXTNomeFuncionario.TextChanged += TXTNomeFuncionario_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(571, 121);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 4;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(571, 165);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Cargo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(571, 209);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 6;
            label3.Text = "Admissão";
            // 
            // CadastroFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TXTNomeFuncionario);
            Controls.Add(TXTCargoFuncionario);
            Controls.Add(TXTAdmissaoFuncionario);
            Controls.Add(BTNCadastrarFuncionario);
            Name = "CadastroFuncionario";
            Text = "CadastroFuncionario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTNCadastrarFuncionario;
        private TextBox TXTAdmissaoFuncionario;
        private TextBox TXTCargoFuncionario;
        private TextBox TXTNomeFuncionario;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}