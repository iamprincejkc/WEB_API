
namespace WindowsFormsApp1
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnrefresh = new MetroFramework.Controls.MetroButton();
            this.txtfname = new MetroFramework.Controls.MetroTextBox();
            this.txtlname = new MetroFramework.Controls.MetroTextBox();
            this.txtemail = new MetroFramework.Controls.MetroTextBox();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.dgvTest = new MetroFramework.Controls.MetroGrid();
            this.txtsearch = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "FName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "LName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(721, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(1190, 262);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(134, 36);
            this.btnrefresh.Style = MetroFramework.MetroColorStyle.Red;
            this.btnrefresh.TabIndex = 9;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnrefresh.UseCustomBackColor = true;
            this.btnrefresh.UseSelectable = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
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
            this.txtfname.Location = new System.Drawing.Point(96, 87);
            this.txtfname.MaxLength = 32767;
            this.txtfname.Name = "txtfname";
            this.txtfname.PasswordChar = '\0';
            this.txtfname.PromptText = "Firstname";
            this.txtfname.ReadOnly = true;
            this.txtfname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtfname.SelectedText = "";
            this.txtfname.SelectionLength = 0;
            this.txtfname.SelectionStart = 0;
            this.txtfname.ShortcutsEnabled = true;
            this.txtfname.Size = new System.Drawing.Size(222, 23);
            this.txtfname.TabIndex = 10;
            this.txtfname.UseSelectable = true;
            this.txtfname.WaterMark = "Firstname";
            this.txtfname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtfname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtlname.Location = new System.Drawing.Point(429, 87);
            this.txtlname.MaxLength = 32767;
            this.txtlname.Name = "txtlname";
            this.txtlname.PasswordChar = '\0';
            this.txtlname.PromptText = "Lastname";
            this.txtlname.ReadOnly = true;
            this.txtlname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtlname.SelectedText = "";
            this.txtlname.SelectionLength = 0;
            this.txtlname.SelectionStart = 0;
            this.txtlname.ShortcutsEnabled = true;
            this.txtlname.Size = new System.Drawing.Size(222, 23);
            this.txtlname.TabIndex = 11;
            this.txtlname.UseSelectable = true;
            this.txtlname.WaterMark = "Lastname";
            this.txtlname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtlname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtemail.Location = new System.Drawing.Point(768, 87);
            this.txtemail.MaxLength = 32767;
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.PromptText = "Email";
            this.txtemail.ReadOnly = true;
            this.txtemail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtemail.SelectedText = "";
            this.txtemail.SelectionLength = 0;
            this.txtemail.SelectionStart = 0;
            this.txtemail.ShortcutsEnabled = true;
            this.txtemail.Size = new System.Drawing.Size(222, 23);
            this.txtemail.TabIndex = 12;
            this.txtemail.UseSelectable = true;
            this.txtemail.WaterMark = "Email";
            this.txtemail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtemail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1057, 78);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(134, 36);
            this.btnClear.Style = MetroFramework.MetroColorStyle.Red;
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnClear.UseCustomBackColor = true;
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(165, 177);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 36);
            this.btnAdd.Style = MetroFramework.MetroColorStyle.Red;
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Insert";
            this.btnAdd.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnAdd.UseCustomBackColor = true;
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(404, 177);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(134, 36);
            this.btnUpdate.Style = MetroFramework.MetroColorStyle.Red;
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnUpdate.UseCustomBackColor = true;
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(643, 177);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 36);
            this.btnDelete.Style = MetroFramework.MetroColorStyle.Red;
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnDelete.UseCustomBackColor = true;
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvTest
            // 
            this.dgvTest.AllowUserToResizeRows = false;
            this.dgvTest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTest.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTest.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvTest.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvTest.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvTest.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTest.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvTest.EnableHeadersVisualStyles = false;
            this.dgvTest.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvTest.GridColor = System.Drawing.Color.Black;
            this.dgvTest.Location = new System.Drawing.Point(59, 304);
            this.dgvTest.Name = "dgvTest";
            this.dgvTest.ReadOnly = true;
            this.dgvTest.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTest.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvTest.RowHeadersVisible = false;
            this.dgvTest.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTest.ShowEditingIcon = false;
            this.dgvTest.Size = new System.Drawing.Size(1265, 338);
            this.dgvTest.TabIndex = 17;
            this.dgvTest.UseCustomBackColor = true;
            this.dgvTest.UseCustomForeColor = true;
            this.dgvTest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTest_CellClick);
            this.dgvTest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTest_CellContentClick);
            this.dgvTest.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTest_CellContentDoubleClick);
            this.dgvTest.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTest_CellDoubleClick);
            // 
            // txtsearch
            // 
            this.txtsearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtsearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txtsearch.CustomButton.Image = null;
            this.txtsearch.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.txtsearch.CustomButton.Name = "";
            this.txtsearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtsearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtsearch.CustomButton.TabIndex = 1;
            this.txtsearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtsearch.CustomButton.UseSelectable = true;
            this.txtsearch.CustomButton.Visible = false;
            this.txtsearch.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtsearch.Lines = new string[0];
            this.txtsearch.Location = new System.Drawing.Point(59, 275);
            this.txtsearch.MaxLength = 32767;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.PasswordChar = '\0';
            this.txtsearch.PromptText = "Search . . .";
            this.txtsearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtsearch.SelectedText = "";
            this.txtsearch.SelectionLength = 0;
            this.txtsearch.SelectionStart = 0;
            this.txtsearch.ShortcutsEnabled = true;
            this.txtsearch.Size = new System.Drawing.Size(222, 23);
            this.txtsearch.TabIndex = 18;
            this.txtsearch.UseSelectable = true;
            this.txtsearch.WaterMark = "Search . . .";
            this.txtsearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtsearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            this.txtsearch.Click += new System.EventHandler(this.txtsearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 687);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.dgvTest);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Test . . .";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroButton btnrefresh;
        private MetroFramework.Controls.MetroTextBox txtfname;
        private MetroFramework.Controls.MetroTextBox txtlname;
        private MetroFramework.Controls.MetroTextBox txtemail;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroGrid dgvTest;
        private MetroFramework.Controls.MetroTextBox txtsearch;
    }
}

