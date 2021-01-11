
namespace WindowsFormsApp1
{
    partial class FormUpdate
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
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.txtemail = new MetroFramework.Controls.MetroTextBox();
            this.txtlname = new MetroFramework.Controls.MetroTextBox();
            this.txtfname = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(517, 193);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(134, 58);
            this.btnUpdate.Style = MetroFramework.MetroColorStyle.Red;
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnUpdate.UseCustomBackColor = true;
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtemail
            // 
            // 
            // 
            // 
            this.txtemail.CustomButton.Image = null;
            this.txtemail.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.txtemail.CustomButton.Name = "";
            this.txtemail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtemail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtemail.CustomButton.TabIndex = 1;
            this.txtemail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtemail.CustomButton.UseSelectable = true;
            this.txtemail.CustomButton.Visible = false;
            this.txtemail.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtemail.Lines = new string[0];
            this.txtemail.Location = new System.Drawing.Point(179, 268);
            this.txtemail.MaxLength = 32767;
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.PromptText = "Email";
            this.txtemail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtemail.SelectedText = "";
            this.txtemail.SelectionLength = 0;
            this.txtemail.SelectionStart = 0;
            this.txtemail.ShortcutsEnabled = true;
            this.txtemail.Size = new System.Drawing.Size(222, 23);
            this.txtemail.TabIndex = 25;
            this.txtemail.UseSelectable = true;
            this.txtemail.WaterMark = "Email";
            this.txtemail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtemail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtemail.Click += new System.EventHandler(this.txtemail_Click);
            // 
            // txtlname
            // 
            // 
            // 
            // 
            this.txtlname.CustomButton.Image = null;
            this.txtlname.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.txtlname.CustomButton.Name = "";
            this.txtlname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtlname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtlname.CustomButton.TabIndex = 1;
            this.txtlname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtlname.CustomButton.UseSelectable = true;
            this.txtlname.CustomButton.Visible = false;
            this.txtlname.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtlname.Lines = new string[0];
            this.txtlname.Location = new System.Drawing.Point(179, 211);
            this.txtlname.MaxLength = 32767;
            this.txtlname.Name = "txtlname";
            this.txtlname.PasswordChar = '\0';
            this.txtlname.PromptText = "Lastname";
            this.txtlname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtlname.SelectedText = "";
            this.txtlname.SelectionLength = 0;
            this.txtlname.SelectionStart = 0;
            this.txtlname.ShortcutsEnabled = true;
            this.txtlname.Size = new System.Drawing.Size(222, 23);
            this.txtlname.TabIndex = 24;
            this.txtlname.UseSelectable = true;
            this.txtlname.WaterMark = "Lastname";
            this.txtlname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtlname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtlname.Click += new System.EventHandler(this.txtlname_Click);
            // 
            // txtfname
            // 
            // 
            // 
            // 
            this.txtfname.CustomButton.Image = null;
            this.txtfname.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.txtfname.CustomButton.Name = "";
            this.txtfname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtfname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtfname.CustomButton.TabIndex = 1;
            this.txtfname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtfname.CustomButton.UseSelectable = true;
            this.txtfname.CustomButton.Visible = false;
            this.txtfname.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtfname.Lines = new string[0];
            this.txtfname.Location = new System.Drawing.Point(179, 159);
            this.txtfname.MaxLength = 32767;
            this.txtfname.Name = "txtfname";
            this.txtfname.PasswordChar = '\0';
            this.txtfname.PromptText = "Firstname";
            this.txtfname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtfname.SelectedText = "";
            this.txtfname.SelectionLength = 0;
            this.txtfname.SelectionStart = 0;
            this.txtfname.ShortcutsEnabled = true;
            this.txtfname.Size = new System.Drawing.Size(222, 23);
            this.txtfname.TabIndex = 23;
            this.txtfname.UseSelectable = true;
            this.txtfname.WaterMark = "Firstname";
            this.txtfname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtfname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "LName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "FName";
            // 
            // FormUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 458);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormUpdate";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Update";
            this.Load += new System.EventHandler(this.FormUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroTextBox txtemail;
        private MetroFramework.Controls.MetroTextBox txtlname;
        private MetroFramework.Controls.MetroTextBox txtfname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}