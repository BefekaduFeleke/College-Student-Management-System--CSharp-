using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Mnagement_System
{
    public partial class Grader : Form
    {
        public Grader()
        {
            InitializeComponent();
        }

        private void buttongeneratestudpass_Click(object sender, EventArgs e)
        {
            string AAmin ="95" ;   string AAmax = "100";
            string Amin = "90"; string Amax = "94";
            string BBmax = "89"; string BBmin = "85";
            string Bmin = "80"; string Bmax = "84";
            string Ccmin = "75"; string Ccmax = "79";
            string cmin = "70"; string cmax = "74";
            string Dmin = "60"; string Dmax = "69";
            string Fmin = "0"; string Fmax = "59";


            txtAplusmin.Text = AAmin;
            txtAplusmax.Text = AAmax;
            txtA.Text = Amin;
            txtAmax.Text = Amax;
            txtBplusmax.Text = BBmax;
            txtBplusmin.Text = BBmin;
            txtB.Text = Bmin;
            txtBmax.Text = Bmax;
            txtCplusmax.Text = Ccmax;
            txtCplusmin.Text = Ccmin;
            txtC.Text = cmin;
            txtCmax.Text = cmax;
            txtD.Text = Dmin;
            textDmax.Text = Dmax;
            txtf.Text = Fmin;
            txtfmax.Text = Fmax;


        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void buttonregister__teacher_Click(object sender, EventArgs e)
        {

        }
    }
}
