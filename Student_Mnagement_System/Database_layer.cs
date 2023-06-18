using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace Student_Mnagement_System
{
    class Database_layer
    {
         string connectionString = "server=.; database=student_management;uid=lab;pwd=123;";

        public void savestudByStoreProc(user_layer student)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spInsertstud", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", student.username_std);
                    cmd.Parameters.AddWithValue("@firstname", student.fname_std);
                    cmd.Parameters.AddWithValue("@lastname", student.lname_std);
                    cmd.Parameters.AddWithValue("@middlename", student.mname_std);
                    cmd.Parameters.AddWithValue("@email", student.email_std);
                    cmd.Parameters.AddWithValue("@password", student.password_std);
                    cmd.Parameters.AddWithValue("@department", student.department);
                    cmd.Parameters.AddWithValue("@programme", student.programme_std);
                    cmd.Parameters.AddWithValue("@phone", student.phone_std);
                    cmd.Parameters.AddWithValue("@batch", student.batch_std);
                    cmd.Parameters.AddWithValue("@date", student.date_std);
                    cmd.Parameters.AddWithValue("@gender", student.Gender_std);
                    cmd.Parameters.AddWithValue("@photo", student.photo_std);

                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                        MessageBox.Show("Saved successfully!");


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void saveteacherByStoreProc(user_layer teacher)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spInsertteacher", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@usernamet", teacher.username_teacher);
                    cmd.Parameters.AddWithValue("@firstname", teacher.fname_teacher);
                    cmd.Parameters.AddWithValue("@lastname", teacher.lname_teacher);
                    cmd.Parameters.AddWithValue("@middlename", teacher.mname_teacher);
                    cmd.Parameters.AddWithValue("@email", teacher.email_teacher);
                    cmd.Parameters.AddWithValue("@password", teacher.password_teacher);
                    cmd.Parameters.AddWithValue("@edulevel", teacher.edu_teacher);
                    cmd.Parameters.AddWithValue("@courseoff", teacher.course_teacher);
                    cmd.Parameters.AddWithValue("@phone", teacher.phone_teacher);
                   
                    cmd.Parameters.AddWithValue("@date", teacher.date_teacher);
                    cmd.Parameters.AddWithValue("@gender", teacher.Gender_teacher);
                    cmd.Parameters.AddWithValue("@photo", teacher.photo_teacher);

                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                        MessageBox.Show("Saved successfully!");


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        public void saveadminByStoreProc(user_layer admin)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spInsertadmin", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", admin.username_admin);
                    cmd.Parameters.AddWithValue("@firstname", admin.fname_admin);
                    cmd.Parameters.AddWithValue("@lastname", admin.lname_admin);
                    cmd.Parameters.AddWithValue("@middlename", admin.mname_admin);
                    cmd.Parameters.AddWithValue("@email", admin.email_admin);
                    cmd.Parameters.AddWithValue("@password", admin.password_admin);
                  
                    cmd.Parameters.AddWithValue("@phone", admin.phone_admin);

                    cmd.Parameters.AddWithValue("@date", admin.date_admin);
                    cmd.Parameters.AddWithValue("@gender", admin.Gender_admin);
                    cmd.Parameters.AddWithValue("@photo", admin.photo_admin);

                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                        MessageBox.Show("Saved successfully!");


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public DataTable getstudent(string firstname, string middlename, string lastname, string idno, string batch)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter())

                {
                    da.SelectCommand = new SqlCommand("spGetstudent", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@firstname", firstname);
                    da.SelectCommand.Parameters.AddWithValue("@middlename", middlename);
                    da.SelectCommand.Parameters.AddWithValue("@lastname", lastname);
                    da.SelectCommand.Parameters.AddWithValue("@Sid", idno);
                    da.SelectCommand.Parameters.AddWithValue("@batch", batch);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "dtstudent");

                    DataTable dt = ds.Tables["dtstudent"];
                    return dt;

                }
            }


        }






    }
}
