namespace SisProgDZ_threads
{
    partial class FibonThreadForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.fibon_RTB = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 100);
            this.panel1.TabIndex = 0;
            // 
            // fibon_RTB
            // 
            this.fibon_RTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fibon_RTB.Location = new System.Drawing.Point(0, 100);
            this.fibon_RTB.Name = "fibon_RTB";
            this.fibon_RTB.Size = new System.Drawing.Size(328, 487);
            this.fibon_RTB.TabIndex = 1;
            this.fibon_RTB.Text = "";
            // 
            // FibonThreadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 587);
            this.Controls.Add(this.fibon_RTB);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FibonThreadForm";
            this.Text = "FibonThreadForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        public RichTextBox fibon_RTB;
    }
}