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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public int No
        {
            get { return int.Parse(NoLbl.Text); }
            set { NoLbl.Text = value.ToString(); }
        }

        public string Fullname
        {
            get { return FullnameLbl.Text; }
            set { FullnameLbl.Text = value; }
        }

        public string Date
        {
            get { return DateLbl.Text; }
            set { DateLbl.Text = value; }
        }

        private void CommentPictureBox_Click(object sender, EventArgs e)
        {
            SaveGunaBtn.Visible = true;
            RefuseGunaBtn.Visible = true;
            CommentListBox.Visible = true;
        }
    }
}
