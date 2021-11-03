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
    public partial class frm_site : Form
    {
        public frm_site()
        {
            InitializeComponent();
        }
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        //set connection
        public string userid;
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
            string CommandText = "select id, fullname from tbl_user";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            comboBox1.DataSource = DT;
            comboBox1.ValueMember = "id";
            comboBox1.DisplayMember = "fullname";
            SetConnection();
        }
        private void Frm_site_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string accountName = comboBox1.SelectedValue.ToString();
                userid = accountName;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void addsite()
        {
            string txtQuery = "insert into tbl_site (user_id, site_name,business_group, area)values" +
              "('" + Convert.ToInt16(userid) + "', '" + txtsitename.Text + "', '" + txtbg.Text + "','" + txtarea.Text + "')";
            ExecuteQuery(txtQuery);
            cleartxt();

            Form1 frm = new Form1();
            frm.dgList1.Refresh();
        }
        private void Btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                addsite();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void cleartxt()
        {
            txtarea.Clear();
            txtbg.Clear();
            txtsitename.Clear();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtarea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                string message = "Do you want to Add More site?";
                string title = "Add";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    addsite();
                    txtsitename.Focus();
                }
                else
                {
                    this.Close();
                }
            }
           
        }

      
    }
}
