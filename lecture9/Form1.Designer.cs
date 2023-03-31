namespace lecture9
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddStudent = new Button();
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            txtid = new TextBox();
            dotBirth = new DateTimePicker();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(111, 267);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(169, 68);
            btnAddStudent.TabIndex = 0;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 94);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 1;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 130);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(133, 130);
            txtName.Name = "txtName";
            txtName.Size = new Size(197, 23);
            txtName.TabIndex = 3;
            // 
            // txtid
            // 
            txtid.Location = new Point(133, 86);
            txtid.Name = "txtid";
            txtid.Size = new Size(100, 23);
            txtid.TabIndex = 4;
            // 
            // dotBirth
            // 
            dotBirth.Location = new Point(133, 208);
            dotBirth.Name = "dotBirth";
            dotBirth.Size = new Size(200, 23);
            dotBirth.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 210);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 6;
            label3.Text = "DoB";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 429);
            Controls.Add(label3);
            Controls.Add(dotBirth);
            Controls.Add(txtid);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAddStudent);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddStudent;
        private Label label1;
        private Label label2;
        private TextBox txtName;
        private TextBox txtid;
        private DateTimePicker dotBirth;
        private Label label3;
    }
}