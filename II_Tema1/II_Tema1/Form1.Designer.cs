namespace II_Tema1
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
            this.EXIT = new System.Windows.Forms.Button();
            this.comboBoxAnimalute = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Adaugareinformatii = new System.Windows.Forms.Label();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.poza = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poza)).BeginInit();
            this.SuspendLayout();
            // 
            // EXIT
            // 
            this.EXIT.Location = new System.Drawing.Point(631, 318);
            this.EXIT.Margin = new System.Windows.Forms.Padding(1);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(86, 31);
            this.EXIT.TabIndex = 0;
            this.EXIT.Text = "EXIT!";
            this.EXIT.UseVisualStyleBackColor = true;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // comboBoxAnimalute
            // 
            this.comboBoxAnimalute.FormattingEnabled = true;
            this.comboBoxAnimalute.Location = new System.Drawing.Point(537, 75);
            this.comboBoxAnimalute.Name = "comboBoxAnimalute";
            this.comboBoxAnimalute.Size = new System.Drawing.Size(144, 21);
            this.comboBoxAnimalute.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selectare Animal";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addButtonToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(744, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addButtonToolStripMenuItem
            // 
            this.addButtonToolStripMenuItem.Name = "addButtonToolStripMenuItem";
            this.addButtonToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.addButtonToolStripMenuItem.Text = "Add Button";
            this.addButtonToolStripMenuItem.Click += new System.EventHandler(this.addButtonToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.removeToolStripMenuItem.Text = "Remove Button";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(537, 156);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(144, 121);
            this.listBox1.TabIndex = 4;
            // 
            // Adaugareinformatii
            // 
            this.Adaugareinformatii.AutoSize = true;
            this.Adaugareinformatii.Location = new System.Drawing.Point(21, 78);
            this.Adaugareinformatii.Name = "Adaugareinformatii";
            this.Adaugareinformatii.Size = new System.Drawing.Size(97, 13);
            this.Adaugareinformatii.TabIndex = 5;
            this.Adaugareinformatii.Text = "Adaugare informatii";
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(138, 75);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(119, 20);
            this.textBoxNume.TabIndex = 6;
            // 
            // poza
            // 
            this.poza.Location = new System.Drawing.Point(34, 144);
            this.poza.Name = "poza";
            this.poza.Size = new System.Drawing.Size(123, 73);
            this.poza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.poza.TabIndex = 7;
            this.poza.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 372);
            this.Controls.Add(this.poza);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(this.Adaugareinformatii);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxAnimalute);
            this.Controls.Add(this.EXIT);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.ComboBox comboBoxAnimalute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addButtonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label Adaugareinformatii;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.PictureBox poza;
    }
}

