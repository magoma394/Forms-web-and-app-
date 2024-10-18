using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace RestaurantMENU
{
    public partial class FormMENU : System.Windows.Forms.Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Artificial Intelligence\Spring 2023\Database Management Systems\Projects\Forms\Windows Forms\RestaurantMENU\Database1.mdf"";Integrated Security=True");
        public FormMENU()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSHOW_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from menu", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into menu values ('" + textBoxFood.Text + "','" + textBoxPrice.Text + "','" + textBoxSize.Text +"')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void buttonEDIT_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("update menu set Price = '" + textBoxPrice.Text + "',Size = '" + textBoxSize.Text + "' where Food = '" + textBoxFood.Text + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void buttonDEL_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from menu where Food = '" + textBoxFood.Text + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}