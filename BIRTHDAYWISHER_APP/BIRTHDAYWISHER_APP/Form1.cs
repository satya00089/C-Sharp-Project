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
using System.Net.Mail;


namespace BIRTHDAYWISHER_APP
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into birthdaywisher values('"+txtName.Text+"','"+txtRedgno.Text+"','"+metroComboBox1.SelectedItem+"','"+txtMobileno.Text+"','"+txtDOB.Text+"','"+txtEmail.Text+"')";
           
            cmd.ExecuteNonQuery();
            con.Close();
            displaydata();
            MessageBox.Show("Your Data Is Successfully Saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            news();
        }

        public void displaydata()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from birthdaywisher";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            metroPanel1.Visible = true;



            
            displaydata();
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from birthdaywisher where fullname='"+txtName.Text+"'and redgno='"+txtRedgno.Text+"'";
            cmd.ExecuteNonQuery();
            con.Close();
            displaydata();
            MessageBox.Show("Your Data Is Deleted.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            news();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            displaydata();
        }
        public void news()
        {
            txtName.Text = "";
            txtRedgno.Text = "";
            metroComboBox1.SelectedIndex = -1;
            txtMobileno.Text = "";
            txtDOB.Text = "";
            txtEmail.Text = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from birthdaywisher where CONCAT(fullname,dob) LIKE '%" + txtSearch.Text + "%'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtreciever.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png | All files (*.*)|*.*", ValidateNames = true ,InitialDirectory= @"C:\", Title = "Please select an image file for attachment." })
            {

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtattachment.Text = ofd.FileName.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                message.From = new MailAddress(txtsender.Text);
                message.To.Add(txtreciever.Text);
                message.Body = txtbody.Text;
                message.Subject = txtsubject.Text;
                client.UseDefaultCredentials = false;
                client.EnableSsl = true;
                if (txtattachment.Text != "")
                {
                    message.Attachments.Add(new Attachment(txtattachment.Text));

                }

                client.Credentials = new System.Net.NetworkCredential(txtsender.Text, txtpassword.Text);
                client.Send(message);
                message = null;

                MessageBox.Show("Message Sent");
            }
            catch (Exception s)
            {
                MessageBox.Show("Failed to Send Message");
            }
        }

        private void txtRedgno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMobileno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool ValidateDate(string date)
        {
            try
            {
                // for US, alter to suit if splitting on hyphen, comma, etc.
                string[] dateParts = date.Split('/');

                // create new date from the parts; if this does not fail
                // the method will return true and the date is valid
                DateTime testDate = new
                    DateTime(Convert.ToInt32(dateParts[2]),
                    Convert.ToInt32(dateParts[0]),
                    Convert.ToInt32(dateParts[1]));
                return true;
            }
            catch
            {
                // if a test date cannot be created, the
                // method will return false
                return false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text == "admin" && metroTextBox2.Text == "eatm")
            {
                panel1.Visible = true;
                metroPanel1.Visible = false;
                metroTextBox1.Text = "";
                metroTextBox2.Text = "";
            }
            else if(metroTextBox1.Text == "admin" && metroTextBox2.Text != "eatm")
            {
                MessageBox.Show("Plase Enter Correct Password !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                metroTextBox1.Text = "";
                metroTextBox2.Text = "";
            }
            else if (metroTextBox1.Text != "admin" && metroTextBox2.Text == "eatm")
            {
                MessageBox.Show("Plase Enter Correct User Id !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                metroTextBox1.Text = "";
                metroTextBox2.Text = "";
            }
            else
            {
                MessageBox.Show("Plase Enter Correct User Id and Password !!!","Information",MessageBoxButtons.OK,MessageBoxIcon.Error);
                metroTextBox1.Text = "";
                metroTextBox2.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            metroPanel1.Visible = true;
        }
    }
}
