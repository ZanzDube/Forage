using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_And_Tutor_Finder_System
{
    static class Program
    {
        /// <summary>
        /// Project: Forage
        /// Programmer: Emandleni Moyo s216673380@mandela.ac.za
        /// Date: 2019/07/11
        /// Description: This program is used to locate vacant machines in computer labs and pair students with tutors.
        /// </summary>
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Launch();            
        }
        private static void Launch()
        {
            Application.Run(new LoginForm());
            //Application.Run(new StudentDashboardForm());
            //Application.Run(new MachinesForm());
            //Application.Run(new TutorDashboardForm());
        }
    }
}
