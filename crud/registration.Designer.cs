namespace crud
{
    partial class registration
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
            label1 = new Label();
            label2 = new Label();
            txtFirstName = new TextBox();
            label3 = new Label();
            cmbCourse = new ComboBox();
            txtLastName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            cmbSection = new ComboBox();
            txtAge = new TextBox();
            label6 = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(245, 36);
            label1.Name = "label1";
            label1.Size = new Size(314, 30);
            label1.TabIndex = 0;
            label1.Text = "Register Student Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(144, 87);
            label2.Name = "label2";
            label2.Size = new Size(131, 30);
            label2.TabIndex = 0;
            label2.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(281, 87);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(364, 33);
            txtFirstName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(144, 124);
            label3.Name = "label3";
            label3.Size = new Size(128, 30);
            label3.TabIndex = 0;
            label3.Text = "Last Name:";
            // 
            // cmbCourse
            // 
            cmbCourse.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Location = new Point(282, 165);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(363, 33);
            cmbCourse.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(281, 126);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(364, 33);
            txtLastName.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(182, 168);
            label4.Name = "label4";
            label4.Size = new Size(90, 30);
            label4.TabIndex = 0;
            label4.Text = "Course:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(177, 207);
            label5.Name = "label5";
            label5.Size = new Size(95, 30);
            label5.TabIndex = 0;
            label5.Text = "Section:";
            // 
            // cmbSection
            // 
            cmbSection.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSection.FormattingEnabled = true;
            cmbSection.Location = new Point(281, 204);
            cmbSection.Name = "cmbSection";
            cmbSection.Size = new Size(363, 33);
            cmbSection.TabIndex = 2;
            cmbSection.SelectedIndexChanged += cmbSectoin_SelectedIndexChanged;
            // 
            // txtAge
            // 
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAge.Location = new Point(280, 243);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(364, 33);
            txtAge.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(212, 246);
            label6.Name = "label6";
            label6.Size = new Size(60, 30);
            label6.TabIndex = 0;
            label6.Text = "Age:";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(281, 282);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(364, 47);
            btnSave.TabIndex = 3;
            btnSave.Text = "SAVE RECORD";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(cmbSection);
            Controls.Add(label5);
            Controls.Add(cmbCourse);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(txtAge);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "registration";
            Text = "registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtFirstName;
        private Label label3;
        private ComboBox cmbCourse;
        private TextBox txtLastName;
        private Label label4;
        private Label label5;
        private ComboBox cmbSection;
        private TextBox txtAge;
        private Label label6;
        private Button btnSave;
    }
}