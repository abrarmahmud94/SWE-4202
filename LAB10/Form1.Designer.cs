namespace LAB10
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
            this.userInfo = new System.Windows.Forms.ListBox();
            this.phonenumbertxtbox = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.showinfolabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userInfo
            // 
            this.userInfo.FormattingEnabled = true;
            this.userInfo.ItemHeight = 16;
            this.userInfo.Location = new System.Drawing.Point(38, 23);
            this.userInfo.Name = "userInfo";
            this.userInfo.Size = new System.Drawing.Size(421, 484);
            this.userInfo.TabIndex = 0;
            // 
            // phonenumbertxtbox
            // 
            this.phonenumbertxtbox.Location = new System.Drawing.Point(828, 63);
            this.phonenumbertxtbox.Name = "phonenumbertxtbox";
            this.phonenumbertxtbox.Size = new System.Drawing.Size(378, 22);
            this.phonenumbertxtbox.TabIndex = 1;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(922, 116);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(174, 42);
            this.Search.TabIndex = 2;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // showinfolabel
            // 
            this.showinfolabel.Location = new System.Drawing.Point(780, 218);
            this.showinfolabel.Name = "showinfolabel";
            this.showinfolabel.Size = new System.Drawing.Size(457, 266);
            this.showinfolabel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 539);
            this.Controls.Add(this.showinfolabel);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.phonenumbertxtbox);
            this.Controls.Add(this.userInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox userInfo;
        private System.Windows.Forms.TextBox phonenumbertxtbox;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label showinfolabel;
    }
}

