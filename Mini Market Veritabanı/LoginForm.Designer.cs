
namespace Mini_Market_Veritabanı
{
    partial class LoginForm
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
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.gunaCircleButton1 = new Guna.UI.WinForms.GunaCircleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox_username = new Guna.UI.WinForms.GunaTextBox();
            this.Button_login = new Guna.UI.WinForms.GunaButton();
            this.TextBox_password = new Guna.UI.WinForms.GunaTextBox();
            this.label_clear = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_role = new System.Windows.Forms.ComboBox();
            this.label_exit = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Gold;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(28, 185);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(139, 129);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // gunaCircleButton1
            // 
            this.gunaCircleButton1.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton1.AnimationSpeed = 0.03F;
            this.gunaCircleButton1.BaseColor = System.Drawing.Color.Gold;
            this.gunaCircleButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton1.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton1.Image = null;
            this.gunaCircleButton1.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaCircleButton1.Location = new System.Drawing.Point(-276, -19);
            this.gunaCircleButton1.Name = "gunaCircleButton1";
            this.gunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.Gold;
            this.gunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaCircleButton1.OnHoverImage = null;
            this.gunaCircleButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.Size = new System.Drawing.Size(532, 439);
            this.gunaCircleButton1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(281, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(281, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(451, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "Giriş Yap";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextBox_username
            // 
            this.TextBox_username.BackColor = System.Drawing.Color.Transparent;
            this.TextBox_username.BaseColor = System.Drawing.Color.White;
            this.TextBox_username.BorderColor = System.Drawing.Color.Silver;
            this.TextBox_username.BorderSize = 0;
            this.TextBox_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_username.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBox_username.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBox_username.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBox_username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_username.Location = new System.Drawing.Point(419, 146);
            this.TextBox_username.Name = "TextBox_username";
            this.TextBox_username.PasswordChar = '\0';
            this.TextBox_username.Radius = 15;
            this.TextBox_username.SelectedText = "";
            this.TextBox_username.Size = new System.Drawing.Size(160, 30);
            this.TextBox_username.TabIndex = 1;
            this.TextBox_username.TextChanged += new System.EventHandler(this.TextBox_username_TextChanged);
            // 
            // Button_login
            // 
            this.Button_login.AnimationHoverSpeed = 0.07F;
            this.Button_login.AnimationSpeed = 0.03F;
            this.Button_login.BackColor = System.Drawing.Color.Transparent;
            this.Button_login.BaseColor = System.Drawing.Color.Gold;
            this.Button_login.BorderColor = System.Drawing.Color.Black;
            this.Button_login.BorderSize = 2;
            this.Button_login.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Button_login.FocusedColor = System.Drawing.Color.Empty;
            this.Button_login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button_login.ForeColor = System.Drawing.Color.Black;
            this.Button_login.Image = ((System.Drawing.Image)(resources.GetObject("Button_login.Image")));
            this.Button_login.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Button_login.ImageSize = new System.Drawing.Size(20, 20);
            this.Button_login.Location = new System.Drawing.Point(348, 247);
            this.Button_login.Name = "Button_login";
            this.Button_login.OnHoverBaseColor = System.Drawing.Color.Goldenrod;
            this.Button_login.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Button_login.OnHoverForeColor = System.Drawing.Color.White;
            this.Button_login.OnHoverImage = null;
            this.Button_login.OnPressedColor = System.Drawing.Color.Black;
            this.Button_login.Radius = 15;
            this.Button_login.Size = new System.Drawing.Size(140, 42);
            this.Button_login.TabIndex = 4;
            this.Button_login.Text = "Giriş Yap";
            this.Button_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Button_login.Click += new System.EventHandler(this.Button_login_Click);
            // 
            // TextBox_password
            // 
            this.TextBox_password.BackColor = System.Drawing.Color.Transparent;
            this.TextBox_password.BaseColor = System.Drawing.Color.White;
            this.TextBox_password.BorderColor = System.Drawing.Color.Silver;
            this.TextBox_password.BorderSize = 0;
            this.TextBox_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_password.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBox_password.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBox_password.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBox_password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_password.Location = new System.Drawing.Point(419, 185);
            this.TextBox_password.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_password.Name = "TextBox_password";
            this.TextBox_password.PasswordChar = '●';
            this.TextBox_password.Radius = 15;
            this.TextBox_password.SelectedText = "";
            this.TextBox_password.Size = new System.Drawing.Size(160, 30);
            this.TextBox_password.TabIndex = 2;
            this.TextBox_password.UseSystemPasswordChar = true;
            this.TextBox_password.TextChanged += new System.EventHandler(this.TextBox_username_TextChanged);
            // 
            // label_clear
            // 
            this.label_clear.AutoSize = true;
            this.label_clear.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_clear.ForeColor = System.Drawing.Color.Gold;
            this.label_clear.Location = new System.Drawing.Point(379, 306);
            this.label_clear.Name = "label_clear";
            this.label_clear.Size = new System.Drawing.Size(79, 25);
            this.label_clear.TabIndex = 1;
            this.label_clear.Text = "Temizle";
            this.label_clear.Click += new System.EventHandler(this.label_clear_Click);
            this.label_clear.MouseEnter += new System.EventHandler(this.label_clear_MouseEnter);
            this.label_clear.MouseLeave += new System.EventHandler(this.label_clear_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gold;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(16, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ecem Market";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gold;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(4, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Yönetim Uygulaması";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox_role
            // 
            this.comboBox_role.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_role.ForeColor = System.Drawing.Color.Gold;
            this.comboBox_role.FormattingEnabled = true;
            this.comboBox_role.Items.AddRange(new object[] {
            "ADMIN",
            "ELEMAN"});
            this.comboBox_role.Location = new System.Drawing.Point(419, 108);
            this.comboBox_role.Name = "comboBox_role";
            this.comboBox_role.Size = new System.Drawing.Size(160, 33);
            this.comboBox_role.TabIndex = 6;
            this.comboBox_role.Text = "Rol Seçiniz";
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_exit.ForeColor = System.Drawing.Color.DarkOrange;
            this.label_exit.Location = new System.Drawing.Point(611, 9);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(27, 30);
            this.label_exit.TabIndex = 7;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseEnter += new System.EventHandler(this.label_exit_MouseEnter_1);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave_1);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.label_exit);
            this.Controls.Add(this.comboBox_role);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.Button_login);
            this.Controls.Add(this.TextBox_password);
            this.Controls.Add(this.TextBox_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_clear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaCircleButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox TextBox_username;
        private Guna.UI.WinForms.GunaButton Button_login;
        private Guna.UI.WinForms.GunaTextBox TextBox_password;
        private System.Windows.Forms.Label label_clear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_role;
        private System.Windows.Forms.Label label_exit;
    }
}

