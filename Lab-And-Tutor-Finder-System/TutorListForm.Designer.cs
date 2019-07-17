namespace Lab_And_Tutor_Finder_System
{
    partial class TutorListForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TutorListForm));
            this.tutorListPanel = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.listItem1 = new Lab_And_Tutor_Finder_System.ListItem();
            this.tutorListPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tutorListPanel
            // 
            this.tutorListPanel.Controls.Add(this.listItem1);
            this.tutorListPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.tutorListPanel.Location = new System.Drawing.Point(206, 0);
            this.tutorListPanel.Name = "tutorListPanel";
            this.tutorListPanel.Size = new System.Drawing.Size(895, 461);
            this.tutorListPanel.TabIndex = 0;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(200, 461);
            this.panel.TabIndex = 0;
            // 
            // listItem1
            // 
            this.listItem1.Description = "Hey you I am the the description";
            this.listItem1.Image = ((System.Drawing.Image)(resources.GetObject("listItem1.Image")));
            this.listItem1.Location = new System.Drawing.Point(0, 3);
            this.listItem1.Name = "listItem1";
            this.listItem1.Size = new System.Drawing.Size(892, 128);
            this.listItem1.TabIndex = 0;
            // 
            // TutorListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1101, 461);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.tutorListPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TutorListForm";
            this.tutorListPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel tutorListPanel;
        private System.Windows.Forms.Panel panel;
        private ListItem listItem1;
    }
}