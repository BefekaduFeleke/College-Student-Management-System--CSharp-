
namespace Student_Mnagement_System
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1_slide = new System.Windows.Forms.Panel();
            this.panel1_logo = new System.Windows.Forms.Panel();
            this.button1_std = new System.Windows.Forms.Button();
            this.panel_stdsubmenu = new System.Windows.Forms.Panel();
            this.button_registration = new System.Windows.Forms.Button();
            this.button_managestudent = new System.Windows.Forms.Button();
            this.button_status = new System.Windows.Forms.Button();
            this.button_stdprint = new System.Windows.Forms.Button();
            this.panel_courseSubmenu = new System.Windows.Forms.Panel();
            this.panel_scoresubmenu = new System.Windows.Forms.Panel();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_course = new System.Windows.Forms.Button();
            this.button_courseprint = new System.Windows.Forms.Button();
            this.button_managecourse = new System.Windows.Forms.Button();
            this.button_newcourse = new System.Windows.Forms.Button();
            this.button_scoreprint = new System.Windows.Forms.Button();
            this.button_managescore = new System.Windows.Forms.Button();
            this.button_newscore = new System.Windows.Forms.Button();
            this.button_score = new System.Windows.Forms.Button();
            this.panel1_slide.SuspendLayout();
            this.panel_stdsubmenu.SuspendLayout();
            this.panel_courseSubmenu.SuspendLayout();
            this.panel_scoresubmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1_slide
            // 
            this.panel1_slide.AutoScroll = true;
            this.panel1_slide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1_slide.Controls.Add(this.button_exit);
            this.panel1_slide.Controls.Add(this.panel_scoresubmenu);
            this.panel1_slide.Controls.Add(this.panel_courseSubmenu);
            this.panel1_slide.Controls.Add(this.panel_stdsubmenu);
            this.panel1_slide.Controls.Add(this.button1_std);
            this.panel1_slide.Controls.Add(this.panel1_logo);
            this.panel1_slide.Location = new System.Drawing.Point(-7, 1);
            this.panel1_slide.Name = "panel1_slide";
            this.panel1_slide.Size = new System.Drawing.Size(263, 800);
            this.panel1_slide.TabIndex = 0;
            this.panel1_slide.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel1_logo
            // 
            this.panel1_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1_logo.Location = new System.Drawing.Point(0, 0);
            this.panel1_logo.Name = "panel1_logo";
            this.panel1_logo.Size = new System.Drawing.Size(237, 132);
            this.panel1_logo.TabIndex = 0;
            // 
            // button1_std
            // 
            this.button1_std.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1_std.FlatAppearance.BorderSize = 0;
            this.button1_std.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_std.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_std.ForeColor = System.Drawing.Color.White;
            this.button1_std.Location = new System.Drawing.Point(0, 132);
            this.button1_std.Name = "button1_std";
            this.button1_std.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1_std.Size = new System.Drawing.Size(237, 51);
            this.button1_std.TabIndex = 1;
            this.button1_std.Text = "Student";
            this.button1_std.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1_std.UseVisualStyleBackColor = true;
            // 
            // panel_stdsubmenu
            // 
            this.panel_stdsubmenu.Controls.Add(this.button_stdprint);
            this.panel_stdsubmenu.Controls.Add(this.button_status);
            this.panel_stdsubmenu.Controls.Add(this.button_managestudent);
            this.panel_stdsubmenu.Controls.Add(this.button_registration);
            this.panel_stdsubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_stdsubmenu.Location = new System.Drawing.Point(0, 183);
            this.panel_stdsubmenu.Name = "panel_stdsubmenu";
            this.panel_stdsubmenu.Size = new System.Drawing.Size(237, 234);
            this.panel_stdsubmenu.TabIndex = 2;
            // 
            // button_registration
            // 
            this.button_registration.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_registration.FlatAppearance.BorderSize = 0;
            this.button_registration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_registration.Font = new System.Drawing.Font("Segoe UI Symbol", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_registration.ForeColor = System.Drawing.Color.White;
            this.button_registration.Location = new System.Drawing.Point(0, 0);
            this.button_registration.Name = "button_registration";
            this.button_registration.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_registration.Size = new System.Drawing.Size(237, 54);
            this.button_registration.TabIndex = 0;
            this.button_registration.Text = "Registration";
            this.button_registration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_registration.UseVisualStyleBackColor = true;
            // 
            // button_managestudent
            // 
            this.button_managestudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_managestudent.FlatAppearance.BorderSize = 0;
            this.button_managestudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_managestudent.Font = new System.Drawing.Font("Segoe UI Symbol", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_managestudent.ForeColor = System.Drawing.Color.White;
            this.button_managestudent.Location = new System.Drawing.Point(0, 54);
            this.button_managestudent.Name = "button_managestudent";
            this.button_managestudent.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_managestudent.Size = new System.Drawing.Size(237, 54);
            this.button_managestudent.TabIndex = 1;
            this.button_managestudent.Text = "Manage Student";
            this.button_managestudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_managestudent.UseVisualStyleBackColor = true;
            // 
            // button_status
            // 
            this.button_status.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_status.FlatAppearance.BorderSize = 0;
            this.button_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_status.Font = new System.Drawing.Font("Segoe UI Symbol", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_status.ForeColor = System.Drawing.Color.White;
            this.button_status.Location = new System.Drawing.Point(0, 108);
            this.button_status.Name = "button_status";
            this.button_status.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_status.Size = new System.Drawing.Size(237, 54);
            this.button_status.TabIndex = 2;
            this.button_status.Text = "Status";
            this.button_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_status.UseVisualStyleBackColor = true;
            // 
            // button_stdprint
            // 
            this.button_stdprint.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_stdprint.FlatAppearance.BorderSize = 0;
            this.button_stdprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_stdprint.Font = new System.Drawing.Font("Segoe UI Symbol", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stdprint.ForeColor = System.Drawing.Color.White;
            this.button_stdprint.Location = new System.Drawing.Point(0, 162);
            this.button_stdprint.Name = "button_stdprint";
            this.button_stdprint.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_stdprint.Size = new System.Drawing.Size(237, 54);
            this.button_stdprint.TabIndex = 3;
            this.button_stdprint.Text = "Print";
            this.button_stdprint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_stdprint.UseVisualStyleBackColor = true;
            // 
            // panel_courseSubmenu
            // 
            this.panel_courseSubmenu.Controls.Add(this.button_courseprint);
            this.panel_courseSubmenu.Controls.Add(this.button_managecourse);
            this.panel_courseSubmenu.Controls.Add(this.button_newcourse);
            this.panel_courseSubmenu.Controls.Add(this.button_course);
            this.panel_courseSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_courseSubmenu.Location = new System.Drawing.Point(0, 417);
            this.panel_courseSubmenu.Name = "panel_courseSubmenu";
            this.panel_courseSubmenu.Size = new System.Drawing.Size(237, 223);
            this.panel_courseSubmenu.TabIndex = 4;
            // 
            // panel_scoresubmenu
            // 
            this.panel_scoresubmenu.Controls.Add(this.button_scoreprint);
            this.panel_scoresubmenu.Controls.Add(this.button_managescore);
            this.panel_scoresubmenu.Controls.Add(this.button_newscore);
            this.panel_scoresubmenu.Controls.Add(this.button_score);
            this.panel_scoresubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_scoresubmenu.Location = new System.Drawing.Point(0, 640);
            this.panel_scoresubmenu.Name = "panel_scoresubmenu";
            this.panel_scoresubmenu.Size = new System.Drawing.Size(237, 204);
            this.panel_scoresubmenu.TabIndex = 6;
            // 
            // button_exit
            // 
            this.button_exit.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_exit.FlatAppearance.BorderSize = 0;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.ForeColor = System.Drawing.Color.White;
            this.button_exit.Location = new System.Drawing.Point(0, 844);
            this.button_exit.Name = "button_exit";
            this.button_exit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_exit.Size = new System.Drawing.Size(237, 51);
            this.button_exit.TabIndex = 7;
            this.button_exit.Text = "Exit";
            this.button_exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_exit.UseVisualStyleBackColor = true;
            // 
            // button_course
            // 
            this.button_course.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_course.FlatAppearance.BorderSize = 0;
            this.button_course.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_course.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_course.ForeColor = System.Drawing.Color.White;
            this.button_course.Location = new System.Drawing.Point(0, 0);
            this.button_course.Name = "button_course";
            this.button_course.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_course.Size = new System.Drawing.Size(237, 51);
            this.button_course.TabIndex = 2;
            this.button_course.Text = "Course";
            this.button_course.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_course.UseVisualStyleBackColor = true;
            this.button_course.Click += new System.EventHandler(this.button5_Click);
            // 
            // button_courseprint
            // 
            this.button_courseprint.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_courseprint.FlatAppearance.BorderSize = 0;
            this.button_courseprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_courseprint.Font = new System.Drawing.Font("Segoe UI Symbol", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_courseprint.ForeColor = System.Drawing.Color.White;
            this.button_courseprint.Location = new System.Drawing.Point(0, 159);
            this.button_courseprint.Name = "button_courseprint";
            this.button_courseprint.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_courseprint.Size = new System.Drawing.Size(237, 54);
            this.button_courseprint.TabIndex = 6;
            this.button_courseprint.Text = "Print";
            this.button_courseprint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_courseprint.UseVisualStyleBackColor = true;
            // 
            // button_managecourse
            // 
            this.button_managecourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_managecourse.FlatAppearance.BorderSize = 0;
            this.button_managecourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_managecourse.Font = new System.Drawing.Font("Segoe UI Symbol", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_managecourse.ForeColor = System.Drawing.Color.White;
            this.button_managecourse.Location = new System.Drawing.Point(0, 105);
            this.button_managecourse.Name = "button_managecourse";
            this.button_managecourse.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_managecourse.Size = new System.Drawing.Size(237, 54);
            this.button_managecourse.TabIndex = 5;
            this.button_managecourse.Text = "Manage Course";
            this.button_managecourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_managecourse.UseVisualStyleBackColor = true;
            // 
            // button_newcourse
            // 
            this.button_newcourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_newcourse.FlatAppearance.BorderSize = 0;
            this.button_newcourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_newcourse.Font = new System.Drawing.Font("Segoe UI Symbol", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_newcourse.ForeColor = System.Drawing.Color.White;
            this.button_newcourse.Location = new System.Drawing.Point(0, 51);
            this.button_newcourse.Name = "button_newcourse";
            this.button_newcourse.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_newcourse.Size = new System.Drawing.Size(237, 54);
            this.button_newcourse.TabIndex = 4;
            this.button_newcourse.Text = "New Course";
            this.button_newcourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_newcourse.UseVisualStyleBackColor = true;
            // 
            // button_scoreprint
            // 
            this.button_scoreprint.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_scoreprint.FlatAppearance.BorderSize = 0;
            this.button_scoreprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_scoreprint.Font = new System.Drawing.Font("Segoe UI Symbol", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_scoreprint.ForeColor = System.Drawing.Color.White;
            this.button_scoreprint.Location = new System.Drawing.Point(0, 159);
            this.button_scoreprint.Name = "button_scoreprint";
            this.button_scoreprint.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_scoreprint.Size = new System.Drawing.Size(237, 54);
            this.button_scoreprint.TabIndex = 10;
            this.button_scoreprint.Text = "Print";
            this.button_scoreprint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_scoreprint.UseVisualStyleBackColor = true;
            // 
            // button_managescore
            // 
            this.button_managescore.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_managescore.FlatAppearance.BorderSize = 0;
            this.button_managescore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_managescore.Font = new System.Drawing.Font("Segoe UI Symbol", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_managescore.ForeColor = System.Drawing.Color.White;
            this.button_managescore.Location = new System.Drawing.Point(0, 105);
            this.button_managescore.Name = "button_managescore";
            this.button_managescore.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_managescore.Size = new System.Drawing.Size(237, 54);
            this.button_managescore.TabIndex = 9;
            this.button_managescore.Text = "Manage Score";
            this.button_managescore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_managescore.UseVisualStyleBackColor = true;
            // 
            // button_newscore
            // 
            this.button_newscore.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_newscore.FlatAppearance.BorderSize = 0;
            this.button_newscore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_newscore.Font = new System.Drawing.Font("Segoe UI Symbol", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_newscore.ForeColor = System.Drawing.Color.White;
            this.button_newscore.Location = new System.Drawing.Point(0, 51);
            this.button_newscore.Name = "button_newscore";
            this.button_newscore.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_newscore.Size = new System.Drawing.Size(237, 54);
            this.button_newscore.TabIndex = 8;
            this.button_newscore.Text = "New Score";
            this.button_newscore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_newscore.UseVisualStyleBackColor = true;
            // 
            // button_score
            // 
            this.button_score.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_score.FlatAppearance.BorderSize = 0;
            this.button_score.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_score.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_score.ForeColor = System.Drawing.Color.White;
            this.button_score.Location = new System.Drawing.Point(0, 0);
            this.button_score.Name = "button_score";
            this.button_score.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_score.Size = new System.Drawing.Size(237, 51);
            this.button_score.TabIndex = 7;
            this.button_score.Text = "Score";
            this.button_score.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_score.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1299, 818);
            this.Controls.Add(this.panel1_slide);
            this.MinimumSize = new System.Drawing.Size(1321, 874);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1_slide.ResumeLayout(false);
            this.panel_stdsubmenu.ResumeLayout(false);
            this.panel_courseSubmenu.ResumeLayout(false);
            this.panel_scoresubmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1_slide;
        private System.Windows.Forms.Panel panel_stdsubmenu;
        private System.Windows.Forms.Button button_stdprint;
        private System.Windows.Forms.Button button_status;
        private System.Windows.Forms.Button button_managestudent;
        private System.Windows.Forms.Button button_registration;
        private System.Windows.Forms.Button button1_std;
        private System.Windows.Forms.Panel panel1_logo;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Panel panel_scoresubmenu;
        private System.Windows.Forms.Panel panel_courseSubmenu;
        private System.Windows.Forms.Button button_courseprint;
        private System.Windows.Forms.Button button_managecourse;
        private System.Windows.Forms.Button button_newcourse;
        private System.Windows.Forms.Button button_course;
        private System.Windows.Forms.Button button_scoreprint;
        private System.Windows.Forms.Button button_managescore;
        private System.Windows.Forms.Button button_newscore;
        private System.Windows.Forms.Button button_score;
    }
}

