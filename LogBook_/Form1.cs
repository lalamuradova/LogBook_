using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogBook_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadUserControl();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(150, 200, 250);

        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.FromArgb(60, 2, 112);
        }

        private void SaveGunaBtn_Click(object sender, EventArgs e)
        {

        }

        private void TeacherradioBtn_CheckedChanged(object sender, EventArgs e)
        {
            VisibleChoise();
            TeacherLbl.Visible = true;
        }
        public void VisibleChoise()
        {
            label2.Visible = true;
            SubjectlistBox.Visible = true;
            SaveGunaBtn.Visible = true;
            RefuseGunaBtn.Visible = true;
            penPictureBox.Visible = true;
        }

        private void SecondTeacherRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            VisibleChoise();
            TeacherNameLBl.Visible = true;
            TeacherNameTxtBox.Visible = true;
        }

        public void LoadUserControl()
        {
            User user1 = new User()
            {
                Fullname = "Muradova Lala",
                Date = DateTime.Today,
            };

            User user2 = new User()
            {
                Fullname = "Xelilzade Rafael",
                Date = DateTime.Now,
            };

            User user3 = new User()
            {
                Fullname = "Mustafayev Ruslan",
                Date = DateTime.Today,
            };

            User user4 = new User()
            {
                Fullname = "Eliyev Kamran",
                Date = DateTime.Now,
            };

            User user5 = new User()
            {
                Fullname = "Rustamli Huseyn",
                Date = DateTime.Now,
            };




            List<User> users = new List<User>();
            users.Add(user1);
            users.Add(user2);
            users.Add(user3);
            users.Add(user4);
            users.Add(user5);

            int y = 149;
            int no = 1;
            foreach (var user in users)
            {
                UserControl1 userControl1 = new UserControl1();
                userControl1.No = no++;
                userControl1.Fullname = user.Fullname;
                userControl1.Date = user.Date.ToLongDateString();                

                userControl1.Location = new Point(0, y);
                y += 70;
                this.Controls.Add(userControl1);
            }
        }
    }
}
