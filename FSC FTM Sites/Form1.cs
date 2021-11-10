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
using Excel = Microsoft.Office.Interop.Excel;
namespace FSC_FTM_Sites
{
    public partial class Form1 : Form
    {

        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

        public string ID { get; set; }
        public string SiteName { get; set; }
        public string FullName { get; set; }
        public string BusinessGroup { get; set; }
        public string Area { get; set; }
         public string UserID { get; set; }
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
            if (button2.Text == "&Add Site")
            {
                ID = "";
                SiteName = "";
                BusinessGroup = "";
                Area = "";
                UserID = "";
            }

        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            if (dgList1.RowCount > 0)
            {
                button2.Text = "&Add Site";
            }
            else
            {
                button2.Text = "&Edit Site";
            }

        }

        private void DgList1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            if(button2.Text == "&Add Site")
            {
                  frm_site fsite = new frm_site(this);
                  fsite.ShowDialog();
            }
            else if (button2.Text == "&Edit Site")
            {
                ID = ID;
                UserID = UserID;
                SiteName = SiteName;
                BusinessGroup = BusinessGroup;
                Area = Area;
                FullName = FullName;
                frm_site fsite = new frm_site(this);
                fsite.ShowDialog();
            }
          
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            LoadData();
            ID = "";
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            string message = "Do you want to delete this site?";
            string title = "Prompt";
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

      

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            (dgList1.DataSource as DataTable).DefaultView.RowFilter = string.Format("business_group LIKE '%{0}%' OR fullname LIKE '%{0}%' OR site_name LIKE '%{0}%' OR codename LIKE '%{0}%' OR area LIKE '%{0}%'", searchTextBox.Text);
            lblcount.Text = dgList1.Rows.Count.ToString();
        }

        private void DgList1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgList1.Rows[e.RowIndex];

                ID = row.Cells["siteid"].Value.ToString();
                UserID = row.Cells["user_id"].Value.ToString();
                BusinessGroup = row.Cells["business_group"].Value.ToString();
                SiteName = row.Cells["site_name"].Value.ToString();
                Area = row.Cells["area"].Value.ToString();
                FullName = row.Cells["fullname"].Value.ToString();
                button2.Text = "&Edit Site";

            }
            else
            {
                button2.Text = "&Add Site";
            }
        }

        private void dgList1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            button2.Text = "&Add Site";
            ID = "";
        }

        private void copyAlltoClipboard()
        {
            dgList1.SelectAll();
            DataObject dataObj = dgList1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void btnexport_Click(object sender, EventArgs e)
        {
            //copyAlltoClipboard();
            //Microsoft.Office.Interop.Excel.Application xlexcel;
            //Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            //Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            //object misValue = System.Reflection.Missing.Value;
            //xlexcel = new Excel.Application();
            //xlexcel.Visible = true;
            //xlWorkBook = xlexcel.Workbooks.Add(misValue);
            //xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            //Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            //CR.Select();
            //xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            //for (int i = 1; i < dgList1.Columns.Count + 1; i++)
            //{
            //    xlWorkSheet.Cells[1, i] = dgList1.Columns[i - 1].HeaderText;
            //}


            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from Gridview";
            // storing header part in Excel  
            for (int i = 1; i < dgList1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgList1.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dgList1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgList1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgList1.Rows[i].Cells[j].Value.ToString();
                }
            }
        }
    }
}
