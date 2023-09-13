using Account_Registration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01labAustria
{
    public delegate long DelegateNumber(long number);
    public delegate string DelegateText(string txt);

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       
        private void btnNext_Click_Click(object sender, EventArgs e)
        {
            StudentInfoClass.StudentNo = long.Parse(tbstnum.Text);
            StudentInfoClass.Program = cbprogram.Text.ToString();
            StudentInfoClass.LastName = tblname.Text.ToString();
            StudentInfoClass.FirstName = tbfname.Text.ToString();
            StudentInfoClass.MiddleName = tbname.Text.ToString();
            StudentInfoClass.Age = long.Parse(tbage.Text);
            StudentInfoClass.ContactNo = long.Parse(tbcontact.Text);
            StudentInfoClass.Address = rtbaddress.Text.ToString();

            FrmConfirm frc = new FrmConfirm();

            DialogResult res = new DialogResult();
            res = frc.ShowDialog();
            if (res == DialogResult.OK)
            {
                cbprogram.SelectedIndex = -1;
                tbfname.Text = ""; tblname.Text = ""; tbname.Text = ""; rtbaddress.Text = "";
                tbage.Text = ""; tbstnum.Text = ""; tbcontact.Text = "";
            }
        }
    }
}
