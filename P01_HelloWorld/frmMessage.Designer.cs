namespace P01_HelloWorld
{
    partial class frmMessage
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
            lblMessage = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 14F);
            lblMessage.Location = new Point(60, 50);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(80, 32);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "YOOO";
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.Font = new Font("Segoe UI", 10F);
            btnClose.Location = new Point(323, 125);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 42);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmMessage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 190);
            ControlBox = false;
            Controls.Add(btnClose);
            Controls.Add(lblMessage);
            Name = "frmMessage";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Messgae";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Label lblMessage;
        private Button btnClose;
    }
}