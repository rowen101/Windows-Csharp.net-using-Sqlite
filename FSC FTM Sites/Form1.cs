using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
namespace FSC_FTM_Sites
{
    public partial class Form1 : Form
    {
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }
      

        //set connection
        private void SetConnection()
        {
            sql_con = new SQLiteConnection
                ("Data Source=db.db;Version=3;New=False;Compress=True;");
        }

        //set executequery
        private void ExecuteQuery(string txtQuery)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }

        //set loadDB
        private void LoadData()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select * from tbl_ItDtS";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView1.DataSource = DT;
            SetConnection();
        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Btnadd_Click(object sender, EventArgs e)
        {
            string txtQuery = "insert into tbl_ItDtS (name)values('" + txtname.Text + "')";
            ExecuteQuery(txtQuery);
            LoadData();
        }

        private void Btnedit_Click(object sender, EventArgs e)
        {
            string txtQuery = "update tbl_ItDtS set name='" + txtname.Text + "' where id='" + label2.Text + "'";
            ExecuteQuery(txtQuery);
            LoadData();
        }

        private void Btndel_Click(object sender, EventArgs e)
        {
            string txtQuery = "delete from tbl_ItDtS where id='" + label2.Text + "'";
            ExecuteQuery(txtQuery);
            LoadData();
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
