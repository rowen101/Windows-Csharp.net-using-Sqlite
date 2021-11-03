namespace FSC_FTM_Sites
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgList1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblcount = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.siteid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.business_group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.site_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgList1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.Location = new System.Drawing.Point(524, 18);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(290, 26);
            this.searchTextBox.TabIndex = 5;
            this.searchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 52);
            this.button1.TabIndex = 8;
            this.button1.Text = "Immediate Support";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dgList1
            // 
            this.dgList1.AllowUserToAddRows = false;
            this.dgList1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dgList1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgList1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgList1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgList1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgList1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgList1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.siteid,
            this.user_id,
            this.fullname,
            this.codename,
            this.business_group,
            this.site_name,
            this.area});
            this.dgList1.Location = new System.Drawing.Point(18, 69);
            this.dgList1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgList1.MultiSelect = false;
            this.dgList1.Name = "dgList1";
            this.dgList1.ReadOnly = true;
            this.dgList1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgList1.RowHeadersWidth = 25;
            this.dgList1.Size = new System.Drawing.Size(798, 414);
            this.dgList1.TabIndex = 42;
            this.dgList1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgList1_CellClick);
            this.dgList1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgList1_CellContentClick);
            this.dgList1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgList1_CellEnter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(134, 8);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 52);
            this.button2.TabIndex = 8;
            this.button2.Text = "Add &Site";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(402, 15);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 35);
            this.button3.TabIndex = 43;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // lblcount
            // 
            this.lblcount.AutoSize = true;
            this.lblcount.BackColor = System.Drawing.Color.LimeGreen;
            this.lblcount.Location = new System.Drawing.Point(772, 494);
            this.lblcount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(18, 20);
            this.lblcount.TabIndex = 44;
            this.lblcount.Text = "0";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(250, 8);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(112, 52);
            this.btnDel.TabIndex = 45;
            this.btnDel.Text = "D&elete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // siteid
            // 
            this.siteid.DataPropertyName = "siteid";
            this.siteid.HeaderText = "id";
            this.siteid.MinimumWidth = 8;
            this.siteid.Name = "siteid";
            this.siteid.ReadOnly = true;
            this.siteid.Visible = false;
            this.siteid.Width = 150;
            // 
            // user_id
            // 
            this.user_id.DataPropertyName = "user_id";
            this.user_id.HeaderText = "user_id";
            this.user_id.MinimumWidth = 8;
            this.user_id.Name = "user_id";
            this.user_id.ReadOnly = true;
            this.user_id.Visible = false;
            this.user_id.Width = 150;
            // 
            // fullname
            // 
            this.fullname.DataPropertyName = "fullname";
            this.fullname.HeaderText = "Immediate Support";
            this.fullname.MinimumWidth = 8;
            this.fullname.Name = "fullname";
            this.fullname.ReadOnly = true;
            // 
            // codename
            // 
            this.codename.DataPropertyName = "codename";
            this.codename.HeaderText = "Code Name";
            this.codename.MinimumWidth = 8;
            this.codename.Name = "codename";
            this.codename.ReadOnly = true;
            this.codename.Width = 75;
            // 
            // business_group
            // 
            this.business_group.DataPropertyName = "business_group";
            this.business_group.HeaderText = "Business Group";
            this.business_group.MinimumWidth = 8;
            this.business_group.Name = "business_group";
            this.business_group.ReadOnly = true;
            // 
            // site_name
            // 
            this.site_name.DataPropertyName = "site_name";
            this.site_name.HeaderText = "Site";
            this.site_name.MinimumWidth = 8;
            this.site_name.Name = "site_name";
            this.site_name.ReadOnly = true;
            // 
            // area
            // 
            this.area.DataPropertyName = "area";
            this.area.HeaderText = "Area";
            this.area.MinimumWidth = 8;
            this.area.Name = "area";
            this.area.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 528);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.lblcount);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgList1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FSC FTM Sites";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgList1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.DataGridView dgList1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblcount;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn siteid;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn codename;
        private System.Windows.Forms.DataGridViewTextBoxColumn business_group;
        private System.Windows.Forms.DataGridViewTextBoxColumn site_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn area;
    }
}

