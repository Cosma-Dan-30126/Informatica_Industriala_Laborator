namespace II_Lab2_P2
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
            this.Copiaza = new System.Windows.Forms.Button();
            this.Sterge = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Copiaza
            // 
            this.Copiaza.Location = new System.Drawing.Point(318, 53);
            this.Copiaza.Name = "Copiaza";
            this.Copiaza.Size = new System.Drawing.Size(75, 23);
            this.Copiaza.TabIndex = 0;
            this.Copiaza.Text = "Copiaza";
            this.Copiaza.UseVisualStyleBackColor = true;
            this.Copiaza.Click += new System.EventHandler(this.Copiaza_Click);
            // 
            // Sterge
            // 
            this.Sterge.Location = new System.Drawing.Point(318, 117);
            this.Sterge.Name = "Sterge";
            this.Sterge.Size = new System.Drawing.Size(75, 23);
            this.Sterge.TabIndex = 1;
            this.Sterge.Text = "Sterge";
            this.Sterge.UseVisualStyleBackColor = true;
            this.Sterge.Click += new System.EventHandler(this.Sterge_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(318, 359);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(42, 53);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(204, 134);
            this.listBox1.TabIndex = 3;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(472, 53);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(204, 134);
            this.listBox2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 450);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Sterge);
            this.Controls.Add(this.Copiaza);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Copiaza;
        private System.Windows.Forms.Button Sterge;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}

