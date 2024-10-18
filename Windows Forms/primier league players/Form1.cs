using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace primier_league_players
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Artificial Intelligence\Spring 2023\Database Management Systems\Projects\Forms\Windows Forms\primier league players\Database1.mdf"";Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonshow_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from PLScorers", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into PLScorers values ('" + textBoxage.Text + "','" + textBoxplayer.Text + "','" + textBoxgoals.Text + "','" + textBoxmp.Text + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void buttonedit_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("update PLScorers set Age = '" + textBoxage.Text + "', Goals = '"+textBoxgoals+"', MP = '"+textBoxmp+"' where Player = '" + textBoxplayer.Text + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void buttondel_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from PLScorers where Age = '" + textBoxage.Text + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}