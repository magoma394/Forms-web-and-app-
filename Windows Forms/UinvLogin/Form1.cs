using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace UinvLogin
{
    public partial class FormUnivLogin : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Artificial Intelligence\Spring 2023\Database Management Systems\Projects\Forms\Windows Forms\UinvLogin\Database1.mdf"";Integrated Security=True");
        public FormUnivLogin()
        {
            InitializeComponent();
        }

       
        private void FormUnivLogin_Load_1(object sender, EventArgs e)
        {

        }
            
        private void buttonshow_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from univLogin", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();

        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into univLogin values ('"+textBoxID.Text+"','"+textBoxName.Text+"','"+textBoxAddress.Text+"','"+ textBoxPhoneNumber.Text + "','"+ textBoxHighschoolGrade.Text+"')", conn);
            cmd.ExecuteNonQuery(); 
            conn.Close();   
        }

        private void buttonedit_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("update univLogin set Name = '" +textBoxName.Text+ "',Address = '"+textBoxAddress.Text+"',PhoneNumber = '"+ textBoxPhoneNumber.Text + "',GPA ='"+ textBoxHighschoolGrade.Text+ "' where ID = '"+textBoxID.Text+"'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        private void buttondelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from uivLogin where ID = '"+textBoxID.Text+"'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}