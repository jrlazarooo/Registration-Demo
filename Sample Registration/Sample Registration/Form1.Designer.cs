namespace Sample_Registration
{
    partial class frmRegistration
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
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblMiddle = new System.Windows.Forms.Label();
            this.lblProgram = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtProgram = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtMiddle = new System.Windows.Forms.TextBox();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtgrRegister = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(12, 33);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(57, 13);
            this.lblFirst.TabIndex = 0;
            this.lblFirst.Text = "First Name";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(185, 33);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(58, 13);
            this.lblLast.TabIndex = 1;
            this.lblLast.Text = "Last Name";
            // 
            // lblMiddle
            // 
            this.lblMiddle.AutoSize = true;
            this.lblMiddle.Location = new System.Drawing.Point(370, 33);
            this.lblMiddle.Name = "lblMiddle";
            this.lblMiddle.Size = new System.Drawing.Size(69, 13);
            this.lblMiddle.TabIndex = 2;
            this.lblMiddle.Text = "Middle Name";
            // 
            // lblProgram
            // 
            this.lblProgram.AutoSize = true;
            this.lblProgram.Location = new System.Drawing.Point(9, 99);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(86, 13);
            this.lblProgram.TabIndex = 3;
            this.lblProgram.Text = "Colllege Program";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(341, 99);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(98, 13);
            this.lblDepartment.TabIndex = 4;
            this.lblDepartment.Text = "School Department";
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(12, 49);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(149, 20);
            this.txtFirst.TabIndex = 5;
            // 
            // txtProgram
            // 
            this.txtProgram.Location = new System.Drawing.Point(12, 115);
            this.txtProgram.Name = "txtProgram";
            this.txtProgram.Size = new System.Drawing.Size(231, 20);
            this.txtProgram.TabIndex = 8;
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(188, 49);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(149, 20);
            this.txtLast.TabIndex = 9;
            // 
            // txtMiddle
            // 
            this.txtMiddle.Location = new System.Drawing.Point(373, 49);
            this.txtMiddle.Name = "txtMiddle";
            this.txtMiddle.Size = new System.Drawing.Size(149, 20);
            this.txtMiddle.TabIndex = 10;
            // 
            // cboDepartment
            // 
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Items.AddRange(new object[] {
            "Elementary Department",
            "Junior High School department",
            "Senior High School Department",
            "School of Engineering, Architecture, and Information Technology Education",
            "School of Accountancy, Business, and Hospitality",
            "School of Education, Arts, and Sciences",
            "School of Health and Allied Sciences",
            "School of Graduate Studies and Continuing Professional Development"});
            this.cboDepartment.Location = new System.Drawing.Point(344, 114);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(280, 21);
            this.cboDepartment.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(447, 154);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(549, 154);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dtgrRegister
            // 
            this.dtgrRegister.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrRegister.BackgroundColor = System.Drawing.Color.White;
            this.dtgrRegister.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgrRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrRegister.Location = new System.Drawing.Point(15, 202);
            this.dtgrRegister.MultiSelect = false;
            this.dtgrRegister.Name = "dtgrRegister";
            this.dtgrRegister.ReadOnly = true;
            this.dtgrRegister.RowHeadersVisible = false;
            this.dtgrRegister.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dtgrRegister.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrRegister.ShowRowErrors = false;
            this.dtgrRegister.Size = new System.Drawing.Size(609, 186);
            this.dtgrRegister.TabIndex = 14;
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 491);
            this.Controls.Add(this.dtgrRegister);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboDepartment);
            this.Controls.Add(this.txtMiddle);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.txtProgram);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblProgram);
            this.Controls.Add(this.lblMiddle);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.lblFirst);
            this.Name = "frmRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sample Registration";
            this.Load += new System.EventHandler(this.frmRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblMiddle;
        private System.Windows.Forms.Label lblProgram;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtProgram;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtMiddle;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dtgrRegister;
    }
}

