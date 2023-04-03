namespace Lecutre10_Homework1
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
            this.btnCreatcontols = new System.Windows.Forms.Button();
            this.cbxControltype = new System.Windows.Forms.ComboBox();
            this.lblControlType = new System.Windows.Forms.Label();
            this.lblControlNumber = new System.Windows.Forms.Label();
            this.txtControlNumber = new System.Windows.Forms.TextBox();
            this.plnControls = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreatcontols
            // 
            this.btnCreatcontols.Location = new System.Drawing.Point(125, 142);
            this.btnCreatcontols.Name = "btnCreatcontols";
            this.btnCreatcontols.Size = new System.Drawing.Size(108, 35);
            this.btnCreatcontols.TabIndex = 0;
            this.btnCreatcontols.Text = "Create Controls";
            this.btnCreatcontols.UseVisualStyleBackColor = true;
            this.btnCreatcontols.Click += new System.EventHandler(this.btnCreatcontols_Click);
            // 
            // cbxControltype
            // 
            this.cbxControltype.FormattingEnabled = true;
            this.cbxControltype.Items.AddRange(new object[] {
            "Button",
            "TextBox",
            "Label"});
            this.cbxControltype.Location = new System.Drawing.Point(147, 60);
            this.cbxControltype.Name = "cbxControltype";
            this.cbxControltype.Size = new System.Drawing.Size(121, 21);
            this.cbxControltype.TabIndex = 1;
            this.cbxControltype.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbxControltype_DrawItem);
            // 
            // lblControlType
            // 
            this.lblControlType.AutoSize = true;
            this.lblControlType.Location = new System.Drawing.Point(51, 60);
            this.lblControlType.Name = "lblControlType";
            this.lblControlType.Size = new System.Drawing.Size(69, 13);
            this.lblControlType.TabIndex = 2;
            this.lblControlType.Text = "Control Type";
            // 
            // lblControlNumber
            // 
            this.lblControlNumber.AutoSize = true;
            this.lblControlNumber.Location = new System.Drawing.Point(42, 97);
            this.lblControlNumber.Name = "lblControlNumber";
            this.lblControlNumber.Size = new System.Drawing.Size(100, 13);
            this.lblControlNumber.TabIndex = 3;
            this.lblControlNumber.Text = "Number of Controls";
            // 
            // txtControlNumber
            // 
            this.txtControlNumber.Location = new System.Drawing.Point(148, 94);
            this.txtControlNumber.Name = "txtControlNumber";
            this.txtControlNumber.Size = new System.Drawing.Size(100, 20);
            this.txtControlNumber.TabIndex = 4;
            // 
            // plnControls
            // 
            this.plnControls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.plnControls.Location = new System.Drawing.Point(29, 205);
            this.plnControls.Name = "plnControls";
            this.plnControls.Size = new System.Drawing.Size(324, 412);
            this.plnControls.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(389, 653);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.plnControls);
            this.Controls.Add(this.txtControlNumber);
            this.Controls.Add(this.lblControlNumber);
            this.Controls.Add(this.lblControlType);
            this.Controls.Add(this.cbxControltype);
            this.Controls.Add(this.btnCreatcontols);
            this.Name = "Form1";
            this.Text = "Homework 1 Ahmed Altamari AF0530";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreatcontols;
        private System.Windows.Forms.ComboBox cbxControltype;
        private System.Windows.Forms.Label lblControlType;
        private System.Windows.Forms.Label lblControlNumber;
        private System.Windows.Forms.TextBox txtControlNumber;
        private System.Windows.Forms.Panel plnControls;
        private System.Windows.Forms.Button button1;
    }
}

