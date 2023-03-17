namespace WF_HW_Mod3_task3_4
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
            this.btn_filefind = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbl_count = new System.Windows.Forms.Label();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_filefind
            // 
            this.btn_filefind.Location = new System.Drawing.Point(12, 12);
            this.btn_filefind.Name = "btn_filefind";
            this.btn_filefind.Size = new System.Drawing.Size(140, 23);
            this.btn_filefind.TabIndex = 0;
            this.btn_filefind.Text = "Выбор файла";
            this.btn_filefind.UseVisualStyleBackColor = true;
            this.btn_filefind.Click += new System.EventHandler(this.btn_filefind_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(187, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "test";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 131);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 307);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Location = new System.Drawing.Point(250, 72);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(0, 15);
            this.lbl_count.TabIndex = 3;
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Location = new System.Drawing.Point(12, 72);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(178, 21);
            this.lbl_1.TabIndex = 4;
            this.lbl_1.Text = "Количество повторений слова";
            this.lbl_1.UseCompatibleTextRendering = true;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(12, 46);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 5;
            this.btn_start.Text = "Поиск";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_filefind);
            this.Name = "Form1";
            this.Text = "Ищу слова в текстовом файле";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_filefind;
        private TextBox textBox1;
        private RichTextBox richTextBox1;
        private Label lbl_count;
        private Label lbl_1;
        private Button btn_start;
    }
}