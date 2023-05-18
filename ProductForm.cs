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

namespace Shop_Management_System
{
    public partial class ProductForm : Form
    {
      private DBConnection Da { get; set; }
          DBConnection dBcon = new DBConnection();
      
         /*   SqlConnection conn = new SqlConnection();
        conn.ConnectionString ="Data Source = DESKTOP - HH51QAH; Initial Catalog = shop; Integrated Security = True";
conn.Open();
          */
            
        public ProductForm()
        {
            InitializeComponent();
        }
        private void getTable()
        {
            string selectQuerry = "SELECT * FROM Product";
            SqlCommand command = new SqlCommand(selectQuerry, dBcon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvProductMaintaining.DataSource = table;
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            Category cat = new Category();
            cat.Show();
            this.Hide();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            getCategory();
            getTable();

        }
        private void getCategory()
        {
            string selectQuerry = "SELECT * FROM Category";
            SqlCommand command = new SqlCommand(selectQuerry, dBcon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cmbCategory.DataSource = table;
            cmbCategory.ValueMember = "CatName";
            cmbCategory.DataSource = table;
            cmbCategory.ValueMember = "CatName";
        }
        private void clear()
        {
            txtId.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            cmbCategory.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Product VALUES(" + txtId.Text + ",'" + txtName.Text + "'," + txtPrice.Text + "," + txtQuantity.Text + ",'" + cmbCategory.Text + "')";
                SqlCommand command = new SqlCommand(insertQuery, dBcon.GetCon());
                dBcon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBcon.CloseCon();
                getTable();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "" || txtName.Text == "" || txtPrice.Text == "" || txtQuantity.Text == "")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    string updateQuery = "UPDATE Product SET ProdName='" + txtName.Text + "',ProdPrice=" + txtPrice.Text + ",ProdQty=" + txtQuantity.Text + ",ProdCat='" + cmbCategory.Text + "'WHERE ProdId=" + txtId.Text + "";
                    SqlCommand command = new SqlCommand(updateQuery, dBcon.GetCon());
                    dBcon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Product Updated Successfully", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dBcon.CloseCon();
                    getTable();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string deleteQuery = "DELETE FROM Product WHERE ProdId=" + txtId.Text + "";
                    SqlCommand command = new SqlCommand(deleteQuery, dBcon.GetCon());
                    dBcon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted Successfully", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dBcon.CloseCon();
                    getTable();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PopulateGridView(string SearchQuery = "select * from Product;")
        {
            var ds = this.Da.ExecuteQuery(SearchQuery);

            this.dgvProductMaintaining.AutoGenerateColumns = false;
            this.dgvProductMaintaining.DataSource = ds.Tables[0];
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {

            //try
            //{
                
            //    SqlCommand command = new SqlCommand(SearchQuery, dBcon.GetCon());
            //    dBcon.OpenCon();
            //    this.PopulateGridView(SearchQuery);
            //    command.ExecuteNonQuery();
            //    //MessageBox.Show("Product Deleted Successfully", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    dBcon.CloseCon();
            //    getTable();
            //}
            //catch (Exception exc)
            //{
            //    MessageBox.Show("An error has occured: " + exc.Message);
            //}

            try
            {
                string SearchQuery = "select * from Product where ProdName = '" + this.txtSearch + "';";
                this.PopulateGridView(SearchQuery);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }
       

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnSelling_Click(object sender, EventArgs e)
        {
            SellingForm selling = new SellingForm();
            selling.Show();
            this.Hide();
        }
        private void AutoIdGenerate()
        {

        }

        private void lblExitP_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void RefreshContent()
        {
            this.txtId.Clear();
            this.txtName.Clear();
            this.txtPrice.Clear();
            this.txtQuantity.Clear();

        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshContent();
        }

        private void dgvProductMaintaining_DoubleClick(object sender, EventArgs e)
        {

            txtId.Text = dgvProductMaintaining.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = dgvProductMaintaining.SelectedRows[0].Cells[1].Value.ToString();
            txtPrice.Text = dgvProductMaintaining.SelectedRows[0].Cells[2].Value.ToString();
            txtQuantity.Text = dgvProductMaintaining.SelectedRows[0].Cells[3].Value.ToString();
            cmbCategory.SelectedValue = dgvProductMaintaining.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnSeller_Click(object sender, EventArgs e)
        {
            SellerForm s = new SellerForm();
            s.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
