namespace ListEditor
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
            this.textBox_SourceText = new System.Windows.Forms.TextBox();
            this.textBox_Prefix = new System.Windows.Forms.TextBox();
            this.textBox_Postfix = new System.Windows.Forms.TextBox();
            this.button_addPrefixPostfix = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_SourceText
            // 
            this.textBox_SourceText.Location = new System.Drawing.Point(12, 12);
            this.textBox_SourceText.Multiline = true;
            this.textBox_SourceText.Name = "textBox_SourceText";
            this.textBox_SourceText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_SourceText.Size = new System.Drawing.Size(471, 292);
            this.textBox_SourceText.TabIndex = 0;
            this.textBox_SourceText.Text = "alma\r\nkörte\r\nbarack\r\nszilva\r\nszőlő";
            this.textBox_SourceText.WordWrap = false;
            // 
            // textBox_Prefix
            // 
            this.textBox_Prefix.Location = new System.Drawing.Point(13, 41);
            this.textBox_Prefix.Name = "textBox_Prefix";
            this.textBox_Prefix.Size = new System.Drawing.Size(100, 20);
            this.textBox_Prefix.TabIndex = 1;
            this.textBox_Prefix.Text = "<a href=\"";
            // 
            // textBox_Postfix
            // 
            this.textBox_Postfix.Location = new System.Drawing.Point(132, 40);
            this.textBox_Postfix.Name = "textBox_Postfix";
            this.textBox_Postfix.Size = new System.Drawing.Size(100, 20);
            this.textBox_Postfix.TabIndex = 2;
            this.textBox_Postfix.Text = "\">[line]</a></br>";
            // 
            // button_addPrefixPostfix
            // 
            this.button_addPrefixPostfix.Location = new System.Drawing.Point(239, 40);
            this.button_addPrefixPostfix.Name = "button_addPrefixPostfix";
            this.button_addPrefixPostfix.Size = new System.Drawing.Size(75, 23);
            this.button_addPrefixPostfix.TabIndex = 3;
            this.button_addPrefixPostfix.Text = "Modify";
            this.button_addPrefixPostfix.UseVisualStyleBackColor = true;
            this.button_addPrefixPostfix.Click += new System.EventHandler(this.button_addPrefixPostfix_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Prefix:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Postfix:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_addPrefixPostfix);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_Prefix);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_Postfix);
            this.groupBox1.Location = new System.Drawing.Point(12, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 72);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add prefix and postfix to each line. (Line tag string: [line])";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 388);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_SourceText);
            this.Name = "Form1";
            this.Text = "List Editor v0.1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_SourceText;
        private System.Windows.Forms.TextBox textBox_Prefix;
        private System.Windows.Forms.TextBox textBox_Postfix;
        private System.Windows.Forms.Button button_addPrefixPostfix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

