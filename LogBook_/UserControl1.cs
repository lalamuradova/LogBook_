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
        public string Attend()
        {
            if (BlueGunaRadioBtn.Checked == true)
            {
                return "İştirak edir";
            }
            else if (FuchsiaGunaRadioBtn.Checked == true)
            {
                return "Gecikib";
            }
            else if (CrimsonGunaRadioBtn.Checked == true)
            {
                return "Dərsdə yoxdur";
            }
            return " ";
        }

        public void Checked()
        {
            BlueGunaRadioBtn.Checked = true;
        }
        private void CommentPictureBox_Click(object sender, EventArgs e)
        {
            SaveGunaBtn.Visible = true;
            RefuseGunaBtn.Visible = true;
            commentTxtBox.Visible = true;

        }

        private void Diamond1PBox_Click(object sender, EventArgs e)
        {
            darkDiamond1PBox.Visible = true;
        }

        private void Diamond2PBox_Click(object sender, EventArgs e)
        {
            if(darkDiamond1PBox.Visible == true) 
            darkDiamond2PBox.Visible = true;
        }

        private void Diamond3PBox_Click(object sender, EventArgs e)
        {
            if (darkDiamond2PBox.Visible == true)
                darkDiamond3PBox.Visible = true;
        }

        private void darkDiamond1PBox_Click(object sender, EventArgs e)
        {
            if (darkDiamond2PBox.Visible == false)
                darkDiamond1PBox.Visible = false;
        }

        private void darkDiamond2PBox_Click(object sender, EventArgs e)
        {
            if (darkDiamond3PBox.Visible == false)
                darkDiamond2PBox.Visible = false;
        }

        private void darkDiamond3PBox_Click(object sender, EventArgs e)
        {            
                darkDiamond3PBox.Visible = false;
        }

        private void XBtn_Click(object sender, EventArgs e)
        {
            darkDiamond1PBox.Visible = false;
            darkDiamond2PBox.Visible = false;           
            darkDiamond3PBox.Visible = false;
        }

        
    }
}
