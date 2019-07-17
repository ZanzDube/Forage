namespace Lab_And_Tutor_Finder_System
{
    partial class ListItem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tutorNameLabel = new System.Windows.Forms.Label();
            this.tutorBioDescrLabel = new System.Windows.Forms.Label();
            this.tutorProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tutorProfilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tutorNameLabel
            // 
            this.tutorNameLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorNameLabel.Location = new System.Drawing.Point(189, 12);
            this.tutorNameLabel.Name = "tutorNameLabel";
            this.tutorNameLabel.Size = new System.Drawing.Size(600, 23);
            this.tutorNameLabel.TabIndex = 1;
            this.tutorNameLabel.Text = "Name";
            // 
            // tutorBioDescrLabel
            // 
            this.tutorBioDescrLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorBioDescrLabel.Location = new System.Drawing.Point(193, 49);
            this.tutorBioDescrLabel.Name = "tutorBioDescrLabel";
            this.tutorBioDescrLabel.Size = new System.Drawing.Size(596, 62);
            this.tutorBioDescrLabel.TabIndex = 2;
            this.tutorBioDescrLabel.Text = "Some text here blah blah blah";
            // 
            // tutorProfilePictureBox
            // 
            this.tutorProfilePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.tutorProfilePictureBox.Location = new System.Drawing.Point(20, 12);
            this.tutorProfilePictureBox.Name = "tutorProfilePictureBox";
            this.tutorProfilePictureBox.Size = new System.Drawing.Size(103, 99);
            this.tutorProfilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tutorProfilePictureBox.TabIndex = 0;
            this.tutorProfilePictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 119);
            this.panel1.TabIndex = 3;
            // 
            // ListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tutorProfilePictureBox);
            this.Controls.Add(this.tutorBioDescrLabel);
            this.Controls.Add(this.tutorNameLabel);
            this.Controls.Add(this.panel1);
            this.Name = "ListItem";
            this.Size = new System.Drawing.Size(869, 125);
            ((System.ComponentModel.ISupportInitialize)(this.tutorProfilePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox tutorProfilePictureBox;
        private System.Windows.Forms.Label tutorNameLabel;
        private System.Windows.Forms.Label tutorBioDescrLabel;
        private System.Windows.Forms.Panel panel1;
    }
}
