using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnumeratedTypes
{
    enum visaStatus //declare enumeration
    {
        F1, F2, F3, J1, J2, M1, M2, M3
    }
    enum emPloyeeType //stored as int datatype. 0, 1, 2 etc.
    {
        production, RnD, sales, management, maintenance
    }

    enum PhoneBrand
    {
        iPhone, LG, Samsung, HTC
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVisaTypes_Click(object sender, EventArgs e)
        {
            rtbDisplay.Text = @"The following are international students F Visa Types:
" + visaStatus.F1 + @" for full-time students.
" + visaStatus.F2 + @" for dependents of F-1 visa holders 
    (spouse and unmarried children un the age of 21).
    This includes same-sex married couples.
" + visaStatus.F3 + @" visas for 'border commuters' 
    - Mexican and Canadian students 
    who reside in their country of origin
    while attending part - or full-time - school 
    in the US.;";
        }

        private void btnEnumIntegers_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = @"Enumerators are stored in 
computer memory as integers:
";
            //foreach (visaStatus x in Enum.GetValues(typeof(visaStatus)))
            //{
            //    rtbDisplay.AppendText(x.ToString() + " is stored as " +
            //        (int)x + Environment.NewLine);
            //}
            foreach (PhoneBrand x in Enum.GetValues(typeof(PhoneBrand)))
            {
                txtDisplay.AppendText(x.ToString() + " is stored as " +
                    (int)x + Environment.NewLine);
            }
       
        }

        private void btnEnumVariables_Click(object sender, EventArgs e)
        {
            //here is how to declare a enum variable
            emPloyeeType workRole = emPloyeeType.maintenance;
            Employee newHireA = new Employee("John", workRole);
            //without the ENUM VARIABLE, Employee can be instantiated too;
            Employee HireA = new Employee("John", emPloyeeType.maintenance);
            rtbDisplay.Text = newHireA.Name + " worked in the area of " + newHireA.TypeOfWork + ".";
            //an employee could be reassigned a role
            workRole = emPloyeeType.management;
            newHireA.TypeOfWork = workRole;
            rtbDisplay.Text += @"
He now works at " + newHireA.TypeOfWork;
        }
    }
}
