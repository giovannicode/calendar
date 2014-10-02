using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
            loadBooks();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
     
        }

        private void loadBooks()
        {
            /*String tableName = "table";
            DataSet dataset = new DataSet();
            List<String> r = DB.loadData();
            dataset.Tables.Add(tableName);
            dataset.Tables[tableName].Columns.Add("First Name");
            dataset.Tables[tableName].Columns.Add("Last Name");
            dataset.Tables[tableName].Columns.Add("Age");

            foreach (String s in r)
            {
                string[] sa = s.Split(",".ToCharArray());
                dataset.Tables[tableName].Rows.Add(sa);

            }
            this.dataGridView1.DataSource = dataset.Tables[0].DefaultView;*/
            connect("Server=localhost; Port=3306; userid=root;password=password;database=clothescom");
        }

        public void connect(String connString)
        {
            MySqlConnection mysqlCon = new MySqlConnection(connString);
            mysqlCon.Open();

            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "SELECT * from shoes";
            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, mysqlCon);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;

            DataGridView dgView = new DataGridView();
            this.dataGridView1.DataSource = bSource;
        }
    }
}
