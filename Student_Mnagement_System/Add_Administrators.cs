using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Student_Mnagement_System
{
    public partial class Add_Administrators : Form
    {

        
    
        public Add_Administrators()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "choose Photo(*.jpg;*.png;*.Jpeg;*.bmp;)|*.jpg;*.png;*.Jpeg;*.bmp;";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBox_Admin.Image = Image.FromFile(op.FileName);


            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtfirstname_Admin.Text = "";
            txtmiddlename_Admin.Text = "";
            txtlastname_Admin.Text = "";
            txtdate_Admin.Text = "";
            txtmonth_Admin.Text = "";
            txtyear_Admin.Text = "";
            txtphone_Admin.Text = "";
            txtpassadmin.Text = "";
            txtconfirmpassadmin.Text = "";
            txtemail_Admin.Text = "";
            radioButtonmale_Admin.Checked = false;
            radioButtonfemale_Admin.Checked = false;
            txtadminid.Text = "";
            

            pictureBox_Admin.Image = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox_Admin.Image.Save(ms, pictureBox_Admin.Image.RawFormat);
            byte[] photoADMIN = ms.ToArray();

            MessageBox.Show("save successful. An Admin has been added.");
            user_layer admin = new user_layer();
            admin.username_admin = txtadminid.Text;
            admin.email_admin = txtemail_Admin.Text;
            admin.fname_admin = txtfirstname_Admin.Text;
            admin.mname_admin = txtmiddlename_Admin.Text;
            admin.lname_admin = txtlastname_Admin.Text;
            string dateadmin = txtyear_Admin.Text + "-" + txtmonth_Admin.Text + "-" + txtdate_Admin.Text;
            admin.date_admin = dateadmin;
            admin.password_admin = txtpassadmin.Text;
            admin.phone_admin = txtphone_Admin.Text;
            admin.photo_admin = photoADMIN;
          
          
            if (radioButtonmale_Admin.Checked == true)
            {
                string selectedgender = radioButtonmale_Admin.Text;
                admin.Gender_admin= selectedgender;

            }
            else if (radioButtonfemale_Admin.Checked == true)
            {
                string selectedgender = radioButtonfemale_Admin.Text;
                admin.Gender_admin = selectedgender;
            }



            admin.saveadmin();
        }

        private void buttongeneratestudpass_Click(object sender, EventArgs e)
        {
            string allowedChars = "";

            allowedChars = "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z,";

            allowedChars += "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,";

            allowedChars += "1,2,3,4,5,6,7,8,9,0,!,@,#,$,%,&,?";

            char[] sep = { ',' };

            string[] arr = allowedChars.Split(sep);

            string passwordString = "";

            string temp = "";

            Random rand = new Random();

            for (int i = 0; i < 6; i++)

            {

                temp = arr[rand.Next(0, arr.Length)];

                passwordString += temp;

            }

            txtpassadmin.Text = passwordString;
            txtconfirmpassadmin.Text = passwordString;
        }

        private void txtconfirmpassadmin_Leave(object sender, EventArgs e)
        {
            string pwd = txtpassadmin.Text;
            string conf = txtconfirmpassadmin.Text;
            if (pwd.CompareTo(conf) != 0)
            {
                labelnotmatchadmin.Visible = true;
            }
        }

       
    }
}
