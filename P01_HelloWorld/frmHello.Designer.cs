namespace P01_HelloWorld
{
    partial class frmHello
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
            btnExit = new Button();
            label1 = new Label();
            label2 = new Label();
            tboxName = new TextBox();
            tboxLastName = new TextBox();
            lbelMessage = new Label();
            btnMessage = new Button();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExit.Location = new Point(474, 342);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(107, 45);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F);
            label1.Location = new Point(44, 35);
            label1.Name = "label1";
            label1.Size = new Size(80, 31);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F);
            label2.Location = new Point(44, 92);
            label2.Name = "label2";
            label2.Size = new Size(109, 31);
            label2.TabIndex = 2;
            label2.Text = "Surname:";
            // 
            // tboxName
            // 
            tboxName.Font = new Font("Segoe UI", 14F);
            tboxName.Location = new Point(165, 35);
            tboxName.Name = "tboxName";
            tboxName.Size = new Size(125, 39);
            tboxName.TabIndex = 3;
            // 
            // tboxLastName
            // 
            tboxLastName.Font = new Font("Segoe UI", 14F);
            tboxLastName.Location = new Point(165, 92);
            tboxLastName.Name = "tboxLastName";
            tboxLastName.Size = new Size(125, 39);
            tboxLastName.TabIndex = 4;
            // 
            // lbelMessage
            // 
            lbelMessage.AutoSize = true;
            lbelMessage.Font = new Font("Segoe UI", 14F);
            lbelMessage.Location = new Point(44, 187);
            lbelMessage.Name = "lbelMessage";
            lbelMessage.Size = new Size(78, 32);
            lbelMessage.TabIndex = 5;
            lbelMessage.Text = "label3";
            // 
            // btnMessage
            // 
            btnMessage.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            btnMessage.Location = new Point(184, 262);
            btnMessage.Name = "btnMessage";
            btnMessage.Size = new Size(123, 50);
            btnMessage.TabIndex = 6;
            btnMessage.Text = "Message";
            btnMessage.UseVisualStyleBackColor = true;
            btnMessage.Click += btnMessage_Click;
            // 
            // frmHello
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 411);
            ControlBox = false;
            Controls.Add(btnMessage);
            Controls.Add(lbelMessage);
            Controls.Add(tboxLastName);
            Controls.Add(tboxName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Name = "frmHello";
            Text = "Form Hello";
            Load += frmHello_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Label label1;
        private Label label2;
        private TextBox tboxName;
        private TextBox tboxLastName;
        private Label lbelMessage;
        private Button btnMessage;
    }
}