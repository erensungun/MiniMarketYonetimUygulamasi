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
    public partial class SellerForm : Form
    {
        DBConnect dBCon = new DBConnect();
        public SellerForm()
        {
            InitializeComponent();
        }

        private void getTable()
        {
            string selectQuerry = "SELECT * FROM Elemanlar";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_seller.DataSource = table;
        }

        private void clear()
        {
            TextBox_id.Clear();
            TextBox_name.Clear();
            TextBox_age.Clear();
            TextBox_phone.Clear();
            TextBox_pass.Clear();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("ElemanEkle", dBCon.GetCon());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@EleId", int.Parse(TextBox_id.Text));
                command.Parameters.AddWithValue("@EleAdi", TextBox_name.Text);
                command.Parameters.AddWithValue("@EleYasi", int.Parse(TextBox_age.Text));
                command.Parameters.AddWithValue("@EleTel", TextBox_phone.Text);
                command.Parameters.AddWithValue("@EleSifre", TextBox_pass.Text);

                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Eleman Başarıyla Eklendi!", "Ekle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                getTable();
                clear();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
            getTable();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_id.Text == "" || TextBox_name.Text == "" || TextBox_age.Text == "" || TextBox_phone.Text == "" || TextBox_pass.Text == "")
                {
                    MessageBox.Show("Hatalı bilgi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    SqlCommand command = new SqlCommand("Elemanguncelle", dBCon.GetCon());
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@EleId", int.Parse(TextBox_id.Text));
                    command.Parameters.AddWithValue("@EleAdi", TextBox_name.Text);
                    command.Parameters.AddWithValue("@EleYas", int.Parse(TextBox_age.Text));
                    command.Parameters.AddWithValue("@EleTel", TextBox_phone.Text);
                    command.Parameters.AddWithValue("@EleSifre", TextBox_pass.Text);

                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    dBCon.CloseCon();

                    MessageBox.Show("Eleman Başarıyla Güncellendi!", "Güncelle", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    getTable();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView_seller_Click(object sender, EventArgs e)
        {
            TextBox_id.Text = dataGridView_seller.SelectedRows[0].Cells[0].Value.ToString();
            TextBox_name.Text = dataGridView_seller.SelectedRows[0].Cells[1].Value.ToString();
            TextBox_age.Text = dataGridView_seller.SelectedRows[0].Cells[2].Value.ToString();
            TextBox_phone.Text = dataGridView_seller.SelectedRows[0].Cells[3].Value.ToString();
            TextBox_pass.Text = dataGridView_seller.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_id.Text == "")
                {
                    MessageBox.Show("Hatalı bilgi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    if ((MessageBox.Show("Kaydı silmekte eminmisin?", "Kaydı Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)){
                        SqlCommand command = new SqlCommand("ElemanSil", dBCon.GetCon());
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@EleId", int.Parse(TextBox_id.Text));

                        dBCon.OpenCon();
                        command.ExecuteNonQuery();
                        dBCon.CloseCon();

                        MessageBox.Show("Eleman Başarıyla Silindi!", "Sil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        getTable();
                        clear();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label_logout_MouseEnter(object sender, EventArgs e)
        {
            label_logout.ForeColor = Color.Red;
        }

        private void label_logout_MouseLeave(object sender, EventArgs e)
        {
            label_logout.ForeColor = Color.DarkOrange;
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_logout.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_logout.ForeColor = Color.DarkOrange;
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_logout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void button_product_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            product.Show();
            this.Hide();
        }

        private void button_category_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.Show();
            this.Hide();
        }

        private void button_selling_Click(object sender, EventArgs e)
        {
            SellingForm selling = new SellingForm();
            selling.Show();
            this.Hide();
        }
    }
}
