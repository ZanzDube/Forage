using System;
using System.Windows.Forms;

namespace Lab_And_Tutor_Finder_System
{
    public partial class MainDashboardForm : Form
    {
        public MainDashboardForm()
        {
            InitializeComponent();
        }

        private void findMachineButton_Click(object sender, EventArgs e)
        {
            Hide();
            new MachinesForm().Show();
        }

        private void StudentDashboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}
