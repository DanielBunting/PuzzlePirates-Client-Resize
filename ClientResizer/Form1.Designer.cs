namespace ClientResizer
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
            this.Ocean = new System.Windows.Forms.ComboBox();
            this.PirateName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Width = new System.Windows.Forms.NumericUpDown();
            this.Height = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Resize = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Height)).BeginInit();
            this.SuspendLayout();
            // 
            // Ocean
            // 
            this.Ocean.FormattingEnabled = true;
            this.Ocean.Items.AddRange(new object[] {
            "Emerald",
            "Meridian",
            "Cerulean"});
            this.Ocean.Location = new System.Drawing.Point(89, 32);
            this.Ocean.Name = "Ocean";
            this.Ocean.Size = new System.Drawing.Size(121, 21);
            this.Ocean.TabIndex = 0;
            // 
            // PirateName
            // 
            this.PirateName.Location = new System.Drawing.Point(89, 6);
            this.PirateName.Name = "PirateName";
            this.PirateName.Size = new System.Drawing.Size(121, 20);
            this.PirateName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pirate Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ocean:";
            // 
            // Width
            // 
            this.Width.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Width.Location = new System.Drawing.Point(89, 82);
            this.Width.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.Width.Minimum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(120, 20);
            this.Width.TabIndex = 4;
            this.Width.Value = new decimal(new int[] {
            1600,
            0,
            0,
            0});
            // 
            // Height
            // 
            this.Height.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Height.Location = new System.Drawing.Point(89, 108);
            this.Height.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.Height.Minimum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(120, 20);
            this.Height.TabIndex = 5;
            this.Height.Value = new decimal(new int[] {
            900,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Width:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Height:";
            // 
            // Resize
            // 
            this.Resize.Location = new System.Drawing.Point(15, 138);
            this.Resize.Name = "Resize";
            this.Resize.Size = new System.Drawing.Size(191, 23);
            this.Resize.TabIndex = 8;
            this.Resize.Text = "Resize";
            this.Resize.UseVisualStyleBackColor = true;
            this.Resize.Click += new System.EventHandler(this.Resize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 173);
            this.Controls.Add(this.Resize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PirateName);
            this.Controls.Add(this.Ocean);
            this.Name = "Form1";
            this.Text = "Resizer";
            ((System.ComponentModel.ISupportInitialize)(this.Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Height)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Ocean;
        private System.Windows.Forms.TextBox PirateName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Width;
        private System.Windows.Forms.NumericUpDown Height;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Resize;
    }
}

