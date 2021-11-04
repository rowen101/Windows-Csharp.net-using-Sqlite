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
    public partial class frm_adduser : Form
    {
        public frm_adduser()
        {
            InitializeComponent();
        }
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();



        string msgmessage;
        string msgtitle;
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
            string CommandText = "select * from tbl_user";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            //dataGridView1.DataSource = DT;
            dgList1.DataSource = DT;
            SetConnection();
        }

      

        private void Frm_adduser_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void clear()
        {
            txtfullname.Clear();
            txtcodename.Clear();
            lblid.Text = "";
        }
        private void adduser()
        {
            string txtQuery = "insert into tbl_user (fullname, codename)values('" + txtfullname.Text + "', '" + txtcodename.Text + "')";
            ExecuteQuery(txtQuery);
            LoadData();
            clear();
        }
        private void Userfunc()
        {
            try
            {
                if (txtfullname.Text == "" || txtcodename.Text == "")
                {
                    msgmessage = "Field is empty!";
                    msgtitle = "Prompt";
                    MessageBox.Show(msgmessage, msgtitle);
                }
                else
                {
                    string message = "Do you want to Add More User?";
                    string title = "Add";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {

                        adduser();
                        txtfullname.Focus();
                    }
                    else
                    {
                        adduser();
                        this.Close();
                    }

                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void Btnadd_Click(object sender, EventArgs e)
        {

            Userfunc();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtfullname.Text == "" || txtcodename.Text == "")
                {
                    msgmessage = "Select User you want to delete!";
                    msgtitle = "Prompt";
                    MessageBox.Show(msgmessage, msgtitle);
                }
                else
                {
                    string txtQuery = "delete from tbl_user where id='" + lblid.Text + "'";
                    ExecuteQuery(txtQuery);
                    LoadData();
                    clear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                  
        }

        private void DgList1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgList1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgList1.CurrentRow.Selected = true;
                lblid.Text = dgList1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                txtfullname.Text = dgList1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtcodename.Text = dgList1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
               
                
            }
        }

        private void Btnedit_Click_1(object sender, EventArgs e)
        {
           
            try
            {
                if (txtfullname.Text == "" || txtcodename.Text == "")
                {
                    msgmessage = "Field is empty!";
                    msgtitle = "Prompt";
                    MessageBox.Show(msgmessage, msgtitle);
                }
                else
                {
                    string txtQuery = "update tbl_user set fullname='" + txtfullname.Text + "', codename='" + txtcodename.Text + "' where id='" + lblid.Text + "'";
                    ExecuteQuery(txtQuery);
                    LoadData();
                    clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtcodename_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Userfunc();
            }
        }
    }
}
