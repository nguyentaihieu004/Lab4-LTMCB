namespace Lab4_webserver
{
    partial class Bai1
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
            this.tblink = new System.Windows.Forms.TextBox();
            this.btGET = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tblink
            // 
            this.tblink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tblink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblink.Location = new System.Drawing.Point(55, 26);
            this.tblink.Multiline = true;
            this.tblink.Name = "tblink";
            this.tblink.Size = new System.Drawing.Size(559, 41);
            this.tblink.TabIndex = 0;
            // 
            // btGET
            // 
            this.btGET.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGET.Location = new System.Drawing.Point(669, 26);
            this.btGET.Name = "btGET";
            this.btGET.Size = new System.Drawing.Size(84, 41);
            this.btGET.TabIndex = 1;
            this.btGET.Text = "GET";
            this.btGET.UseVisualStyleBackColor = true;
            this.btGET.Click += new System.EventHandler(this.btGET_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(55, 96);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(698, 328);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btGET);
            this.Controls.Add(this.tblink);
            this.Name = "Bai1";
            this.Text = "Bai1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tblink;
        private System.Windows.Forms.Button btGET;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}