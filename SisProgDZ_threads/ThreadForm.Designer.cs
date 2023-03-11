namespace SisProgDZ_threads
{
    partial class ThreadsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_FibonRange = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_minvalue = new System.Windows.Forms.TextBox();
            this.tb_maxvalue = new System.Windows.Forms.TextBox();
            this.btn_stopFibthread = new System.Windows.Forms.Button();
            this.btn_startFibthread = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.rtb_FibonNumbers = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_FibonRange);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_minvalue);
            this.panel1.Controls.Add(this.tb_maxvalue);
            this.panel1.Controls.Add(this.btn_stopFibthread);
            this.panel1.Controls.Add(this.btn_startFibthread);
            this.panel1.Controls.Add(this.btn_stop);
            this.panel1.Controls.Add(this.btn_start);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 172);
            this.panel1.TabIndex = 0;
            // 
            // tb_FibonRange
            // 
            this.tb_FibonRange.Location = new System.Drawing.Point(190, 111);
            this.tb_FibonRange.Name = "tb_FibonRange";
            this.tb_FibonRange.Size = new System.Drawing.Size(273, 23);
            this.tb_FibonRange.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Верхняя граница диапазона";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Нижняя граница диапазона";
            // 
            // tb_minvalue
            // 
            this.tb_minvalue.Location = new System.Drawing.Point(190, 23);
            this.tb_minvalue.Name = "tb_minvalue";
            this.tb_minvalue.Size = new System.Drawing.Size(273, 23);
            this.tb_minvalue.TabIndex = 5;
            // 
            // tb_maxvalue
            // 
            this.tb_maxvalue.Location = new System.Drawing.Point(190, 67);
            this.tb_maxvalue.Name = "tb_maxvalue";
            this.tb_maxvalue.Size = new System.Drawing.Size(273, 23);
            this.tb_maxvalue.TabIndex = 4;
            // 
            // btn_stopFibthread
            // 
            this.btn_stopFibthread.Location = new System.Drawing.Point(12, 139);
            this.btn_stopFibthread.Name = "btn_stopFibthread";
            this.btn_stopFibthread.Size = new System.Drawing.Size(126, 23);
            this.btn_stopFibthread.TabIndex = 3;
            this.btn_stopFibthread.Text = "Остановить Фибоначчи";
            this.btn_stopFibthread.UseVisualStyleBackColor = true;
            this.btn_stopFibthread.Click += new System.EventHandler(this.btn_stopFibthread_Click);
            // 
            // btn_startFibthread
            // 
            this.btn_startFibthread.Location = new System.Drawing.Point(12, 110);
            this.btn_startFibthread.Name = "btn_startFibthread";
            this.btn_startFibthread.Size = new System.Drawing.Size(126, 23);
            this.btn_startFibthread.TabIndex = 2;
            this.btn_startFibthread.Text = "Поток Фибоначчи";
            this.btn_startFibthread.UseVisualStyleBackColor = true;
            this.btn_startFibthread.Click += new System.EventHandler(this.btn_startFibthread_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(12, 41);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 1;
            this.btn_stop.Text = "Стоп";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(12, 12);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Старт";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.richTextBox1.Location = new System.Drawing.Point(0, 172);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(349, 278);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // rtb_FibonNumbers
            // 
            this.rtb_FibonNumbers.Dock = System.Windows.Forms.DockStyle.Right;
            this.rtb_FibonNumbers.Location = new System.Drawing.Point(469, 172);
            this.rtb_FibonNumbers.Name = "rtb_FibonNumbers";
            this.rtb_FibonNumbers.Size = new System.Drawing.Size(331, 278);
            this.rtb_FibonNumbers.TabIndex = 2;
            this.rtb_FibonNumbers.Text = "";
            // 
            // ThreadsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtb_FibonNumbers);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ThreadsForm";
            this.Text = "Числа и потоки";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox tb_minvalue;
        private TextBox tb_maxvalue;
        private Button btn_stopFibthread;
        private Button btn_startFibthread;
        private Button btn_stop;
        private Button btn_start;
        private RichTextBox richTextBox1;
        private TextBox tb_FibonRange;
        private RichTextBox rtb_FibonNumbers;
    }
}