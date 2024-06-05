namespace SpeechRecognition
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
            this.label1 = new System.Windows.Forms.Label();
            this.EnableBtn = new System.Windows.Forms.Button();
            this.DisableBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.LabelCommandList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "CS2 Voice Recognition\r\n";
            // 
            // EnableBtn
            // 
            this.EnableBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnableBtn.Location = new System.Drawing.Point(262, 209);
            this.EnableBtn.Name = "EnableBtn";
            this.EnableBtn.Size = new System.Drawing.Size(134, 46);
            this.EnableBtn.TabIndex = 1;
            this.EnableBtn.Text = "Enable Voice Control";
            this.EnableBtn.UseVisualStyleBackColor = true;
            this.EnableBtn.Click += new System.EventHandler(this.EnableBtn_Click);
            // 
            // DisableBtn
            // 
            this.DisableBtn.Enabled = false;
            this.DisableBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisableBtn.Location = new System.Drawing.Point(262, 261);
            this.DisableBtn.Name = "DisableBtn";
            this.DisableBtn.Size = new System.Drawing.Size(134, 46);
            this.DisableBtn.TabIndex = 2;
            this.DisableBtn.Text = "Disable Voice Control";
            this.DisableBtn.UseVisualStyleBackColor = true;
            this.DisableBtn.Click += new System.EventHandler(this.DisableBtn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(24, 56);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(218, 238);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = " *Voice Logs*";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // LabelCommandList
            // 
            this.LabelCommandList.AutoSize = true;
            this.LabelCommandList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCommandList.Location = new System.Drawing.Point(259, 57);
            this.LabelCommandList.Name = "LabelCommandList";
            this.LabelCommandList.Size = new System.Drawing.Size(110, 128);
            this.LabelCommandList.TabIndex = 4;
            this.LabelCommandList.Text = "List of Command\r\n\r\n*Print My Name\r\n*Hi\r\n*Hello World\r\n*Time Check\r\n*Open NotePad\r" +
    "\n*Open Facebook";
            this.LabelCommandList.Click += new System.EventHandler(this.LabelCommandList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(420, 319);
            this.Controls.Add(this.LabelCommandList);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.DisableBtn);
            this.Controls.Add(this.EnableBtn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EnableBtn;
        private System.Windows.Forms.Button DisableBtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label LabelCommandList;
    }
}

