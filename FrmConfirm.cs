using System;
using Account_Registration;
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
    public partial class FrmConfirm : Form
    {
        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;

        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblcontact_Click(object sender, EventArgs e)
        {

        }

        private void lblage_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        public FrmConfirm()
        {
            InitializeComponent();
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);
            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelNumContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);




            lblstnum.Text = DelStudNo(StudentInfoClass.StudentNo).ToString();
            lblprogram.Text = DelProgram(StudentInfoClass.Program);
            lbllname.Text = DelLastName(StudentInfoClass.LastName);
            lblfname.Text = DelFirstName(StudentInfoClass.FirstName);
            lblmname.Text = DelMiddleName(StudentInfoClass.MiddleName);
            lblage.Text = DelNumAge(StudentInfoClass.Age).ToString();
            lblcontact.Text = DelNumContactNo(StudentInfoClass.ContactNo).ToString();
            lbladdress.Text = DelAddress(StudentInfoClass.Address);

        }


        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            

        
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void FrmConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}

