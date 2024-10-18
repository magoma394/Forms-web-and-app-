using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BloodBank
{
    public partial class FormBloodBank : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Artificial Intelligence\Spring 2023\Database Management Systems\Projects\Forms\Windows Forms\BloodBank\Database1.mdf"";Integrated Security=True");
        public FormBloodBank()
        {
            InitializeComponent();
        }

        private void FormBloodBank_Load(object sender, EventArgs e)
        {

        }


        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into BloodBank values ('" + textBoxName.Text + "','" + textBoxBloodType.Text + "','" + textBoxAge.Text + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void ButtonShow_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from BloodBank", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();

        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("update BloodBank set BloodType = '" + textBoxBloodType.Text + "',Age = '" + textBoxAge.Text + "' where Name = '" + textBoxName.Text + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from BloodBank where Name = '" + textBoxName.Text + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}