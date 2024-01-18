using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        private const string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SalesDatabase.accdb";

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Butona Týklandý!");

            if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
            {
                using (AdministratorForm adminForm = new AdministratorForm())
                {
                    adminForm.ShowDialog();
                }
            }
            else
            {
                using (CustomerForm customerForm = new CustomerForm())
                {
                    customerForm.ShowDialog();
                }
            }
        }
    }

    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(MainForm.connectionString))
                {
                    connection.Open();

                    string query = "SELECT ProductName FROM Products";
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        foreach (DataRow row in dataTable.Rows)
                        {
                            lstProducts.Items.Add(row["ProductName"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }

    public partial class AdministratorForm : Form
    {
        public AdministratorForm()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(MainForm.connectionString))
                {
                    connection.Open();

                    string query = "SELECT ProductID, ProductName, Price FROM Products";
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dgvProducts.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Product Updated!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Product Deleted!");
        }
    }
}
