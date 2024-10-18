using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MiniMarket
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Artificial Intelligence\Spring 2023\Database Management Systems\Projects\Forms\Windows Forms\MiniMarket\Database1.mdf"";Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2RatingStar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into MiniMarket values ('" + textBoxproduct.Text + "','" + textBoxprice.Text + "','" + textBoxexpirydate.Text + "','" + textBoxamount.Text + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelamount_Click(object sender, EventArgs e)
        {

        }

        private void buttonshow_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from MiniMarket", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            conn.Close();
        }

        private void buttonedit_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("update MiniMarket set Price = '" + textBoxprice.Text + "', Amount = '" + textBoxamount.Text + "', EpiryDate = '" + textBoxexpirydate.Text+ "' where Product = '" + textBoxproduct.Text + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void buttondel_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from MiniMarket where Product = '" + textBoxproduct.Text + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}