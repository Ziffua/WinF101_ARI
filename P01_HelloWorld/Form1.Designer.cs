namespace P01_HelloWorld
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
            btnMsg = new Button();
            btnExit = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnMsg
            // 
            btnMsg.Font = new Font("Microsoft Sans Serif", 14F);
            btnMsg.Location = new Point(66, 119);
            btnMsg.Name = "btnMsg";
            btnMsg.Size = new Size(167, 67);
            btnMsg.TabIndex = 0;
            btnMsg.Text = "Send Message";
            btnMsg.UseVisualStyleBackColor = true;
            btnMsg.Click += btnMsg_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExit.Font = new Font("Impact", 14F);
            btnExit.Location = new Point(533, 316);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(104, 34);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += Kapat;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 31);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 404);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnMsg);
            Name = "Form1";
            Text = "Hello World";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMsg;
        private Button btnExit;
        private Label label1;
    }
}
