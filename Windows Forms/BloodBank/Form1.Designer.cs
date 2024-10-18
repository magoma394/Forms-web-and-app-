namespace BloodBank
{
    partial class FormBloodBank
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBloodBank));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxBloodType = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonAdd = new Guna.UI2.WinForms.Guna2CircleButton();
            this.ButtonShow = new Guna.UI2.WinForms.Guna2CircleButton();
            this.ButtonDel = new Guna.UI2.WinForms.Guna2CircleButton();
            this.ButtonEdit = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Firebrick;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Gray;
            this.dataGridView1.Location = new System.Drawing.Point(13, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(907, 113);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.Beige;
            this.textBoxName.Location = new System.Drawing.Point(423, 219);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(335, 27);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxBloodType
            // 
            this.textBoxBloodType.BackColor = System.Drawing.Color.Beige;
            this.textBoxBloodType.Location = new System.Drawing.Point(477, 258);
            this.textBoxBloodType.Name = "textBoxBloodType";
            this.textBoxBloodType.Size = new System.Drawing.Size(43, 27);
            this.textBoxBloodType.TabIndex = 2;
            // 
            // textBoxAge
            // 
            this.textBoxAge.BackColor = System.Drawing.Color.Beige;
            this.textBoxAge.Location = new System.Drawing.Point(592, 257);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(38, 27);
            this.textBoxAge.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(351, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(351, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Blood Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(540, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Age";
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.Transparent;
            this.ButtonAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonAdd.FillColor = System.Drawing.Color.CornflowerBlue;
            this.ButtonAdd.Font = new System.Drawing.Font("Castellar", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonAdd.ForeColor = System.Drawing.Color.Beige;
            this.ButtonAdd.Location = new System.Drawing.Point(570, 146);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.ShadowDecoration.CustomizableEdges = customizableEdges1;
            this.ButtonAdd.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ButtonAdd.Size = new System.Drawing.Size(83, 67);
            this.ButtonAdd.TabIndex = 7;
            this.ButtonAdd.Text = "ADD";
            this.ButtonAdd.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // ButtonShow
            // 
            this.ButtonShow.BackColor = System.Drawing.Color.Transparent;
            this.ButtonShow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonShow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonShow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonShow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonShow.FillColor = System.Drawing.Color.IndianRed;
            this.ButtonShow.Font = new System.Drawing.Font("Castellar", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonShow.ForeColor = System.Drawing.Color.Beige;
            this.ButtonShow.Location = new System.Drawing.Point(837, 146);
            this.ButtonShow.Name = "ButtonShow";
            this.ButtonShow.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.ButtonShow.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ButtonShow.Size = new System.Drawing.Size(83, 67);
            this.ButtonShow.TabIndex = 8;
            this.ButtonShow.Text = "SHOW";
            this.ButtonShow.Click += new System.EventHandler(this.ButtonShow_Click);
            // 
            // ButtonDel
            // 
            this.ButtonDel.BackColor = System.Drawing.Color.Transparent;
            this.ButtonDel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonDel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonDel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonDel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonDel.FillColor = System.Drawing.Color.Firebrick;
            this.ButtonDel.Font = new System.Drawing.Font("Castellar", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonDel.ForeColor = System.Drawing.Color.Beige;
            this.ButtonDel.Location = new System.Drawing.Point(748, 146);
            this.ButtonDel.Name = "ButtonDel";
            this.ButtonDel.ShadowDecoration.CustomizableEdges = customizableEdges3;
            this.ButtonDel.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ButtonDel.Size = new System.Drawing.Size(83, 67);
            this.ButtonDel.TabIndex = 9;
            this.ButtonDel.Text = "DEL";
            this.ButtonDel.Click += new System.EventHandler(this.ButtonDel_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.BackColor = System.Drawing.Color.Transparent;
            this.ButtonEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonEdit.FillColor = System.Drawing.Color.DeepPink;
            this.ButtonEdit.Font = new System.Drawing.Font("Castellar", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonEdit.ForeColor = System.Drawing.Color.Beige;
            this.ButtonEdit.Location = new System.Drawing.Point(659, 146);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.ShadowDecoration.CustomizableEdges = customizableEdges4;
            this.ButtonEdit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ButtonEdit.Size = new System.Drawing.Size(83, 67);
            this.ButtonEdit.TabIndex = 10;
            this.ButtonEdit.Text = "EDIT";
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // FormBloodBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(931, 486);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonDel);
            this.Controls.Add(this.ButtonShow);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxBloodType);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBloodBank";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormBloodBank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBoxName;
        private TextBox textBoxBloodType;
        private TextBox textBoxAge;
        private Label label1;
        private Label label2;
        private Label label3;
        private Guna.UI2.WinForms.Guna2CircleButton ButtonAdd;
        private Guna.UI2.WinForms.Guna2CircleButton ButtonShow;
        private Guna.UI2.WinForms.Guna2CircleButton ButtonDel;
        private Guna.UI2.WinForms.Guna2CircleButton ButtonEdit;
    }
}