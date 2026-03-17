namespace crud
{
    partial class MasterList
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
            txtSearch = new TextBox();
            btnSearch = new Button();
            dataGridView1 = new DataGridView();
            btnRefresh = new Button();
            cmbSection = new ComboBox();
            label5 = new Label();
            cmbCourse = new ComboBox();
            label4 = new Label();
            label6 = new Label();
            label3 = new Label();
            txtAge = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label2 = new Label();
            label7 = new Label();
            txtId = new TextBox();
            label8 = new Label();
            btnSave = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 111);
            label1.Name = "label1";
            label1.Size = new Size(234, 28);
            label1.TabIndex = 0;
            label1.Text = "STUDENT MASTER LIST";
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(42, 173);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(317, 29);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ButtonShadow;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(367, 167);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(104, 45);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 228);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(560, 396);
            dataGridView1.TabIndex = 3;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.ButtonShadow;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(496, 103);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(104, 45);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "REFRESH";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // cmbSection
            // 
            cmbSection.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSection.FormattingEnabled = true;
            cmbSection.Items.AddRange(new object[] { "1-A", "1-B", "1-C", "1-D", "1-E", "1-F", "1-G", "1-H" });
            cmbSection.Location = new Point(808, 377);
            cmbSection.Margin = new Padding(3, 4, 3, 4);
            cmbSection.Name = "cmbSection";
            cmbSection.Size = new Size(301, 33);
            cmbSection.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(689, 381);
            label5.Name = "label5";
            label5.Size = new Size(95, 30);
            label5.TabIndex = 4;
            label5.Text = "Section:";
            // 
            // cmbCourse
            // 
            cmbCourse.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Items.AddRange(new object[] { "ACT", "BSOA", "BSBA", "HM" });
            cmbCourse.Location = new Point(809, 325);
            cmbCourse.Margin = new Padding(3, 4, 3, 4);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(300, 33);
            cmbCourse.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(695, 329);
            label4.Name = "label4";
            label4.Size = new Size(90, 30);
            label4.TabIndex = 5;
            label4.Text = "Course:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(729, 433);
            label6.Name = "label6";
            label6.Size = new Size(60, 30);
            label6.TabIndex = 6;
            label6.Text = "Age:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(651, 271);
            label3.Name = "label3";
            label3.Size = new Size(128, 30);
            label3.TabIndex = 7;
            label3.Text = "Last Name:";
            // 
            // txtAge
            // 
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAge.Location = new Point(807, 429);
            txtAge.Margin = new Padding(3, 4, 3, 4);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(303, 33);
            txtAge.TabIndex = 10;
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(808, 273);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(301, 33);
            txtLastName.TabIndex = 11;
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(808, 221);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(301, 33);
            txtFirstName.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(651, 221);
            label2.Name = "label2";
            label2.Size = new Size(131, 30);
            label2.TabIndex = 8;
            label2.Text = "First Name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(770, 103);
            label7.Name = "label7";
            label7.Size = new Size(362, 30);
            label7.TabIndex = 9;
            label7.Text = "UPDATE STUDENT INFORMATION";
            // 
            // txtId
            // 
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(808, 169);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(301, 33);
            txtId.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(750, 173);
            label8.Name = "label8";
            label8.Size = new Size(42, 30);
            label8.TabIndex = 8;
            label8.Text = "ID:";
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ButtonShadow;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(807, 481);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(303, 65);
            btnSave.TabIndex = 2;
            btnSave.Text = "SAVE RECORD";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ButtonShadow;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(807, 555);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(303, 65);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "DELETE RECORD";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // MasterList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 732);
            Controls.Add(cmbSection);
            Controls.Add(label5);
            Controls.Add(cmbCourse);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(txtAge);
            Controls.Add(txtLastName);
            Controls.Add(txtId);
            Controls.Add(txtFirstName);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnRefresh);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MasterList";
            Text = "MasterList";
            Load += MasterList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView dataGridView1;
        private Button btnRefresh;
        private ComboBox cmbSection;
        private Label label5;
        private ComboBox cmbCourse;
        private Label label4;
        private Label label6;
        private Label label3;
        private TextBox txtAge;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label2;
        private Label label7;
        private TextBox txtId;
        private Label label8;
        private Button btnSave;
        private Button btnDelete;
    }
}