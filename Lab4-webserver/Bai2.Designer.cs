namespace Lab4_webserver
{
    partial class Bai2
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btDOW = new System.Windows.Forms.Button();
            this.tblink = new System.Windows.Forms.TextBox();
            this.tbfolder = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(51, 130);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(737, 294);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // btDOW
            // 
            this.btDOW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDOW.Location = new System.Drawing.Point(665, 26);
            this.btDOW.Name = "btDOW";
            this.btDOW.Size = new System.Drawing.Size(123, 41);
            this.btDOW.TabIndex = 4;
            this.btDOW.Text = "Download";
            this.btDOW.UseVisualStyleBackColor = true;
            this.btDOW.Click += new System.EventHandler(this.btDOW_Click);
            // 
            // tblink
            // 
            this.tblink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tblink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblink.Location = new System.Drawing.Point(51, 26);
            this.tblink.Multiline = true;
            this.tblink.Name = "tblink";
            this.tblink.Size = new System.Drawing.Size(559, 41);
            this.tblink.TabIndex = 3;
            // 
            // tbfolder
            // 
            this.tbfolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbfolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbfolder.Location = new System.Drawing.Point(51, 73);
            this.tbfolder.Multiline = true;
            this.tbfolder.Name = "tbfolder";
            this.tbfolder.Size = new System.Drawing.Size(559, 41);
            this.tbfolder.TabIndex = 6;
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbfolder);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btDOW);
            this.Controls.Add(this.tblink);
            this.Name = "Bai2";
            this.Text = "Bai2";
            this.Load += new System.EventHandler(this.Bai2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btDOW;
        private System.Windows.Forms.TextBox tblink;
        private System.Windows.Forms.TextBox tbfolder;
    }
}