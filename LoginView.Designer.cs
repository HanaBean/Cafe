namespace Cafe
{
    partial class LoginView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            pnlMain = new Panel();
            lblVer = new Label();
            txtName = new TextBox();
            lblName = new Label();
            btnLogin = new Button();
            pnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackgroundImage = Properties.Resources.Login_Image1;
            pnlMain.BackgroundImageLayout = ImageLayout.Stretch;
            pnlMain.Controls.Add(lblVer);
            pnlMain.Location = new Point(12, 12);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(424, 279);
            pnlMain.TabIndex = 0;
            // 
            // lblVer
            // 
            lblVer.AutoSize = true;
            lblVer.BackColor = Color.Transparent;
            lblVer.Font = new Font("Arial", 10F);
            lblVer.ForeColor = Color.White;
            lblVer.Location = new Point(326, 3);
            lblVer.Name = "lblVer";
            lblVer.Size = new Size(95, 16);
            lblVer.TabIndex = 0;
            lblVer.Text = "Ver.25031901";
            // 
            // txtName
            // 
            txtName.Location = new Point(105, 303);
            txtName.Name = "txtName";
            txtName.Size = new Size(182, 23);
            txtName.TabIndex = 2;
            txtName.KeyPress += txtName_KeyPress;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(40, 307);
            lblName.Name = "lblName";
            lblName.Size = new Size(46, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name :";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(321, 302);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(114, 26);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginView
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(448, 339);
            Controls.Add(btnLogin);
            Controls.Add(txtName);
            Controls.Add(pnlMain);
            Controls.Add(lblName);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginView";
            Text = "Login";
            Load += loginView_Load;
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlMain;
        private Label lblName;
        private TextBox txtName;
        private Button btnLogin;
        private Label lblVer;
    }
}
