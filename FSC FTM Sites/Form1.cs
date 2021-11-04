﻿using System;
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

        string ID;
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
        public void LoadData()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            //string CommandText = "select * from tbl_site";
            string CommandText = "select tbl_site.siteid, tbl_user.codename,  tbl_site.business_group, tbl_site.area,  tbl_site.user_id, tbl_user.fullname, tbl_site.site_name from tbl_site inner join " +
                "tbl_user on tbl_site.user_id = tbl_user.id order by tbl_site.siteid desc";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dgList1.DataSource = DT;
            SetConnection();
            lblcount.Text = dgList1.RowCount.ToString();
            grideview();
        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();

        }

      

    

        private void DgList1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgList1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgList1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgList1.CurrentRow.Selected = true;
                ID = dgList1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
              //  ID = row.Cells["siteid"].Value.ToString();



            }
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = this.dgList1.Rows[e.RowIndex];

            //    ID = row.Cells["id"].Value.ToString();
             
            //}
           

        }
        private void grideview()
        {
            if (dgList1.RowCount > 0 )
            {
                button2.Text = "&Add Site";
            }
            else
            {
                button2.Text = "&Edit Site";
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            frm_adduser fuser = new frm_adduser();
            fuser.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            frm_site fsite = new frm_site(this);
            fsite.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            string message = "Do you want to delete this site?";
            string title = "Delete";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                string txtQuery = "delete from tbl_site where siteid='" + ID + "'";
                ExecuteQuery(txtQuery);
                LoadData();
            }
            else
            {
                // Do something  
            }
           
        }

        private void DgList1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(dgList1.RowCount > 0)
            {
                if (dgList1.RowCount > 0)
                {
                      button2.Text = "&Edit Site";
                }
                else
                {                
                    button2.Text = "&Add Site";
                }
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            (dgList1.DataSource as DataTable).DefaultView.RowFilter = string.Format("business_group LIKE '%{0}%' OR fullname LIKE '%{0}%' OR site_name LIKE '%{0}%' OR codename LIKE '%{0}%' OR area LIKE '%{0}%'", searchTextBox.Text);
        }

        private void DgList1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgList1.Rows[e.RowIndex];

                ID = row.Cells["siteid"].Value.ToString();

            }
        }
    }
}
