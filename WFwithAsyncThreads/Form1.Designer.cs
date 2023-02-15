namespace WFwithAsyncThreads
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbox_threads = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_numbthread = new System.Windows.Forms.Button();
            this.btn_letterthread = new System.Windows.Forms.Button();
            this.btn_symbthread = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btn_start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.richTextBox1.Location = new System.Drawing.Point(716, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(409, 609);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // lbox_threads
            // 
            this.lbox_threads.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbox_threads.FormattingEnabled = true;
            this.lbox_threads.ItemHeight = 15;
            this.lbox_threads.Location = new System.Drawing.Point(0, 0);
            this.lbox_threads.Name = "lbox_threads";
            this.lbox_threads.Size = new System.Drawing.Size(323, 609);
            this.lbox_threads.TabIndex = 1;
            this.lbox_threads.SelectedIndexChanged += new System.EventHandler(this.lbox_threads_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Lowest",
            "BelowNormal",
            "Normal",
            "AboveNormal",
            "Highest"});
            this.comboBox1.Location = new System.Drawing.Point(375, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(259, 23);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_numbthread
            // 
            this.btn_numbthread.Location = new System.Drawing.Point(375, 129);
            this.btn_numbthread.Name = "btn_numbthread";
            this.btn_numbthread.Size = new System.Drawing.Size(259, 23);
            this.btn_numbthread.TabIndex = 3;
            this.btn_numbthread.Text = "NumberThread";
            this.btn_numbthread.UseVisualStyleBackColor = true;
            this.btn_numbthread.Click += new System.EventHandler(this.btn_numbthread_Click);
            // 
            // btn_letterthread
            // 
            this.btn_letterthread.Location = new System.Drawing.Point(375, 222);
            this.btn_letterthread.Name = "btn_letterthread";
            this.btn_letterthread.Size = new System.Drawing.Size(259, 23);
            this.btn_letterthread.TabIndex = 4;
            this.btn_letterthread.Text = "LetterThread";
            this.btn_letterthread.UseVisualStyleBackColor = true;
            this.btn_letterthread.Click += new System.EventHandler(this.btn_letterthread_Click);
            // 
            // btn_symbthread
            // 
            this.btn_symbthread.Location = new System.Drawing.Point(375, 179);
            this.btn_symbthread.Name = "btn_symbthread";
            this.btn_symbthread.Size = new System.Drawing.Size(259, 23);
            this.btn_symbthread.TabIndex = 5;
            this.btn_symbthread.Text = "SymbThread";
            this.btn_symbthread.UseVisualStyleBackColor = true;
            this.btn_symbthread.Click += new System.EventHandler(this.btn_symbthread_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(375, 266);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(259, 23);
            this.btn_start.TabIndex = 6;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 609);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_symbthread);
            this.Controls.Add(this.btn_letterthread);
            this.Controls.Add(this.btn_numbthread);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbox_threads);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox richTextBox1;
        private ListBox lbox_threads;
        private ComboBox comboBox1;
        private Button btn_numbthread;
        private Button btn_letterthread;
        private Button btn_symbthread;
        private ColorDialog colorDialog1;
        private Button btn_start;
    }
}