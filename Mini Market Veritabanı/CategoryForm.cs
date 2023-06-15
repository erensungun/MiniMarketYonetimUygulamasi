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
    public partial class CategoryForm : Form
    {
        DBConnect dBCon = new DBConnect();
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void getTable()
        {
            string selectQuerry = "SELECT * FROM Kategori";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView_category.DataSource = table;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("KategoriEkle", dBCon.GetCon());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@KatId", int.Parse(TextBox_id.Text));
                command.Parameters.AddWithValue("@KatAdi", TextBox_name.Text);
                command.Parameters.AddWithValue("@KatAciklama", TextBox_description.Text);

                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Kategori Başarıyla Eklendi!","Ekle",MessageBoxButtons.OK,MessageBoxIcon.Information);
                dBCon.CloseCon();
                getTable();
                clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            getTable();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_id.Text == "" || TextBox_name.Text == "" || TextBox_description.Text == "")
                {
                    MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    SqlCommand command = new SqlCommand("Kategoriguncelle", dBCon.GetCon());
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@KatId", int.Parse(TextBox_id.Text));
                    command.Parameters.AddWithValue("@KatAdi", TextBox_name.Text);
                    command.Parameters.AddWithValue("@KatAciklama", TextBox_description.Text);

                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    dBCon.CloseCon();

                    MessageBox.Show("Kategori Başarıyla Güncellendi!", "Güncelle", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    getTable();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataGridView_category_Click(object sender, EventArgs e)
        {
            TextBox_id.Text = DataGridView_category.SelectedRows[0].Cells[0].Value.ToString();
            TextBox_name.Text = DataGridView_category.SelectedRows[0].Cells[1].Value.ToString();
            TextBox_description.Text = DataGridView_category.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void clear()
        {
            TextBox_id.Clear();
            TextBox_name.Clear();
            TextBox_description.Clear();
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
                    if (MessageBox.Show("Kaydı silmekte emin misiniz?", "Kaydı Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SqlCommand command = new SqlCommand("KategoriSil", dBCon.GetCon());
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@KatId", int.Parse(TextBox_id.Text));

                        dBCon.OpenCon();
                        command.ExecuteNonQuery();
                        dBCon.CloseCon();

                        MessageBox.Show("Kategori Başarıyla Silindi!", "Sil", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        getTable();
                        clear();
                    }
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.DarkOrange;
        }

        private void label_logout_MouseEnter(object sender, EventArgs e)
        {
            label_logout.ForeColor = Color.Red;
        }

        private void label_logout_MouseLeave(object sender, EventArgs e)
        {
            label_logout.ForeColor = Color.DarkOrange;
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

        private void button_seller_Click(object sender, EventArgs e)
        {
            SellerForm seller = new SellerForm();
            seller.Show();
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
