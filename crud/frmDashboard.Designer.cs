namespace crud
{
    partial class frmDashboard
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
            btnRegister = new Button();
            btnStudentList = new Button();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.BackColor = SystemColors.ButtonFace;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(38, 144);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(375, 71);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "REGISTER STUDENT";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnStudentList
            // 
            btnStudentList.BackColor = SystemColors.ButtonFace;
            btnStudentList.FlatStyle = FlatStyle.Flat;
            btnStudentList.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudentList.Location = new Point(437, 144);
            btnStudentList.Name = "btnStudentList";
            btnStudentList.Size = new Size(375, 71);
            btnStudentList.TabIndex = 0;
            btnStudentList.Text = "STUDENT LIST";
            btnStudentList.UseVisualStyleBackColor = false;
            btnStudentList.Click += btnStudentList_Click;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 392);
            Controls.Add(btnStudentList);
            Controls.Add(btnRegister);
            Name = "frmDashboard";
            Text = "frmDashboard";
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Button btnStudentList;
        private Button btnRegister;
    }
}