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
    public partial class ProductForm : Form
    {
        DBConnect dBCon = new DBConnect();

        public ProductForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.Show();
            this.Hide();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            getCategory();
            getTable();
        }

        private void getTable()
        {
            string selectQuerry = "SELECT * FROM Urunler";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_product.DataSource = table;
        }

        private void clear()
        {
            TextBox_id.Clear();
            TextBox_Kat.Clear();
            TextBox_name.Clear();
            TextBox_price.Clear();
            TextBox_qty.Clear();
        }
        


        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("UrunEkle", dBCon.GetCon());
                command.CommandType = CommandType.StoredProcedure;


                command.Parameters.AddWithValue("@UrunId", int.Parse(TextBox_id.Text));
                command.Parameters.AddWithValue("@KatId", int.Parse(TextBox_Kat.Text));
                command.Parameters.AddWithValue("@UrunAdi", TextBox_name.Text);
                command.Parameters.AddWithValue("@UrunFiyat", float.Parse(TextBox_price.Text));
                command.Parameters.AddWithValue("@UrunMiktar", int.Parse(TextBox_qty.Text));

                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Ürün Başarıyla Eklendi!", "Ekle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                getTable();
                clear();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_id.Text == "" || TextBox_Kat.Text == "" || TextBox_name.Text == "" || TextBox_price.Text == "")
                {
                    MessageBox.Show("Hatalı bilgi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    SqlCommand command = new SqlCommand("Urunguncelle", dBCon.GetCon());
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UrunId", int.Parse(TextBox_id.Text));
                    command.Parameters.AddWithValue("@UrunAdi", TextBox_name.Text);
                    command.Parameters.AddWithValue("@UrunFiyat", float.Parse(TextBox_price.Text));
                    command.Parameters.AddWithValue("@UrunMiktar", int.Parse(TextBox_qty.Text));
                    command.Parameters.AddWithValue("@KatId", int.Parse(TextBox_Kat.Text));

                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    dBCon.CloseCon();

                    MessageBox.Show("Ürün Başarıyla Güncellendi!", "Güncelle", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    getTable();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView_product_Click(object sender, EventArgs e)
        {
            TextBox_id.Text = dataGridView_product.SelectedRows[0].Cells[0].Value.ToString();
            TextBox_Kat.Text = dataGridView_product.SelectedRows[0].Cells[1].Value.ToString();
            TextBox_name.Text = dataGridView_product.SelectedRows[0].Cells[2].Value.ToString();
            TextBox_price.Text = dataGridView_product.SelectedRows[0].Cells[3].Value.ToString();
            TextBox_qty.Text = dataGridView_product.SelectedRows[0].Cells[4].Value.ToString();
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
                        SqlCommand command = new SqlCommand("UrunSil", dBCon.GetCon());
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UrunId", int.Parse(TextBox_id.Text));

                        dBCon.OpenCon();
                        command.ExecuteNonQuery();
                        dBCon.CloseCon();

                        MessageBox.Show("Ürün Başarıyla Silindi!", "Sil", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void button_refresh_Click(object sender, EventArgs e)
        {
            getTable();
        }

        private void getCategory()
        {
            string selectQuery = "SELECT KatId, KatAdi FROM Kategori";
            SqlCommand command = new SqlCommand(selectQuery, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBox_search.DataSource = table;
            comboBox_search.ValueMember = "KatId";
            comboBox_search.DisplayMember = "KatAdi";
        }
        private void comboBox_search_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int categoryId = Convert.ToInt32(comboBox_search.SelectedValue);
            string selectQuery = "SELECT * FROM Urunler WHERE KatId = @CategoryId";
            SqlCommand command = new SqlCommand(selectQuery, dBCon.GetCon());
            command.Parameters.AddWithValue("@CategoryId", categoryId);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_product.DataSource = table;
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

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_selling_Click(object sender, EventArgs e)
        {
            SellingForm selling = new SellingForm();
            selling.Show();
            this.Hide();
        }

        private void button_seller_Click(object sender, EventArgs e)
        {
            SellerForm seller = new SellerForm();
            seller.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_search_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
