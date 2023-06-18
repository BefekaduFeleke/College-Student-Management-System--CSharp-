using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Student_Mnagement_System
{
    public class user_layer
    {
        public string username_std;
        public string email_std;
        public string password_std;
        public string fname_std;
        public string mname_std;
        public string lname_std;
        public string Gender_std;
        public string date_std;
        public string month_std;
        public string year_std;
        public byte[] photo_std;
        public string batch_std;
        public string phone_std;
        public string programme_std;
        public string department;


        public string username_teacher;
        public string email_teacher;
        public string password_teacher;
        public string fname_teacher;
        public string mname_teacher;
        public string lname_teacher;
        public string Gender_teacher;
        public string date_teacher;
        public string month_teacher;
        public string year_teacher;
        public byte[] photo_teacher;
        public string phone_teacher;
        public string edu_teacher;
        public string course_teacher;

        public string username_admin;
        public string email_admin;
        public string password_admin;
        public string fname_admin;
        public string mname_admin;
        public string lname_admin;
        public string Gender_admin;
        public string date_admin;
        public string month_admin;
        public string year_admin;
        public string phone_admin;
        public byte[] photo_admin;
        public user_layer()
        { }

        public user_layer(string email_std, string username_std, string password_std, string fname_std, string mname_std, string lname_std, string Gender_std, string date_std, string month_std, string year_std, byte[] photo_std, string batch_std, string phone_std, string programme_std, string department, string username_teacher, string email_teacher, string password_teacher, string fname_teacher, string mname_teacher, string lname_teacher, string Gender_teacher, string date_teacher, string month_teacher, string year_teacher, byte[] photo_teacher, string phone_teacher, string edu_teacher, string course_teacher, string username_admin, string email_admin, string password_admin, string fname_admin, string mname_admin, string lname_admin, string Gender_admin, string date_admin, string month_admin, string year_admin, byte[] photo_admin,string phone_admin)
        {
            this.email_std = email_std;
            this.username_std = username_std;
            this.password_std = password_std;
            this.fname_std = fname_std;
            this.mname_std = mname_std;
            this.lname_std = lname_std;
            this.Gender_std = Gender_std;
            this.date_std = date_std;
            this.month_std = month_std;
            this.year_std = year_std;
            this.photo_std = photo_std;
            this.batch_std = batch_std;
            this.phone_std = phone_std;
            this.programme_std = programme_std;
            this.department = department;

            this.email_teacher = email_teacher;
            this.username_teacher = username_teacher;
            this.password_teacher = password_teacher;
            this.fname_teacher = fname_teacher;
            this.mname_teacher = mname_teacher;
            this.lname_teacher = lname_teacher;
            this.Gender_teacher = Gender_teacher;
            this.date_teacher = date_teacher;
            this.month_teacher = month_teacher;
            this.year_teacher = year_teacher;
            this.photo_teacher = photo_teacher;
            this.phone_teacher = phone_teacher;
            this.edu_teacher = edu_teacher;
            this.course_teacher= course_teacher;

            this.username_admin = username_admin;
            this.email_admin = email_admin;
            this.password_admin = password_admin;
            this.fname_admin = fname_admin;
            this.mname_admin = mname_admin;
            this.lname_admin = lname_admin;
            this.Gender_admin = Gender_admin;
            this.date_admin = date_admin;
            this.month_admin = month_admin;
            this.year_admin = year_admin;
            this.photo_admin = photo_admin;
            this.phone_admin= phone_admin;







        }

        public void savestudent()
        {
            Database_layer ul3 = new Database_layer();
           
            ul3.savestudByStoreProc(this);
        }

        public void saveteacher()
        {
            Database_layer ul3 = new Database_layer();
            ul3.saveteacherByStoreProc(this);
        }

        public void saveadmin()
        {
            Database_layer ul3 = new Database_layer();
            ul3.saveadminByStoreProc(this);
        }

        public DataTable getstudent(string firstname, string middlename, string lastname,string idno,string batch)
        {
           Database_layer ul3 = new Database_layer();
            DataTable dt = ul3.getstudent(firstname, middlename, lastname,idno,batch);
            return dt;
        }


    }



}
    
