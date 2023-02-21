namespace Demo
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
            this.components = new System.ComponentModel.Container();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblWin = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.errorProviderUser = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPass = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_Help = new System.Windows.Forms.Button();
            this.helpProviderLogin = new System.Windows.Forms.HelpProvider();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPass)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUser.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lblUser.Location = new System.Drawing.Point(40, 142);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(211, 46);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "User Name:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblPass.Location = new System.Drawing.Point(40, 258);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(197, 46);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "Passwrord:";
            // 
            // txtUser
            // 
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUser.Location = new System.Drawing.Point(287, 149);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(450, 52);
            this.txtUser.TabIndex = 2;
            this.txtUser.Validating += new System.ComponentModel.CancelEventHandler(this.txtUser_Validating);
            // 
            // txtPass
            // 
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPass.Location = new System.Drawing.Point(287, 263);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(450, 52);
            this.txtPass.TabIndex = 3;
            this.txtPass.Validating += new System.ComponentModel.CancelEventHandler(this.txtPass_Validating);
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWin.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblWin.Location = new System.Drawing.Point(311, 15);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(404, 68);
            this.lblWin.TabIndex = 4;
            this.lblWin.Text = "WINFORM_07";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(812, 258);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(162, 54);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // errorProviderUser
            // 
            this.errorProviderUser.BlinkRate = 300;
            this.errorProviderUser.ContainerControl = this;
            // 
            // errorProviderPass
            // 
            this.errorProviderPass.BlinkRate = 300;
            this.errorProviderPass.ContainerControl = this;
            // 
            // btn_Help
            // 
            this.btn_Help.BackColor = System.Drawing.Color.Red;
            this.btn_Help.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Help.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Help.Location = new System.Drawing.Point(812, 147);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(162, 56);
            this.btn_Help.TabIndex = 7;
            this.btn_Help.Text = "Show Help";
            this.btn_Help.UseVisualStyleBackColor = false;
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Red;
            this.progressBar1.ForeColor = System.Drawing.Color.Lime;
            this.progressBar1.Location = new System.Drawing.Point(287, 376);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(449, 29);
            this.progressBar1.Step = 50;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(994, 600);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btn_Help);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Dang Nhap";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblUser;
        private Label lblPass;
        private TextBox txtUser;
        private TextBox txtPass;
        private Label lblWin;
        private Button btnLogin;
        private ErrorProvider errorProviderUser;
        private ErrorProvider errorProviderPass;
        private Button btn_Help;
        private HelpProvider helpProviderLogin;
        private System.Windows.Forms.Timer timer1;
        private ProgressBar progressBar1;
    }
}