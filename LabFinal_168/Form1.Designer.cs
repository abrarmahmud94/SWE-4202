namespace LabFinal_168
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
            this.resultlistbox = new System.Windows.Forms.ListBox();
            this.studentidtextbox = new System.Windows.Forms.TextBox();
            this.informationlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultlistbox
            // 
            this.resultlistbox.FormattingEnabled = true;
            this.resultlistbox.ItemHeight = 16;
            this.resultlistbox.Location = new System.Drawing.Point(65, 132);
            this.resultlistbox.Name = "resultlistbox";
            this.resultlistbox.Size = new System.Drawing.Size(721, 372);
            this.resultlistbox.TabIndex = 0;
            // 
            // studentidtextbox
            // 
            this.studentidtextbox.Location = new System.Drawing.Point(891, 70);
            this.studentidtextbox.Name = "studentidtextbox";
            this.studentidtextbox.Size = new System.Drawing.Size(371, 22);
            this.studentidtextbox.TabIndex = 1;
            // 
            // informationlabel
            // 
            this.informationlabel.Location = new System.Drawing.Point(862, 202);
            this.informationlabel.Name = "informationlabel";
            this.informationlabel.Size = new System.Drawing.Size(490, 302);
            this.informationlabel.TabIndex = 2;
            this.informationlabel.Text = "Information Showing Label";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(328, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "IUT Result Processing System";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(214, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(325, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Course Name: Object Oriented Concepts I";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(980, 529);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Developed By : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(1103, 522);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "200042168";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(968, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Search By ID";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 558);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.informationlabel);
            this.Controls.Add(this.studentidtextbox);
            this.Controls.Add(this.resultlistbox);
            this.Name = "Form1";
            this.Text = "IUT result Processing System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox resultlistbox;
        private System.Windows.Forms.TextBox studentidtextbox;
        private System.Windows.Forms.Label informationlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

