using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mini_Market_Veritabanı
{
    public partial class LoginForm : Form
    {
        DBConnect dBCon = new DBConnect();
        public static string sellerName;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label_exit_MouseEnter_1(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave_1(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.DarkOrange;
        }

        private void label_clear_MouseEnter(object sender, EventArgs e)
        {
            label_clear.ForeColor = Color.Red;
        }

        private void label_clear_MouseLeave(object sender, EventArgs e)
        {
            label_clear.ForeColor = Color.Gold;
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_clear_Click(object sender, EventArgs e)
        {
            TextBox_username.Clear();
            TextBox_password.Clear();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            TextBox_username.Select();
        }

        private void Button_login_Click(object sender, EventArgs e)
        {
            if (TextBox_username.Text == "" || TextBox_password.Text == "")
            {
                MessageBox.Show("Lütfen Kullanıcı Adı ve Parola Giriniz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (comboBox_role.SelectedIndex > -1)
                {
                    if (comboBox_role.SelectedItem.ToString() == "ADMIN")
                    {
                        if (TextBox_username.Text == "Admin" && TextBox_password.Text == "Admin123")
                        {
                            ProductForm product = new ProductForm();
                            product.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("(Admin) Hatalı Giriş Yapıldı!", "Hatalı Giriş!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        string selectQuery = "SELECT * FROM Elemanlar WHERE EleAdi='" + TextBox_username.Text + "' AND EleSifre='" + TextBox_password.Text + "'";
                        SqlCommand command = new SqlCommand(selectQuery, dBCon.GetCon());
                        dBCon.OpenCon();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            reader.Read();
                            sellerName = TextBox_username.Text;
                            SellingForm selling = new SellingForm();
                            selling.SellerName = sellerName;
                            selling.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Yanlış Kullanıcı Adı veya Parola", "Hatalı Giriş!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        reader.Close();
                        dBCon.CloseCon();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Rol Seçiniz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
