using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_And_Tutor_Finder_System
{
    public partial class ListItem : UserControl
    {
        /// <summary>
        /// Project: Forage
        /// Programmer: Emandleni Moyo s216673380@mandela.ac.za
        /// Date: 2019/07/17
        /// Description: This class creates a tutor list element.
        ///
        public ListItem()
        {
            InitializeComponent();
        }

        #region Properties
        private string _name;
        private string _description;
        private Image _profilePicture;

        [Category("Custom Properties")]
        public string Name
        {
            get { return _name; }
            set { _name = value; tutorNameLabel.Text = value; }
        }

        [Category("Custom Properties")]
        public string Description
        {
            get { return _description; }
            set { _description = value; tutorBioDescrLabel.Text = value; }
        }

        [Category("Custom Properties")]
        public Image Image
        {
            get { return _profilePicture; }
            set { _profilePicture = value; tutorProfilePictureBox.Image = value; }
        }
        

        #endregion

    }
}
