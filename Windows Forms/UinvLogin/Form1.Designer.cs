namespace UinvLogin
{
    partial class FormUnivLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUnivLogin));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelid = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.labeladdress = new System.Windows.Forms.Label();
            this.labelhighschoolgrade = new System.Windows.Forms.Label();
            this.labelphonenumber = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxHighschoolGrade = new System.Windows.Forms.TextBox();
            this.buttonshow = new System.Windows.Forms.Button();
            this.buttonadd = new System.Windows.Forms.Button();
            this.buttonedit = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(929, 188);
            this.dataGridView1.TabIndex = 0;
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.BackColor = System.Drawing.Color.Transparent;
            this.labelid.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelid.Location = new System.Drawing.Point(35, 268);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(38, 25);
            this.labelid.TabIndex = 2;
            this.labelid.Text = "ID";
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.BackColor = System.Drawing.Color.Transparent;
            this.labelname.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelname.Location = new System.Drawing.Point(35, 316);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(71, 25);
            this.labelname.TabIndex = 2;
            this.labelname.Text = "Name";
            // 
            // labeladdress
            // 
            this.labeladdress.AutoSize = true;
            this.labeladdress.BackColor = System.Drawing.Color.Transparent;
            this.labeladdress.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labeladdress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labeladdress.Location = new System.Drawing.Point(35, 365);
            this.labeladdress.Name = "labeladdress";
            this.labeladdress.Size = new System.Drawing.Size(93, 25);
            this.labeladdress.TabIndex = 2;
            this.labeladdress.Text = "Address";
            // 
            // labelhighschoolgrade
            // 
            this.labelhighschoolgrade.AutoSize = true;
            this.labelhighschoolgrade.BackColor = System.Drawing.Color.Transparent;
            this.labelhighschoolgrade.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelhighschoolgrade.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelhighschoolgrade.Location = new System.Drawing.Point(35, 456);
            this.labelhighschoolgrade.Name = "labelhighschoolgrade";
            this.labelhighschoolgrade.Size = new System.Drawing.Size(59, 25);
            this.labelhighschoolgrade.TabIndex = 2;
            this.labelhighschoolgrade.Text = "GPA";
            // 
            // labelphonenumber
            // 
            this.labelphonenumber.AutoSize = true;
            this.labelphonenumber.BackColor = System.Drawing.Color.Transparent;
            this.labelphonenumber.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelphonenumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelphonenumber.Location = new System.Drawing.Point(35, 413);
            this.labelphonenumber.Name = "labelphonenumber";
            this.labelphonenumber.Size = new System.Drawing.Size(165, 25);
            this.labelphonenumber.TabIndex = 2;
            this.labelphonenumber.Text = "Phone Number";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(289, 266);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(663, 27);
            this.textBoxID.TabIndex = 3;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(289, 314);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(663, 27);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(289, 363);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(663, 27);
            this.textBoxAddress.TabIndex = 3;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(289, 411);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(663, 27);
            this.textBoxPhoneNumber.TabIndex = 4;
            // 
            // textBoxHighschoolGrade
            // 
            this.textBoxHighschoolGrade.Location = new System.Drawing.Point(289, 454);
            this.textBoxHighschoolGrade.Name = "textBoxHighschoolGrade";
            this.textBoxHighschoolGrade.Size = new System.Drawing.Size(663, 27);
            this.textBoxHighschoolGrade.TabIndex = 4;
            // 
            // buttonshow
            // 
            this.buttonshow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonshow.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonshow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonshow.Image = ((System.Drawing.Image)(resources.GetObject("buttonshow.Image")));
            this.buttonshow.Location = new System.Drawing.Point(870, 646);
            this.buttonshow.Name = "buttonshow";
            this.buttonshow.Size = new System.Drawing.Size(94, 35);
            this.buttonshow.TabIndex = 6;
            this.buttonshow.Text = "SHOW";
            this.buttonshow.UseVisualStyleBackColor = true;
            this.buttonshow.Click += new System.EventHandler(this.buttonshow_Click);
            // 
            // buttonadd
            // 
            this.buttonadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonadd.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonadd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonadd.Image = ((System.Drawing.Image)(resources.GetObject("buttonadd.Image")));
            this.buttonadd.Location = new System.Drawing.Point(770, 646);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(94, 35);
            this.buttonadd.TabIndex = 8;
            this.buttonadd.Text = "ADD";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // buttonedit
            // 
            this.buttonedit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonedit.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonedit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonedit.Image = ((System.Drawing.Image)(resources.GetObject("buttonedit.Image")));
            this.buttonedit.Location = new System.Drawing.Point(670, 646);
            this.buttonedit.Name = "buttonedit";
            this.buttonedit.Size = new System.Drawing.Size(94, 35);
            this.buttonedit.TabIndex = 9;
            this.buttonedit.Text = "EDIT";
            this.buttonedit.UseVisualStyleBackColor = true;
            this.buttonedit.Click += new System.EventHandler(this.buttonedit_Click);
            // 
            // buttondelete
            // 
            this.buttondelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttondelete.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttondelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttondelete.Image = ((System.Drawing.Image)(resources.GetObject("buttondelete.Image")));
            this.buttondelete.Location = new System.Drawing.Point(570, 646);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(94, 35);
            this.buttondelete.TabIndex = 9;
            this.buttondelete.Text = "DELETE";
            this.buttondelete.UseVisualStyleBackColor = true;
            this.buttondelete.Click += new System.EventHandler(this.buttonedit_Click);
            // 
            // FormUnivLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1000, 717);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.buttonedit);
            this.Controls.Add(this.buttonadd);
            this.Controls.Add(this.buttonshow);
            this.Controls.Add(this.textBoxHighschoolGrade);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelphonenumber);
            this.Controls.Add(this.labelhighschoolgrade);
            this.Controls.Add(this.labeladdress);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUnivLogin";
            this.Text = "FormUnivLogin";
            this.Load += new System.EventHandler(this.FormUnivLogin_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label labelid;
        private Label labelname;
        private Label labeladdress;
        private Label labelhighschoolgrade;
        private Label labelphonenumber;
        private TextBox textBoxID;
        private TextBox textBoxName;
        private TextBox textBoxAddress;
        private TextBox textBoxPhoneNumber;
        private TextBox textBoxHighschoolGrade;
        private Button buttonshow;
        private Button buttonadd;
        private Button buttonedit;
        private Button buttondelete;
    }
}