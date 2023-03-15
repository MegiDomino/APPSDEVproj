namespace WindowsFormsApplication2
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
            this.Greetings = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameInputField = new System.Windows.Forms.TextBox();
            this.lastNamenputField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Greetings
            // 
            this.Greetings.AutoSize = true;
            this.Greetings.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Greetings.Location = new System.Drawing.Point(73, 9);
            this.Greetings.Name = "Greetings";
            this.Greetings.Size = new System.Drawing.Size(178, 39);
            this.Greetings.TabIndex = 0;
            this.Greetings.Text = "Greetings!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // firstNameInputField
            // 
            this.firstNameInputField.Location = new System.Drawing.Point(102, 90);
            this.firstNameInputField.Name = "firstNameInputField";
            this.firstNameInputField.Size = new System.Drawing.Size(100, 20);
            this.firstNameInputField.TabIndex = 2;
            this.firstNameInputField.Text = "as";
            this.firstNameInputField.TextChanged += new System.EventHandler(this.firstNameInputField_TextChanged);
            // 
            // lastNamenputField
            // 
            this.lastNamenputField.Location = new System.Drawing.Point(102, 142);
            this.lastNamenputField.Name = "lastNamenputField";
            this.lastNamenputField.Size = new System.Drawing.Size(100, 20);
            this.lastNamenputField.TabIndex = 4;
            this.lastNamenputField.TextChanged += new System.EventHandler(this.lastNamenputField_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(102, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 323);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lastNamenputField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstNameInputField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Greetings);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Greetings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstNameInputField;
        private System.Windows.Forms.TextBox lastNamenputField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

