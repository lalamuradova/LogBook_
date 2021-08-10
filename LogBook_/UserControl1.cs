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

        public EventHandler<EventArgs> DiamondClick { get; set; }
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

        public bool Attent
        {
            get { return BlueGunaRadioBtn.Checked; }
            set { BlueGunaRadioBtn.Checked = value; }
        }
        public bool Late
        {
            get { return FuchsiaGunaRadioBtn.Checked; }
            set { FuchsiaGunaRadioBtn.Checked = value; }
        }
        public bool NotAttent
        {
            get { return CrimsonGunaRadioBtn.Checked; }
            set { CrimsonGunaRadioBtn.Checked = value; }
        }

        public string Point1
        {
            get { return YoxlamaGunaCombobox.SelectedItem as string; }
            set { YoxlamaGunaCombobox.SelectedItem = value; }
        }
        public string Point2
        {
            get { return SinifIsiGunaCombobox.SelectedItem as string; }
            set { SinifIsiGunaCombobox.SelectedItem = value; }
        }
        public bool Combobox1
        {
            get { return YoxlamaGunaCombobox.Enabled; }
            set { YoxlamaGunaCombobox.Enabled = value; }
        }
        public bool Combobox2
        {
            get { return SinifIsiGunaCombobox.Enabled; }
            set { SinifIsiGunaCombobox.Enabled = value; }
        }
        public bool Diamond1
        {
            get { return Diamond1PBox.Enabled; }
            set { Diamond1PBox.Enabled = value; }
        }
        public bool Diamond2
        {
            get { return Diamond2PBox.Enabled; }
            set { Diamond2PBox.Enabled = value; }
        }
        public bool Diamond3
        {
            get { return Diamond3PBox.Enabled; }
            set { Diamond3PBox.Enabled = value; }
        }

        public bool XButton
        {
            get { return XBtn.Enabled; }
            set { XBtn.Enabled = value; }
        }
        public bool CommentPBox
        {
            get { return CommentPictureBox.Enabled; }
            set { CommentPictureBox.Enabled = value; }
        }
        public int Count { get; set; } = 0;

        public string CommentText
        {
            get
            {
                return commentTxtBox.Text;
            }
            set { commentTxtBox.Text = value; }
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
            if (Form1.StaticCount -1 >= 0)
            {
                --Form1.StaticCount ;
                var pictureBox = sender as PictureBox;
                pictureBox.Image = Properties.Resources.diamond_10_;

                Count = 1;
                DiamondClick.Invoke(sender, e);
            }
            else
            {
                MessageBox.Show("Diamond doesn't exist");
            }            

        }

        private void Diamond2PBox_Click(object sender, EventArgs e)
        {
            if (Count == 1)
            {
                if (Form1.StaticCount - 1 >= 0)
                {
                    Count = 2;
                    var pictureBox = sender as PictureBox;
                    pictureBox.Image = Properties.Resources.diamond_10_;
                    Diamond1PBox.Image = Properties.Resources.diamond_10_;
                    --Form1.StaticCount;
                }
                else
                {
                    MessageBox.Show("Diamond doesn't exist");
                }
            }
            else if (Count == 0)
            {
                if (Form1.StaticCount - 2 >= 0)
                {
                    Count = 2;
                    var pictureBox = sender as PictureBox;
                    pictureBox.Image = Properties.Resources.diamond_10_;
                    Diamond1PBox.Image = Properties.Resources.diamond_10_;
                    Form1.StaticCount-=2;
                }
            else
            {
                MessageBox.Show("Diamond doesn't exist");
            }

            }
                DiamondClick.Invoke(sender, e);
        }

        private void Diamond3PBox_Click(object sender, EventArgs e)
        {
            if (Form1.StaticCount - 1 >= 0)
            {
                Count = 3;
                var pictureBox = sender as PictureBox;
                pictureBox.Image = Properties.Resources.diamond_10_;
                Diamond1PBox.Image = Properties.Resources.diamond_10_;
                Diamond2PBox.Image = Properties.Resources.diamond_10_;
                --Form1.StaticCount;
            }
            else
            {
                MessageBox.Show("Diamond doesn't exist");
            }
        }

        
        private void XBtn_Click(object sender, EventArgs e)
        {
            Diamond1PBox.Image = Properties.Resources.indir;
            Diamond2PBox.Image = Properties.Resources.indir;
            Diamond3PBox.Image = Properties.Resources.indir;
        }

        private void BlueGunaRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            Form1.TurnOnElement(this);
        }

        private void CrimsonGunaRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            Form1.TurnOfElement(this);

        }
    }
}
