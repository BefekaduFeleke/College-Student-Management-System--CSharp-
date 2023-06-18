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
    public partial class Student_registration : Form
    {
        public Student_registration()
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
                pictureBoxstudpic.Image = Image.FromFile(op.FileName);


            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtfirstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

            txtpassstud.Text = passwordString;
            txtconfirmpassstud.Text= passwordString;
        }

        private void txtpassstud_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click_1(object sender, EventArgs e)
        {

        }

        private void txtconfirmpassstud_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txtconfirmpassstud_Leave(object sender, EventArgs e)
        {
            string pwd = txtpassstud.Text;
            string conf = txtconfirmpassstud.Text;
            if (pwd.CompareTo(conf) != 0)
            {
                labelnotmatchstud.Visible = true;
            }
        }

        private void pictureBoxstudpic_Click(object sender, EventArgs e)
        {

        }
        private void comboBoxbatch_SelectedValueChanged(object sender, EventArgs e)
        {
            
                string selected_item_batch = comboBoxbatch.GetItemText(comboBoxbatch.SelectedItem);


            
        }
        private void buttonregister_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBoxstudpic.Image.Save(ms, pictureBoxstudpic.Image.RawFormat);
            byte[] photostd = ms.ToArray();

            MessageBox.Show("save successful. A student has been registered.");
            user_layer student = new user_layer();
            student.username_std = txtstudentID.Text;
            student.email_std = txtemail.Text;
            student.fname_std = txtfirstname.Text;
            student.mname_std = txtmiddlename.Text;
            student.lname_std = txtlastname.Text;
            string datestudent = txtyear.Text + "-" + txtmonth.Text + "-"+ txtdate.Text;
            student.date_std = datestudent;
            student.password_std = txtpassstud.Text;
            student.phone_std = txtphone.Text;
            student.photo_std = photostd;
            string batch_selected = this.comboBoxbatch.GetItemText(this.comboBoxbatch.SelectedItem);
            string department_selected = this.comboBoxdep.GetItemText(this.comboBoxdep.SelectedItem);
            student.batch_std = batch_selected;
                student.department = department_selected;
            if (radioButtonmale.Checked == true)
            {
                string selectedgender = radioButtonmale.Text;
                student.Gender_std = selectedgender;

            }
            else if (radioButtonfemale.Checked == true)
            {
                string selectedgender = radioButtonfemale.Text;
                student.Gender_std = selectedgender;
            }
            string programme_selected = this.comboBoxprogramme.GetItemText(this.comboBoxprogramme.SelectedItem);
            student.programme_std = programme_selected;

            student.savestudent();

        }

        private void buttonclearstud_Click(object sender, EventArgs e)
        {
            txtfirstname.Text = "";
            txtmiddlename.Text= "";
            txtlastname.Text = "";
            txtdate.Text = "";
            txtmonth.Text = "";
            txtyear.Text = "";
            txtphone.Text = "";
            txtpassstud.Text = "";
            txtconfirmpassstud.Text = "";
            txtemail.Text = "";
            comboBoxprogramme.Text = "";
            comboBoxbatch.Text = "";
            radioButtonmale.Checked = false;
            radioButtonfemale.Checked = false;
            txtstudentID.Text = "";
            comboBoxdep.Text = "";
            pictureBoxstudpic.Image = null;



        }
    }
}
