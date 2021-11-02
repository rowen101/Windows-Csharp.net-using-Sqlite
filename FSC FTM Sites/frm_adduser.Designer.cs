namespace FSC_FTM_Sites
{
    partial class frm_adduser
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
            this.dgList1 = new System.Windows.Forms.DataGridView();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtfullname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcodename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgList1)).BeginInit();
            this.SuspendLayout();
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
            this.fullname,
            this.codename,
            this.id});
            this.dgList1.Location = new System.Drawing.Point(18, 93);
            this.dgList1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgList1.MultiSelect = false;
            this.dgList1.Name = "dgList1";
            this.dgList1.ReadOnly = true;
            this.dgList1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgList1.RowHeadersWidth = 25;
            this.dgList1.Size = new System.Drawing.Size(375, 281);
            this.dgList1.TabIndex = 43;
            this.dgList1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgList1_CellClick);
            // 
            // fullname
            // 
            this.fullname.DataPropertyName = "fullname";
            this.fullname.HeaderText = "Full Name";
            this.fullname.MinimumWidth = 8;
            this.fullname.Name = "fullname";
            this.fullname.ReadOnly = true;
            this.fullname.Width = 150;
            // 
            // codename
            // 
            this.codename.DataPropertyName = "codename";
            this.codename.HeaderText = "Code Name";
            this.codename.MinimumWidth = 8;
            this.codename.Name = "codename";
            this.codename.ReadOnly = true;
            this.codename.Width = 150;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 150;
            // 
            // txtfullname
            // 
            this.txtfullname.Location = new System.Drawing.Point(136, 13);
            this.txtfullname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(254, 26);
            this.txtfullname.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Full Name";
            // 
            // txtcodename
            // 
            this.txtcodename.Location = new System.Drawing.Point(136, 53);
            this.txtcodename.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcodename.Name = "txtcodename";
            this.txtcodename.Size = new System.Drawing.Size(132, 26);
            this.txtcodename.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "CodeName";
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(140, 384);
            this.btnedit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(112, 57);
            this.btnedit.TabIndex = 47;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.Btnedit_Click_1);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(18, 384);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(112, 57);
            this.btnadd.TabIndex = 46;
            this.btnadd.Text = "Submit";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.Btnadd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 384);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 57);
            this.button1.TabIndex = 48;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(490, 64);
            this.lblid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(51, 20);
            this.lblid.TabIndex = 49;
            this.lblid.Text = "label3";
            this.lblid.Visible = false;
            // 
            // frm_adduser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 460);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcodename);
            this.Controls.Add(this.txtfullname);
            this.Controls.Add(this.dgList1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_adduser";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Immediate Support";
            this.Load += new System.EventHandler(this.Frm_adduser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgList1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgList1;
        private System.Windows.Forms.TextBox txtfullname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcodename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn codename;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}