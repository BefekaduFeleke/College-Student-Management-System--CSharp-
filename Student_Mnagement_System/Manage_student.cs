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
    public partial class Manage_student : Form
    {
        public Manage_student()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttongeneratestudpass_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void txtpassstud_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txtstudentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxbatch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void buttonregister_Click(object sender, EventArgs e)
        {

        }

        private void buttonclearstud_Click(object sender, EventArgs e)
        {

        }

        private void buttonbrowsephotostud_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "choose Photo(*.jpg;*.png;*.Jpeg;*.bmp;)|*.jpg;*.png;*.Jpeg;*.bmp;";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBoxstudpic.Image = Image.FromFile(op.FileName);


            }
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxstudpic_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxdep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtlastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmiddlename_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfirstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonfemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonmale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxprogramme_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttongeneratestudpass_Click_1(object sender, EventArgs e)
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
            txtconfpass.Text = passwordString;
        }

        private void Manage_student_Load(object sender, EventArgs e)
        {

        }

        private void dgvstudent_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtstudentID.Text = dgvstudent.CurrentRow.Cells[0].Value.ToString();
            txtfirstname.Text = dgvstudent.CurrentRow.Cells[1].Value.ToString();
            txtmiddlename.Text = dgvstudent.CurrentRow.Cells[2].Value.ToString();
            txtlastname.Text = dgvstudent.CurrentRow.Cells[3].Value.ToString();
            string gender = dgvstudent.CurrentRow.Cells[4].Value.ToString();
            if (gender == "Male")
                radioButtonmale.Checked = true;
            else
                radioButtonmale.Checked = false;
            comboBoxdep.Text=dgvstudent.CurrentRow.Cells[5].Value.ToString();
            byte[] photo = (byte[]) dgvstudent.CurrentRow.Cells[6].Value;
            MemoryStream ms = new MemoryStream(photo);
            pictureBoxstudpic.Image = Image.FromStream(ms);

            txtpassstud.Text = dgvstudent.CurrentRow.Cells[7].Value.ToString();
            txtconfpass.Text = dgvstudent.CurrentRow.Cells[7].Value.ToString();
            comboBoxbatch.Text = dgvstudent.CurrentRow.Cells[8].Value.ToString();
            txtphone.Text = dgvstudent.CurrentRow.Cells[9].Value.ToString();
            txtemail.Text = dgvstudent.CurrentRow.Cells[10].Value.ToString();
           string strdate = dgvstudent.CurrentRow.Cells[11].Value.ToString();
            string[] arrdate = strdate.Split('/');
            txtdate.Text = arrdate[0].ToString();
            txtmonth.Text = arrdate[1].ToString();
             string unn= arrdate[2].ToString();
            string[] unnn = unn.Split(' ');
            txtyear.Text = unnn[0].ToString();


            comboBoxprogramme.Text= dgvstudent.CurrentRow.Cells[12].Value.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            user_layer student = new user_layer();
            DataTable dt = student.getstudent(txtfirststudsearch.Text, txtmiddlestudsearch.Text, txtlaststudsearch.Text, txtidsearch.Text, combobatchsearch.Text);
            dgvstudent.DataSource = dt;
        }
    }
}
