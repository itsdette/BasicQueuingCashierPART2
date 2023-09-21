namespace BasicQueuingCashier
{
    partial class CustomerView
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
            lblPosition = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPosition.Location = new Point(65, 90);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(269, 32);
            lblPosition.TabIndex = 20;
            lblPosition.Text = "Position in Queue";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(29, 33);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(154, 24);
            label1.TabIndex = 19;
            label1.Text = "*Now Serving";
            // 
            // CustomerView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(395, 178);
            Controls.Add(lblPosition);
            Controls.Add(label1);
            Name = "CustomerView";
            Text = "CustomerView";
            Load += CustomerView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPosition;
        private Label label1;
    }
}