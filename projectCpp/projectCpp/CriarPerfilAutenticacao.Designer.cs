namespace projectCpp
{
    partial class CriarPerfilAutenticacao
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
            senhaAdminTxt = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // senhaAdminTxt
            // 
            senhaAdminTxt.BackColor = Color.FromArgb(236, 236, 236);
            senhaAdminTxt.Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            senhaAdminTxt.Location = new Point(127, 174);
            senhaAdminTxt.Name = "senhaAdminTxt";
            senhaAdminTxt.Size = new Size(238, 25);
            senhaAdminTxt.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(236, 236, 236);
            label1.Location = new Point(127, 134);
            label1.Name = "label1";
            label1.Size = new Size(202, 18);
            label1.TabIndex = 1;
            label1.Text = "Senha de administrador: ";
            // 
            // CriarPerfilAutenticacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 23, 23);
            ClientSize = new Size(495, 339);
            Controls.Add(label1);
            Controls.Add(senhaAdminTxt);
            Name = "CriarPerfilAutenticacao";
            Text = "Criar Perfil";
            Load += CriarPerfilAutenticacao_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox senhaAdminTxt;
        private Label label1;
    }
}