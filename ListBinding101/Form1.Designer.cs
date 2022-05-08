namespace ListBinding101
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
            this.btnExit = new System.Windows.Forms.Button();
            this.comboBoxPeople = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxPerson = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(558, 396);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // comboBoxPeople
            // 
            this.comboBoxPeople.FormattingEnabled = true;
            this.comboBoxPeople.Location = new System.Drawing.Point(23, 36);
            this.comboBoxPeople.Name = "comboBoxPeople";
            this.comboBoxPeople.Size = new System.Drawing.Size(383, 23);
            this.comboBoxPeople.TabIndex = 1;
            this.comboBoxPeople.SelectedIndexChanged += new System.EventHandler(this.comboBoxPeople_SelectedIndexChanged);
            
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(69, 86);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(270, 23);
            this.txtName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // listBoxPerson
            // 
            this.listBoxPerson.FormattingEnabled = true;
            this.listBoxPerson.ItemHeight = 15;
            this.listBoxPerson.Location = new System.Drawing.Point(41, 219);
            this.listBoxPerson.Name = "listBoxPerson";
            this.listBoxPerson.Size = new System.Drawing.Size(347, 199);
            this.listBoxPerson.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 431);
            this.Controls.Add(this.listBoxPerson);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.comboBoxPeople);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnExit;
        private ComboBox comboBoxPeople;
        private TextBox txtName;
        private Label label1;
        private ListBox listBoxPerson;
    }
}