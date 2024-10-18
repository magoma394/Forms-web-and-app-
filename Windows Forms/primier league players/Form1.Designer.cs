namespace primier_league_players
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonadd = new System.Windows.Forms.Button();
            this.buttonedit = new System.Windows.Forms.Button();
            this.buttondel = new System.Windows.Forms.Button();
            this.buttonshow = new System.Windows.Forms.Button();
            this.labelage = new System.Windows.Forms.Label();
            this.labelplayer = new System.Windows.Forms.Label();
            this.labelgoals = new System.Windows.Forms.Label();
            this.labelmp = new System.Windows.Forms.Label();
            this.textBoxplayer = new System.Windows.Forms.TextBox();
            this.textBoxgoals = new System.Windows.Forms.TextBox();
            this.textBoxage = new System.Windows.Forms.TextBox();
            this.textBoxmp = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(517, 186);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonadd
            // 
            this.buttonadd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonadd.BackgroundImage")));
            this.buttonadd.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonadd.ForeColor = System.Drawing.Color.White;
            this.buttonadd.Location = new System.Drawing.Point(0, 192);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(94, 45);
            this.buttonadd.TabIndex = 1;
            this.buttonadd.Text = "ADD";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // buttonedit
            // 
            this.buttonedit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonedit.BackgroundImage")));
            this.buttonedit.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonedit.ForeColor = System.Drawing.Color.White;
            this.buttonedit.Location = new System.Drawing.Point(141, 192);
            this.buttonedit.Name = "buttonedit";
            this.buttonedit.Size = new System.Drawing.Size(94, 45);
            this.buttonedit.TabIndex = 2;
            this.buttonedit.Text = "EDIT";
            this.buttonedit.UseVisualStyleBackColor = true;
            this.buttonedit.Click += new System.EventHandler(this.buttonedit_Click);
            // 
            // buttondel
            // 
            this.buttondel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttondel.BackgroundImage")));
            this.buttondel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttondel.ForeColor = System.Drawing.Color.White;
            this.buttondel.Location = new System.Drawing.Point(281, 192);
            this.buttondel.Name = "buttondel";
            this.buttondel.Size = new System.Drawing.Size(94, 45);
            this.buttondel.TabIndex = 3;
            this.buttondel.Text = "DEL";
            this.buttondel.UseVisualStyleBackColor = true;
            this.buttondel.Click += new System.EventHandler(this.buttondel_Click);
            // 
            // buttonshow
            // 
            this.buttonshow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonshow.BackgroundImage")));
            this.buttonshow.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonshow.ForeColor = System.Drawing.Color.White;
            this.buttonshow.Location = new System.Drawing.Point(423, 192);
            this.buttonshow.Name = "buttonshow";
            this.buttonshow.Size = new System.Drawing.Size(94, 45);
            this.buttonshow.TabIndex = 4;
            this.buttonshow.Text = "SHOW";
            this.buttonshow.UseVisualStyleBackColor = true;
            this.buttonshow.Click += new System.EventHandler(this.buttonshow_Click);
            // 
            // labelage
            // 
            this.labelage.AutoSize = true;
            this.labelage.BackColor = System.Drawing.Color.Black;
            this.labelage.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelage.ForeColor = System.Drawing.Color.White;
            this.labelage.Location = new System.Drawing.Point(160, 576);
            this.labelage.Name = "labelage";
            this.labelage.Size = new System.Drawing.Size(45, 22);
            this.labelage.TabIndex = 5;
            this.labelage.Text = "Age";
            // 
            // labelplayer
            // 
            this.labelplayer.AutoSize = true;
            this.labelplayer.BackColor = System.Drawing.Color.Black;
            this.labelplayer.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelplayer.ForeColor = System.Drawing.Color.White;
            this.labelplayer.Location = new System.Drawing.Point(12, 487);
            this.labelplayer.Name = "labelplayer";
            this.labelplayer.Size = new System.Drawing.Size(67, 22);
            this.labelplayer.TabIndex = 6;
            this.labelplayer.Text = "Player";
            // 
            // labelgoals
            // 
            this.labelgoals.AutoSize = true;
            this.labelgoals.BackColor = System.Drawing.Color.Black;
            this.labelgoals.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelgoals.ForeColor = System.Drawing.Color.White;
            this.labelgoals.Location = new System.Drawing.Point(12, 572);
            this.labelgoals.Name = "labelgoals";
            this.labelgoals.Size = new System.Drawing.Size(63, 22);
            this.labelgoals.TabIndex = 7;
            this.labelgoals.Text = "Goals";
            // 
            // labelmp
            // 
            this.labelmp.AutoSize = true;
            this.labelmp.BackColor = System.Drawing.Color.Black;
            this.labelmp.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelmp.ForeColor = System.Drawing.Color.White;
            this.labelmp.Location = new System.Drawing.Point(292, 576);
            this.labelmp.Name = "labelmp";
            this.labelmp.Size = new System.Drawing.Size(153, 22);
            this.labelmp.TabIndex = 8;
            this.labelmp.Text = "Matches Played";
            // 
            // textBoxplayer
            // 
            this.textBoxplayer.Location = new System.Drawing.Point(12, 512);
            this.textBoxplayer.Name = "textBoxplayer";
            this.textBoxplayer.Size = new System.Drawing.Size(493, 27);
            this.textBoxplayer.TabIndex = 9;
            // 
            // textBoxgoals
            // 
            this.textBoxgoals.Location = new System.Drawing.Point(81, 571);
            this.textBoxgoals.Name = "textBoxgoals";
            this.textBoxgoals.Size = new System.Drawing.Size(37, 27);
            this.textBoxgoals.TabIndex = 10;
            // 
            // textBoxage
            // 
            this.textBoxage.Location = new System.Drawing.Point(222, 572);
            this.textBoxage.Name = "textBoxage";
            this.textBoxage.Size = new System.Drawing.Size(37, 27);
            this.textBoxage.TabIndex = 11;
            // 
            // textBoxmp
            // 
            this.textBoxmp.Location = new System.Drawing.Point(468, 575);
            this.textBoxmp.Name = "textBoxmp";
            this.textBoxmp.Size = new System.Drawing.Size(37, 27);
            this.textBoxmp.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(518, 765);
            this.Controls.Add(this.textBoxmp);
            this.Controls.Add(this.textBoxage);
            this.Controls.Add(this.textBoxgoals);
            this.Controls.Add(this.textBoxplayer);
            this.Controls.Add(this.labelmp);
            this.Controls.Add(this.labelgoals);
            this.Controls.Add(this.labelplayer);
            this.Controls.Add(this.labelage);
            this.Controls.Add(this.buttonshow);
            this.Controls.Add(this.buttondel);
            this.Controls.Add(this.buttonedit);
            this.Controls.Add(this.buttonadd);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonadd;
        private Button buttonedit;
        private Button buttondel;
        private Button buttonshow;
        private Label labelage;
        private Label labelplayer;
        private Label labelgoals;
        private Label labelmp;
        private TextBox textBoxplayer;
        private TextBox textBoxgoals;
        private TextBox textBoxage;
        private TextBox textBoxmp;
    }
}