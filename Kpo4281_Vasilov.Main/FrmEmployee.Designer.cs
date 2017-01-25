namespace Kpo4281.Vasilov.Main
{
    partial class FrmEmployee
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
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxInitials = new System.Windows.Forms.TextBox();
            this.textBoxBirth = new System.Windows.Forms.TextBox();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(12, 26);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(181, 22);
            this.textBoxSurname.TabIndex = 0;
            // 
            // textBoxInitials
            // 
            this.textBoxInitials.Location = new System.Drawing.Point(12, 78);
            this.textBoxInitials.Name = "textBoxInitials";
            this.textBoxInitials.Size = new System.Drawing.Size(181, 22);
            this.textBoxInitials.TabIndex = 1;
            // 
            // textBoxBirth
            // 
            this.textBoxBirth.Location = new System.Drawing.Point(12, 129);
            this.textBoxBirth.Name = "textBoxBirth";
            this.textBoxBirth.Size = new System.Drawing.Size(181, 22);
            this.textBoxBirth.TabIndex = 2;
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(12, 179);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(181, 22);
            this.textBoxSalary.TabIndex = 3;
            // 
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 229);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.textBoxBirth);
            this.Controls.Add(this.textBoxInitials);
            this.Controls.Add(this.textBoxSurname);
            this.Name = "FrmEmployee";
            this.Text = "Сотрудник";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEmployee_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmEmployee_FormClosed);
            this.Load += new System.EventHandler(this.FrmEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxInitials;
        private System.Windows.Forms.TextBox textBoxBirth;
        private System.Windows.Forms.TextBox textBoxSalary;
    }
}