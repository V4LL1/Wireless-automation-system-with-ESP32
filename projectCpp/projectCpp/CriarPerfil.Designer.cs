namespace projectCpp
{
    partial class CriarPerfil
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
            senhaTxt = new TextBox();
            usuarioTxt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            nivelPermissaoTxt = new TextBox();
            CriarPerfilBtn = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // senhaTxt
            // 
            senhaTxt.BackColor = Color.FromArgb(236, 236, 236);
            senhaTxt.Location = new Point(70, 195);
            senhaTxt.Name = "senhaTxt";
            senhaTxt.Size = new Size(238, 25);
            senhaTxt.TabIndex = 7;
            // 
            // usuarioTxt
            // 
            usuarioTxt.BackColor = Color.FromArgb(236, 236, 236);
            usuarioTxt.Location = new Point(70, 87);
            usuarioTxt.Name = "usuarioTxt";
            usuarioTxt.Size = new Size(238, 25);
            usuarioTxt.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(17, 17, 17);
            label2.Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(236, 236, 236);
            label2.Location = new Point(70, 161);
            label2.Name = "label2";
            label2.Size = new Size(61, 18);
            label2.TabIndex = 5;
            label2.Text = "Senha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(17, 17, 17);
            label1.Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(236, 236, 236);
            label1.Location = new Point(70, 55);
            label1.Name = "label1";
            label1.Size = new Size(75, 18);
            label1.TabIndex = 4;
            label1.Text = "Usuário:";
            // 
            // nivelPermissaoTxt
            // 
            nivelPermissaoTxt.BackColor = Color.FromArgb(236, 236, 236);
            nivelPermissaoTxt.Location = new Point(70, 304);
            nivelPermissaoTxt.Name = "nivelPermissaoTxt";
            nivelPermissaoTxt.Size = new Size(238, 25);
            nivelPermissaoTxt.TabIndex = 8;
            // 
            // CriarPerfilBtn
            // 
            CriarPerfilBtn.BackColor = Color.FromArgb(236, 236, 236);
            CriarPerfilBtn.Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CriarPerfilBtn.ForeColor = Color.FromArgb(17, 17, 17);
            CriarPerfilBtn.Location = new Point(203, 392);
            CriarPerfilBtn.Name = "CriarPerfilBtn";
            CriarPerfilBtn.Size = new Size(105, 37);
            CriarPerfilBtn.TabIndex = 9;
            CriarPerfilBtn.Text = "Criar";
            CriarPerfilBtn.UseVisualStyleBackColor = false;
            CriarPerfilBtn.Click += CriarPerfilBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 273);
            label3.Name = "label3";
            label3.Size = new Size(162, 18);
            label3.TabIndex = 10;
            label3.Text = "Nível de permissão: ";
            // 
            // CriarPerfil
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 23, 23);
            ClientSize = new Size(385, 514);
            Controls.Add(label3);
            Controls.Add(CriarPerfilBtn);
            Controls.Add(nivelPermissaoTxt);
            Controls.Add(senhaTxt);
            Controls.Add(usuarioTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(236, 236, 236);
            Margin = new Padding(4);
            Name = "CriarPerfil";
            Text = "inicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox senhaTxt;
        private TextBox usuarioTxt;
        private Label label2;
        private Label label1;
        private TextBox nivelPermissaoTxt;
        private Button CriarPerfilBtn;
        private Label label3;
    }
}