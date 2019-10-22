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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=Busra; Initial Catalog=library_automation ;Integrated Security=SSPI");
        public int UserId;
        private void Form1_Load(object sender, EventArgs e)
        {
            pnl_book.Visible = false;
            pnl_insert_book.Visible = false;
            pnl_receive.Visible = false;
            pnl_deliver.Visible = false;
            pnl_deposit.Visible = false;
            pnl_update.Visible = false;

            pnl_book.Location = new Point(83, 62);
            pnl_book.Height = 373;
            pnl_book.Width = 819;
            pnl_book.Visible = true;

            c_taken.CheckOnClick = true;
            c_all.CheckOnClick = true;
            cbox_list.CheckOnClick = true;
            cbox_search.CheckOnClick = true;//tek tıkla işlem yapmayı sağlıyor

            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlCommand q1 = new SqlCommand("select * from Book ORDER BY BookName", con);
            SqlDataReader dr1 = q1.ExecuteReader();
            int i = 1;
            while (dr1.Read())
            {
                if (!lbox_book.Items.Contains(dr1["BookName"]))
                    lbox_book.Items.Add(i + ". " + dr1["BookName"]);

                if (!lbox_author.Items.Contains(dr1["BookAuthor"]))
                    lbox_author.Items.Add(i + ". " + dr1["BookAuthor"]);
                i++;
            }
            dr1.Close();
            con.Close();
        }

        private void lbox_receive_name_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kitaplarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_insert_book.Visible = false;
            pnl_receive.Visible = false;
            pnl_deliver.Visible = false;
            pnl_deposit.Visible = false;
            pnl_update.Visible = false;

            pnl_book.Location = new Point(83, 62);
            pnl_book.Height = 373;
            pnl_book.Width = 819;
            pnl_book.Visible = true;
        }

        private void kitapEkleAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_book.Visible = false;
            pnl_receive.Visible = false;
            pnl_deliver.Visible = false;
            pnl_deposit.Visible = false;
            pnl_update.Visible = false;

            pnl_insert_book.Location = new Point(248, 90);
            pnl_insert_book.Height = 313;
            pnl_insert_book.Width = 409;
            pnl_insert_book.Visible = true;
        }
        private void btn_book_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            if (tbox_name.Text != "" && tbox_author.Text != "")
            {
                SqlCommand q1 = new SqlCommand("insert into Book(BookName,BookAuthor) values(@n,@a)", con);
                q1.Parameters.AddWithValue("@n", tbox_name.Text);
                q1.Parameters.AddWithValue("@a", tbox_author.Text);
                q1.ExecuteNonQuery();
                tbox_name.Text = "";
                tbox_author.Text = "";
                MessageBox.Show("Ekleme İşlemi Başarılı");
            }
            else
                MessageBox.Show("Lütfen Alanları Doldurunuz.");

            con.Close();
        }

        private void kitapTeslimAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_book.Visible = false;
            pnl_insert_book.Visible = false;
            pnl_deliver.Visible = false;
            pnl_deposit.Visible = false;
            pnl_update.Visible = false;
            
            pnl_receive.Location = new Point(28, 48);
            pnl_receive.Height = 350;
            pnl_receive.Width = 910;
            pnl_receive.Visible = true;
            Form2 f2 = new Form2();
            f2.UserId = UserId;

            if (con.State == ConnectionState.Closed)
                con.Open();
            try
            {
                SqlCommand q1 = new SqlCommand("select * from Book where UserID IS NULL ORDER BY BookName ", con);
                q1.ExecuteNonQuery();
                SqlDataReader dr1 = q1.ExecuteReader();

                while (dr1.Read())
                {
                    c_all.Items.Add(dr1["BookName"]);
                }
                dr1.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Ekleme İşleminiz Hatalı!" + error.Message);
            }
            con.Close();
        }

        private void kitapTeslimEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_book.Visible = false;
            pnl_insert_book.Visible = false;
            pnl_receive.Visible = false;
            pnl_deposit.Visible = false;
            pnl_update.Visible = false;
            
            pnl_deliver.Location = new Point(94, 57);
            pnl_deliver.Height = 350;
            pnl_deliver.Width = 784;
            pnl_deliver.Visible = true;
           
            if (con.State == ConnectionState.Closed)
                            con.Open();
            try
            {
                SqlCommand q2 = new SqlCommand("select * from Book where UserID= '" + UserId + "' ORDER BY BookName", con);
                q2.ExecuteNonQuery();
                SqlDataReader dr2 = q2.ExecuteReader();

                while (dr2.Read())
                {
                    if (!cbox_list.Items.Contains(dr2["BookName"]))
                        cbox_list.Items.Add(dr2["BookName"]);
                }
                dr2.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Ekleme İşleminiz Hatalı!" + error.Message);
            }
            con.Close();
        }

        private void emanetlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_book.Visible = false;
            pnl_insert_book.Visible = false;
            pnl_receive.Visible = false;
            pnl_deliver.Visible = false;
            pnl_update.Visible = false;
           
            pnl_deposit.Location = new Point(92, 71);
            pnl_deposit.Height = 318;
            pnl_deposit.Width = 755;
            pnl_deposit.Visible = true;

            if (con.State == ConnectionState.Closed)
                   con.Open();
            SqlCommand q1 = new SqlCommand("select * from Book where UserID IS NOT NULL ORDER BY BookName", con);
            SqlDataReader dr1 = q1.ExecuteReader();
            int i = 1;
            while (dr1.Read())
            {
                if (!lbox_receive_book.Items.Contains(dr1["BookName"]))
                    lbox_receive_book.Items.Add(i + ". " + dr1["BookName"]);

                if (!lbox_receive_name.Items.Contains(dr1["BookAuthor"]))
                    lbox_receive_name.Items.Add(i + ". " + dr1["BookAuthor"]);
                i++;
            }
            dr1.Close();
            con.Close();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            
            var cList = c_all.CheckedItems;// c.CheckedItems içeriğini değiştirmeden kullanmamız gerekiyor

            foreach (var item in cList)
            {
                if (!c_taken.Items.Contains(item))//l.Items te item yoksa ekle
                    c_taken.Items.Add(item);
            }

            foreach (var item in c_taken.Items)
            {
                if (c_all.Items.Contains(item))//c.Items da item varsa sil
                    c_all.Items.Remove(item);
            }

            var receivelist = c_taken.Items;

            foreach (var item in receivelist)
            {
                SqlCommand q1 = new SqlCommand("UPDATE Book SET UserID='" + UserId + "' WHERE BookName='" + item.ToString() + "'", con);
                SqlDataReader dr1 = q1.ExecuteReader();
                dr1.Close();
            }
            con.Close();
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            
            SqlCommand q1 = new SqlCommand("SELECT * from Book where BookName LIKE '%" + textBox1.Text + "%'  and UserID IS NULL", con);
            SqlDataReader dr1 = q1.ExecuteReader();
            
            while (dr1.Read())
            {
                if (!cbox_search.Items.Contains(dr1["BookName"]))
                    cbox_search.Items.Add(dr1["BookName"]);
            }
            dr1.Close();
            con.Close();
        }

        private void insert2_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            if (cbox_search.CheckedItems.Count > 0)
            {
                var c_search = cbox_search.CheckedItems;

                foreach (var item in c_search)
                {
                    if (!c_taken.Items.Contains(item))
                        c_taken.Items.Add(item);
                }
            }
            var receivelist = c_taken.Items;
            foreach (var item in receivelist)
            {
                SqlCommand q1 = new SqlCommand("UPDATE Book SET UserID='" + UserId + "' WHERE BookName='" + item.ToString() + "'", con);
                SqlDataReader dr1 = q1.ExecuteReader();
                dr1.Close();
            }

            if (cbox_search.Items.Count > 0)
            {
                cbox_search.Items.Clear();
                textBox1.Text = "";
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            var cList = c_taken.CheckedItems;

            foreach (var item in cList)
            {
                if (!c_all.Items.Contains(item))
                    c_all.Items.Add(item);
            }
            var listbox = c_taken.CheckedItems;

            foreach (var item in listbox)
            {
                SqlCommand q1 = new SqlCommand("UPDATE Book SET UserID=null WHERE BookName='" + item.ToString() + "'", con);

                SqlDataReader dr1 = q1.ExecuteReader();
                dr1.Close();
            }

            foreach (var item in c_all.Items)
            {
                if (c_taken.Items.Contains(item))
                    c_taken.Items.Remove(item);
            }
            
            con.Close();
        }

        private void btn_give_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            var cList = cbox_list.CheckedItems;
            foreach (var item in cList)
            {
                if (!c_all.Items.Contains(item))
                    c_all.Items.Add(item);
            }
    
            var listbox = cbox_list.CheckedItems;
            foreach (var item in listbox)
            {
                SqlCommand q1 = new SqlCommand("UPDATE Book SET UserID=null WHERE BookName='" + item.ToString() + "'", con);

                SqlDataReader dr1 = q1.ExecuteReader();
                dr1.Close();
            }

            foreach (var item in c_all.Items)
            {
                if (cbox_list.Items.Contains(item))
                    cbox_list.Items.Remove(item);
            }
            var list = c_all.Items;
            foreach (var i in list)
            {
                if (c_all.Items.Contains(i))
                    c_taken.Items.Remove(i);
            }
            con.Close();
        }

        private void uyeİşlerimeriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_book.Visible = false;
            pnl_insert_book.Visible = false;
            pnl_receive.Visible = false;
            pnl_deliver.Visible = false;
            pnl_deposit.Visible = false;

            pnl_update.Location = new Point(61,101);
            pnl_update.Height = 317;
            pnl_update.Width = 749;
            pnl_update.Visible = true;
            update_pass.PasswordChar = '*';
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            if (update_name.Text != "")
            {
                SqlCommand q1 = new SqlCommand("Update Users Set Name='" + update_name.Text + "' where UserID='" + UserId + "'", con);
                SqlDataReader dr1=q1.ExecuteReader();
                dr1.Close();
            }
            if (update_uname.Text != "")
            {
                SqlCommand q2 = new SqlCommand("Update Users Set UserName='" + update_uname.Text + "' where UserID='" + UserId + "'", con);
                SqlDataReader dr2=q2.ExecuteReader();
                dr2.Close();
            }
            if (update_pass.Text != "")
            {
                SqlCommand q3 = new SqlCommand("Update Users Set Password='" + update_pass.Text + "' where UserID='" + UserId + "'", con);
                SqlDataReader dr3=q3.ExecuteReader();
                dr3.Close();
            }
            if (update_email.Text != "")
            {
                SqlCommand q4 = new SqlCommand("Update Users Set Email='" + update_email.Text + "' where UserID='" + UserId + "'", con);
                SqlDataReader dr4=q4.ExecuteReader();
                dr4.Close();
            }
            if (update_departman.Text != "")
            {
                SqlCommand q5 = new SqlCommand("Update Users Set Departman='" + update_departman.Text + "' where UserID='" + UserId + "'", con);
                SqlDataReader dr5=q5.ExecuteReader();
                dr5.Close();
            }
            MessageBox.Show("Bilgileriniz Başarıyla Güncellendi.");
            update_name.Text = "";
            update_uname.Text = "";
            update_pass.Text = "";
            update_email.Text = "";
            update_departman.Text = "";

            con.Close();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserId = 0;
            DialogResult option= MessageBox.Show("Çıkış Yapmak İstiyor Musunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.OKCancel);
            if (option == DialogResult.OK)
            {
                Form2 f2 = new Form2();
                f2.Close();
                this.Close();
                Application.Exit();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
