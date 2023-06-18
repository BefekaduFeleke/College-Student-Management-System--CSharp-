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
    public partial class Teacher_registration : Form
    {
        public Teacher_registration()
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
                pictureBox_teacher.Image = Image.FromFile(op.FileName);


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
            txtfirstname_teacher.Text = "";
            txtmiddlename_teacher.Text = "";
            txtlastname_teacher.Text = "";
            txtdate_teacher.Text = "";
            txtmonth_teacher.Text = "";
            txtyear_teacher.Text = "";
            txtphone_teacher.Text = "";
            txtpassteacher.Text = "";
            txtconfirmpassteacher.Text = "";
            txtemail_teacher.Text = "";
            radioButtonmale_teacher.Checked = false;
            radioButtonfemale_teacher.Checked = false;
            txtteacherid.Text = "";
            comboBoxcourseoffer.Text = "";
            comboBoxedulevel.Text = "";

            pictureBox_teacher.Image = null;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox_teacher.Image.Save(ms, pictureBox_teacher.Image.RawFormat);
            byte[] phototeacher = ms.ToArray();

            MessageBox.Show("save successful. A Teacher has been registered.");
            user_layer teacher = new user_layer();
            teacher.username_teacher = txtteacherid.Text;
            teacher.email_teacher = txtemail_teacher.Text;
            teacher.fname_teacher = txtfirstname_teacher.Text;
            teacher.mname_teacher = txtmiddlename_teacher.Text;
            teacher.lname_teacher = txtlastname_teacher.Text;
            string dateteacher = txtyear_teacher.Text + "-" + txtmonth_teacher.Text + "-" + txtdate_teacher.Text;
            teacher.date_teacher = dateteacher;   
            teacher.password_teacher = txtpassteacher.Text;
          teacher.phone_teacher = txtphone_teacher.Text;
            teacher.photo_teacher = phototeacher;
            string eduselected = this.comboBoxedulevel.GetItemText(this.comboBoxedulevel.SelectedItem);
            string coursesele= this.comboBoxcourseoffer.GetItemText(this.comboBoxcourseoffer.SelectedItem);
            teacher.edu_teacher = eduselected;
            teacher.course_teacher = coursesele;
            if (radioButtonmale_teacher.Checked == true)
            {
                string selectedgender = radioButtonmale_teacher.Text;
                teacher.Gender_teacher = selectedgender;

            }   
            else if (radioButtonfemale_teacher.Checked == true)
            {
                string selectedgender = radioButtonfemale_teacher.Text;
                teacher.Gender_teacher = selectedgender;
            }



            teacher.saveteacher();
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

            txtpassteacher.Text = passwordString;
            txtconfirmpassteacher.Text = passwordString;
        }

        private void txtconfirmpassteacher_Leave(object sender, EventArgs e)
        {
            string pwd = txtpassteacher.Text;
            string conf = txtconfirmpassteacher.Text;
            if (pwd.CompareTo(conf) != 0)
            {
                labelnotmatchteacher.Visible = true;
            }
        }

        private void radioButtonmasters_teacher_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonphd_teacher_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonbach_teacher_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
