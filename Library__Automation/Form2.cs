using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library__Automation
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public int UserId;
        
        SqlConnection con = new SqlConnection("server=Busra; Initial Catalog=library_automation ;Integrated Security=SSPI");
        private void Form2_Load(object sender, EventArgs e)
        {
            pnl_signin.Visible = true;
            pnl_signup.Visible = false;
            pass.PasswordChar = '*';
            Password.PasswordChar = '*';
        }

        private void Signup_Click(object sender, EventArgs e)
        {
            pnl_signup.Location = new Point(5, 8);
            pnl_signup.Height = 350;
            pnl_signup.Width = 313;
            pnl_signup.Visible = true;
        }

        private void Login_Click_1(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("select * from Users where UserName='" + UserName.Text + "' AND Password='" + Password.Text + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Form1 f1 = new Form1();
                    f1.Show();
                    f1.UserId=Convert.ToInt16(dr["UserID"]);
                    this.Hide();
                }
                else
                    MessageBox.Show("Giriş İşleminiz Hatalı! Lütfen Şifrenizi Veya İsminizi Kontol Edin.");

                dr.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Giriş İşleminiz Hatalı! Lütfen Şifrenizi Veya İsminizi Kontol Edin." + error.Message);
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            
            if (name.Text != "" && uname.Text != "" && Email.Text != "" && pass.Text != "" && departman.Text != "")
            {
                try
                {
                    string query1 = "insert into Users (Name,UserName,Email,Password,Departman) values (@n,@un,@e,@p,@d)";
                    SqlCommand q1 = new SqlCommand(query1, con);
                    q1.Parameters.AddWithValue("@n", name.Text);
                    q1.Parameters.AddWithValue("@un", uname.Text);
                    q1.Parameters.AddWithValue("@e", Email.Text);
                    q1.Parameters.AddWithValue("@p", pass.Text);
                    q1.Parameters.AddWithValue("@d", departman.Text);
                    SqlDataReader dr1=q1.ExecuteReader();
                  
                    MessageBox.Show("Kaydınız Başarılı");
                    dr1.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Kaydınız Tamamlanamadı " + error.Message);
                }

                // Userid'yi Çekmeye Çalışıyoruz.
                SqlCommand cmd = new SqlCommand("select * from Users where UserName='" + uname.Text + "' AND Password='" + pass.Text + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();

                Form1 f1 = new Form1();
                while (dr.Read())
                {
                    f1.UserId = Convert.ToInt32(dr["UserID"]);
                    UserId = Convert.ToInt16(dr["UserID"]);
                }
                dr.Close();

                name.Text = "";
                uname.Text = "";
                Email.Text = "";
                pass.Text = "";
                departman.Text = "";

                f1.Show();
                this.Hide();
                con.Close();
            }
            else
                MessageBox.Show("Lütfen Bütün Alanları Doldurunuz.");
        }

        private void back_Click(object sender, EventArgs e)
        {
            pnl_signup.Visible = false;
            pnl_signin.Location = new Point(5, 8);
            pnl_signin.Height = 316;
            pnl_signin.Width = 313;
            pnl_signin.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
