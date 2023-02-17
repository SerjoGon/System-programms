namespace CopyAPP
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_origpath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_targetpath = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_threads = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.btn_origpath = new System.Windows.Forms.Button();
            this.btn_targetcopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Путь к файлу";
            // 
            // tb_origpath
            // 
            this.tb_origpath.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_origpath.Location = new System.Drawing.Point(12, 37);
            this.tb_origpath.Name = "tb_origpath";
            this.tb_origpath.Size = new System.Drawing.Size(665, 27);
            this.tb_origpath.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Путь к копируемому файлу";
            // 
            // tb_targetpath
            // 
            this.tb_targetpath.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_targetpath.Location = new System.Drawing.Point(12, 108);
            this.tb_targetpath.Name = "tb_targetpath";
            this.tb_targetpath.Size = new System.Drawing.Size(665, 27);
            this.tb_targetpath.TabIndex = 3;
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_start.Font = new System.Drawing.Font("Segoe Print", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_start.Location = new System.Drawing.Point(12, 212);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(776, 178);
            this.btn_start.TabIndex = 4;
            this.btn_start.Text = "Старт";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(402, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Количество потоков для копирования";
            // 
            // cb_threads
            // 
            this.cb_threads.FormattingEnabled = true;
            this.cb_threads.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cb_threads.Location = new System.Drawing.Point(12, 183);
            this.cb_threads.Name = "cb_threads";
            this.cb_threads.Size = new System.Drawing.Size(665, 23);
            this.cb_threads.TabIndex = 6;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 396);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(776, 42);
            this.progressBar1.TabIndex = 7;
            // 
            // OFD
            // 
            this.OFD.FileName = "openFileDialog1";
            // 
            // btn_origpath
            // 
            this.btn_origpath.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_origpath.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_origpath.Location = new System.Drawing.Point(683, 24);
            this.btn_origpath.Name = "btn_origpath";
            this.btn_origpath.Size = new System.Drawing.Size(105, 53);
            this.btn_origpath.TabIndex = 8;
            this.btn_origpath.Text = ">>>";
            this.btn_origpath.UseVisualStyleBackColor = false;
            this.btn_origpath.Click += new System.EventHandler(this.btn_origpath_Click);
            // 
            // btn_targetcopy
            // 
            this.btn_targetcopy.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_targetcopy.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_targetcopy.Location = new System.Drawing.Point(683, 96);
            this.btn_targetcopy.Name = "btn_targetcopy";
            this.btn_targetcopy.Size = new System.Drawing.Size(105, 52);
            this.btn_targetcopy.TabIndex = 9;
            this.btn_targetcopy.Text = "<<<";
            this.btn_targetcopy.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_targetcopy);
            this.Controls.Add(this.btn_origpath);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.cb_threads);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.tb_targetpath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_origpath);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tb_origpath;
        private Label label2;
        private TextBox tb_targetpath;
        private Button btn_start;
        private Label label3;
        private ComboBox cb_threads;
        private ProgressBar progressBar1;
        private OpenFileDialog OFD;
        private SaveFileDialog SFD;
        private Button btn_origpath;
        private Button btn_targetcopy;
    }
}