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
using DGVPrinterHelper;

namespace Mini_Market_Veritabanı
{
    public partial class SellingForm : Form
    {
        public string SellerName { get; set; }
        DBConnect dBCon = new DBConnect();
        DGVPrinter printer = new DGVPrinter();
        public SellingForm()
        {
            InitializeComponent();
        }

        private void getTable()
        {
            string selectQuerry = "SELECT UrunAdi, UrunFiyat, UrunMiktar FROM Urunler";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView_product.DataSource = table;
        }

        private void getSellTable()
        {
            string selectQuerry = "SELECT * FROM Fatura";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView_sellList.DataSource = table;
        }

        private void SellingForm_Load(object sender, EventArgs e)
        {
            label_date.Text = DateTime.Today.ToShortDateString();
            label_seller.Text = LoginForm.sellerName;
            getTable();
            getCategory();
            getSellTable();
        }

        private void DataGridView_product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBox_name.Text = DataGridView_product.SelectedRows[0].Cells[0].Value.ToString();
            TextBox_price.Text = DataGridView_product.SelectedRows[0].Cells[1].Value.ToString();
        }

        float grandTotal = 0, n = 0;

        

        private void button_print_Click(object sender, EventArgs e)
        {
            printer.Title = "Ecem Market Satış Listesi";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Deneme Footer Alanı";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(DataGridView_sellList);
        }


        private void button_addOrder_Click(object sender, EventArgs e)
        {
            if (TextBox_name.Text == "" || TextBox_qty.Text == "")
            {
                MessageBox.Show("Hatalı Giriş", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                float Total = Convert.ToSingle(TextBox_price.Text) * float.Parse(TextBox_qty.Text);
                DataGridViewRow addRow = new DataGridViewRow();
                addRow.CreateCells(dataGridView_order);
                addRow.Cells[0].Value = ++n;
                addRow.Cells[1].Value = TextBox_name.Text;
                addRow.Cells[2].Value = TextBox_price.Text;
                addRow.Cells[3].Value = TextBox_qty.Text;
                addRow.Cells[4].Value = Total;
                dataGridView_order.Rows.Add(addRow);
                grandTotal += Total;
                label_amount.Text = grandTotal + " TL";
            }
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

        private void button_refresh_Click(object sender, EventArgs e)
        {
            getTable();
        }
        private void getCategory()
        {
            string selectQuery = "SELECT * FROM Kategori";
            SqlCommand command = new SqlCommand(selectQuery, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBox_category.DataSource = table;
            comboBox_category.ValueMember = "KatId";
            comboBox_category.DisplayMember = "KatAdi";
        }

        private void comboBox_category_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int categoryId = Convert.ToInt32(comboBox_category.SelectedValue);
            string selectQuery = "SELECT UrunAdi, UrunFiyat, UrunMiktar FROM Urunler WHERE KatId = @CategoryId";
            SqlCommand command = new SqlCommand(selectQuery, dBCon.GetCon());
            command.Parameters.AddWithValue("@CategoryId", categoryId);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView_product.DataSource = table;
        }



        private int GetSellerId(string sellerName)
        {
            string query = "SELECT EleId FROM Elemanlar WHERE EleAdi = @SellerName";
            SqlCommand command = new SqlCommand(query, dBCon.GetCon());
            command.Parameters.AddWithValue("@SellerName", sellerName);
            dBCon.OpenCon();
            int sellerId = (int)command.ExecuteScalar();
            dBCon.CloseCon();
            return sellerId;
        }

        private void comboBox_category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string totalFormatted = string.Format("{0:0.00}", grandTotal);
                int sellerId = GetSellerId(label_seller.Text); // Satıcının ID'sini al
                SqlCommand command = new SqlCommand("FaturaEkle", dBCon.GetCon());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@FatId", int.Parse(TextBox_id.Text));
                command.Parameters.AddWithValue("@ElemanId", sellerId);
                command.Parameters.AddWithValue("@FatTarih", label_date.Text);
                command.Parameters.AddWithValue("@FatFiyat", decimal.Parse(totalFormatted));

                dBCon.OpenCon();
                command.ExecuteNonQuery();
                dBCon.CloseCon();

                MessageBox.Show("Satış Başarıyla Eklendi!", "Ekle", MessageBoxButtons.OK, MessageBoxIcon.Information);

                getSellTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
