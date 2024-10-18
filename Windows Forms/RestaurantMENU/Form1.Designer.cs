namespace RestaurantMENU
{
    partial class FormMENU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMENU));
            this.buttonADD = new System.Windows.Forms.Button();
            this.buttonEDIT = new System.Windows.Forms.Button();
            this.buttonDEL = new System.Windows.Forms.Button();
            this.buttonSHOW = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxFood = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelFood = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonADD
            // 
            this.buttonADD.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonADD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonADD.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonADD.Location = new System.Drawing.Point(96, 624);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(183, 59);
            this.buttonADD.TabIndex = 0;
            this.buttonADD.Text = "ADD";
            this.buttonADD.UseVisualStyleBackColor = false;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // buttonEDIT
            // 
            this.buttonEDIT.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonEDIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEDIT.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonEDIT.Location = new System.Drawing.Point(326, 624);
            this.buttonEDIT.Name = "buttonEDIT";
            this.buttonEDIT.Size = new System.Drawing.Size(183, 59);
            this.buttonEDIT.TabIndex = 0;
            this.buttonEDIT.Text = "EDIT";
            this.buttonEDIT.UseVisualStyleBackColor = false;
            this.buttonEDIT.Click += new System.EventHandler(this.buttonEDIT_Click);
            // 
            // buttonDEL
            // 
            this.buttonDEL.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonDEL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDEL.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonDEL.Location = new System.Drawing.Point(144, 689);
            this.buttonDEL.Name = "buttonDEL";
            this.buttonDEL.Size = new System.Drawing.Size(79, 59);
            this.buttonDEL.TabIndex = 0;
            this.buttonDEL.Text = "DEL";
            this.buttonDEL.UseVisualStyleBackColor = false;
            this.buttonDEL.Click += new System.EventHandler(this.buttonDEL_Click);
            // 
            // buttonSHOW
            // 
            this.buttonSHOW.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonSHOW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSHOW.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonSHOW.Location = new System.Drawing.Point(382, 689);
            this.buttonSHOW.Name = "buttonSHOW";
            this.buttonSHOW.Size = new System.Drawing.Size(79, 59);
            this.buttonSHOW.TabIndex = 0;
            this.buttonSHOW.Text = "SHOW";
            this.buttonSHOW.UseVisualStyleBackColor = false;
            this.buttonSHOW.Click += new System.EventHandler(this.buttonSHOW_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(58, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(501, 188);
            this.dataGridView1.TabIndex = 1;
            // 
            // textBoxFood
            // 
            this.textBoxFood.Location = new System.Drawing.Point(213, 495);
            this.textBoxFood.Name = "textBoxFood";
            this.textBoxFood.Size = new System.Drawing.Size(296, 27);
            this.textBoxFood.TabIndex = 3;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(213, 539);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(52, 27);
            this.textBoxPrice.TabIndex = 4;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelPrice.Location = new System.Drawing.Point(96, 542);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(41, 20);
            this.labelPrice.TabIndex = 5;
            this.labelPrice.Text = "Price";
            // 
            // labelFood
            // 
            this.labelFood.AutoSize = true;
            this.labelFood.BackColor = System.Drawing.Color.Transparent;
            this.labelFood.Location = new System.Drawing.Point(96, 498);
            this.labelFood.Name = "labelFood";
            this.labelFood.Size = new System.Drawing.Size(43, 20);
            this.labelFood.TabIndex = 6;
            this.labelFood.Text = "Food";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.BackColor = System.Drawing.Color.Transparent;
            this.labelSize.Location = new System.Drawing.Point(326, 542);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(36, 20);
            this.labelSize.TabIndex = 7;
            this.labelSize.Text = "Size";
            // 
            // textBoxSize
            // 
            this.textBoxSize.Location = new System.Drawing.Point(395, 539);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(114, 27);
            this.textBoxSize.TabIndex = 8;
            // 
            // FormMENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 795);
            this.Controls.Add(this.textBoxSize);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.labelFood);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxFood);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSHOW);
            this.Controls.Add(this.buttonEDIT);
            this.Controls.Add(this.buttonDEL);
            this.Controls.Add(this.buttonADD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMENU";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonADD;
        private Button buttonEDIT;
        private Button buttonDEL;
        private Button buttonSHOW;
        private DataGridView dataGridView1;
        private TextBox textBoxFood;
        private TextBox textBoxPrice;
        private Label labelPrice;
        private Label labelFood;
        private Label labelSize;
        private TextBox textBoxSize;
    }
}