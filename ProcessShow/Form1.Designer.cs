namespace ProcessShow
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
            this.components = new System.ComponentModel.Container();
            this.listbox_process = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_timeStart = new System.Windows.Forms.Label();
            this.lb_procID = new System.Windows.Forms.Label();
            this.lbl_procTime = new System.Windows.Forms.Label();
            this.lbl_threadcount = new System.Windows.Forms.Label();
            this.lbl_proccopy = new System.Windows.Forms.Label();
            this.btn_killproc = new System.Windows.Forms.Button();
            this.lbl_heshcode = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_createnewproc = new System.Windows.Forms.Button();
            this.tb_createnewproc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listbox_process
            // 
            this.listbox_process.FormattingEnabled = true;
            this.listbox_process.ItemHeight = 15;
            this.listbox_process.Location = new System.Drawing.Point(0, 30);
            this.listbox_process.Name = "listbox_process";
            this.listbox_process.Size = new System.Drawing.Size(603, 424);
            this.listbox_process.TabIndex = 0;
            this.listbox_process.SelectedIndexChanged += new System.EventHandler(this.lb_process_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(398, 23);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(404, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(517, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "TimerIntervalSet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(672, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Process Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(609, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Process ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(609, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Время старта";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(609, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Thread Count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(609, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Process Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(609, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Process copy";
            // 
            // lbl_timeStart
            // 
            this.lbl_timeStart.AutoSize = true;
            this.lbl_timeStart.Location = new System.Drawing.Point(705, 84);
            this.lbl_timeStart.Name = "lbl_timeStart";
            this.lbl_timeStart.Size = new System.Drawing.Size(0, 15);
            this.lbl_timeStart.TabIndex = 11;
            // 
            // lb_procID
            // 
            this.lb_procID.AutoSize = true;
            this.lb_procID.Location = new System.Drawing.Point(705, 60);
            this.lb_procID.Name = "lb_procID";
            this.lb_procID.Size = new System.Drawing.Size(0, 15);
            this.lb_procID.TabIndex = 10;
            // 
            // lbl_procTime
            // 
            this.lbl_procTime.AutoSize = true;
            this.lbl_procTime.Location = new System.Drawing.Point(705, 109);
            this.lbl_procTime.Name = "lbl_procTime";
            this.lbl_procTime.Size = new System.Drawing.Size(0, 15);
            this.lbl_procTime.TabIndex = 12;
            // 
            // lbl_threadcount
            // 
            this.lbl_threadcount.AutoSize = true;
            this.lbl_threadcount.Location = new System.Drawing.Point(705, 133);
            this.lbl_threadcount.Name = "lbl_threadcount";
            this.lbl_threadcount.Size = new System.Drawing.Size(0, 15);
            this.lbl_threadcount.TabIndex = 13;
            // 
            // lbl_proccopy
            // 
            this.lbl_proccopy.AutoSize = true;
            this.lbl_proccopy.Location = new System.Drawing.Point(705, 158);
            this.lbl_proccopy.Name = "lbl_proccopy";
            this.lbl_proccopy.Size = new System.Drawing.Size(0, 15);
            this.lbl_proccopy.TabIndex = 14;
            // 
            // btn_killproc
            // 
            this.btn_killproc.Location = new System.Drawing.Point(609, 219);
            this.btn_killproc.Name = "btn_killproc";
            this.btn_killproc.Size = new System.Drawing.Size(191, 23);
            this.btn_killproc.TabIndex = 15;
            this.btn_killproc.Text = "Завершить процесс";
            this.btn_killproc.UseVisualStyleBackColor = true;
            this.btn_killproc.Click += new System.EventHandler(this.btn_killproc_Click);
            // 
            // lbl_heshcode
            // 
            this.lbl_heshcode.AutoSize = true;
            this.lbl_heshcode.Location = new System.Drawing.Point(762, 183);
            this.lbl_heshcode.Name = "lbl_heshcode";
            this.lbl_heshcode.Size = new System.Drawing.Size(0, 15);
            this.lbl_heshcode.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(609, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Process HashCode";
            // 
            // btn_createnewproc
            // 
            this.btn_createnewproc.Enabled = false;
            this.btn_createnewproc.Location = new System.Drawing.Point(609, 330);
            this.btn_createnewproc.Name = "btn_createnewproc";
            this.btn_createnewproc.Size = new System.Drawing.Size(312, 23);
            this.btn_createnewproc.TabIndex = 18;
            this.btn_createnewproc.Text = "Запустить новый процесс";
            this.btn_createnewproc.UseVisualStyleBackColor = true;
            this.btn_createnewproc.Click += new System.EventHandler(this.btn_createnewproc_Click);
            // 
            // tb_createnewproc
            // 
            this.tb_createnewproc.Location = new System.Drawing.Point(609, 301);
            this.tb_createnewproc.Name = "tb_createnewproc";
            this.tb_createnewproc.Size = new System.Drawing.Size(312, 23);
            this.tb_createnewproc.TabIndex = 19;
            this.tb_createnewproc.TextChanged += new System.EventHandler(this.tb_createnewproc_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.tb_createnewproc);
            this.Controls.Add(this.btn_createnewproc);
            this.Controls.Add(this.lbl_heshcode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_killproc);
            this.Controls.Add(this.lbl_proccopy);
            this.Controls.Add(this.lbl_threadcount);
            this.Controls.Add(this.lbl_procTime);
            this.Controls.Add(this.lbl_timeStart);
            this.Controls.Add(this.lb_procID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listbox_process);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listbox_process;
        private System.Windows.Forms.Timer timer1;
        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label lbl_timeStart;
        private Label lb_procID;
        private Label lbl_procTime;
        private Label lbl_threadcount;
        private Label lbl_proccopy;
        private Button btn_killproc;
        private Label lbl_heshcode;
        private Label label8;
        private Button btn_createnewproc;
        private TextBox tb_createnewproc;
    }
}