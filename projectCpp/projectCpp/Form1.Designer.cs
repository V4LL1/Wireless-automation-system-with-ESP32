namespace projectCpp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            usuarioTxt = new TextBox();
            senhaTxt = new TextBox();
            entrarBtn = new Button();
            criarBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(17, 17, 17);
            label1.Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(236, 236, 236);
            label1.Location = new Point(61, 61);
            label1.Name = "label1";
            label1.Size = new Size(75, 18);
            label1.TabIndex = 0;
            label1.Text = "Usuário:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(17, 17, 17);
            label2.Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(236, 236, 236);
            label2.Location = new Point(61, 167);
            label2.Name = "label2";
            label2.Size = new Size(61, 18);
            label2.TabIndex = 1;
            label2.Text = "Senha:";
            // 
            // usuarioTxt
            // 
            usuarioTxt.BackColor = Color.FromArgb(236, 236, 236);
            usuarioTxt.Location = new Point(61, 93);
            usuarioTxt.Name = "usuarioTxt";
            usuarioTxt.Size = new Size(238, 23);
            usuarioTxt.TabIndex = 2;
            // 
            // senhaTxt
            // 
            senhaTxt.BackColor = Color.FromArgb(236, 236, 236);
            senhaTxt.Location = new Point(61, 201);
            senhaTxt.Name = "senhaTxt";
            senhaTxt.Size = new Size(238, 23);
            senhaTxt.TabIndex = 3;
            // 
            // entrarBtn
            // 
            entrarBtn.BackColor = Color.FromArgb(236, 236, 236);
            entrarBtn.Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            entrarBtn.Location = new Point(194, 249);
            entrarBtn.Name = "entrarBtn";
            entrarBtn.Size = new Size(105, 37);
            entrarBtn.TabIndex = 4;
            entrarBtn.Text = "Entrar";
            entrarBtn.UseVisualStyleBackColor = false;
            entrarBtn.Click += entrarBtn_Click;
            // 
            // criarBtn
            // 
            criarBtn.BackColor = Color.FromArgb(236, 236, 236);
            criarBtn.Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            criarBtn.Location = new Point(194, 303);
            criarBtn.Name = "criarBtn";
            criarBtn.Size = new Size(105, 37);
            criarBtn.TabIndex = 5;
            criarBtn.Text = "Criar perfil";
            criarBtn.UseVisualStyleBackColor = false;
            criarBtn.Click += criarBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 23, 23);
            ClientSize = new Size(385, 371);
            Controls.Add(criarBtn);
            Controls.Add(entrarBtn);
            Controls.Add(senhaTxt);
            Controls.Add(usuarioTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(23, 23, 23);
            Name = "Form1";
            Text = "Autenticação";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox usuarioTxt;
        private TextBox senhaTxt;
        private Button entrarBtn;
        private Button criarBtn;
    }
}
