namespace comboNet4
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboTest = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 21);
            this.button1.TabIndex = 1;
            this.button1.Text = "Click Down Arrow";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboTest
            // 
            this.comboTest.AccessibleName = "Select an element";
            this.comboTest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTest.FormattingEnabled = true;
            this.comboTest.Items.AddRange(new object[] {
            "Element 1",
            "Element 2",
            "Element 3",
            "Element 4"});
            this.comboTest.Location = new System.Drawing.Point(109, 8);
            this.comboTest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboTest.Name = "comboTest";
            this.comboTest.Size = new System.Drawing.Size(120, 21);
            this.comboTest.TabIndex = 2;
            this.comboTest.Tag = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 40);
            this.Controls.Add(this.comboTest);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Drop Down";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboTest;
    }
}

