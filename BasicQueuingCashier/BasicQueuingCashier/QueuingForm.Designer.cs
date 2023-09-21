namespace BasicQueuingCashier
{
    partial class QueuingForm
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
            label2 = new Label();
            lblQueue = new Label();
            label1 = new Label();
            btnCashier = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(28, 180);
            label2.Name = "label2";
            label2.Size = new Size(161, 15);
            label2.TabIndex = 19;
            label2.Text = "*Click to get a number";
            // 
            // lblQueue
            // 
            lblQueue.AutoSize = true;
            lblQueue.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblQueue.Location = new Point(216, 113);
            lblQueue.Name = "lblQueue";
            lblQueue.Size = new Size(269, 32);
            lblQueue.TabIndex = 18;
            lblQueue.Text = "Position in Queue";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(216, 57);
            label1.Name = "label1";
            label1.Size = new Size(214, 24);
            label1.TabIndex = 17;
            label1.Text = "Position in Queue";
            // 
            // btnCashier
            // 
            btnCashier.BackColor = Color.LavenderBlush;
            btnCashier.Font = new Font("Consolas", 18F, FontStyle.Italic, GraphicsUnit.Point);
            btnCashier.Location = new Point(28, 28);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(157, 139);
            btnCashier.TabIndex = 16;
            btnCashier.Text = "Cashier";
            btnCashier.UseVisualStyleBackColor = false;
            btnCashier.Click += btnCashier_Click;
            // 
            // QueuingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(512, 222);
            Controls.Add(label2);
            Controls.Add(lblQueue);
            Controls.Add(label1);
            Controls.Add(btnCashier);
            Name = "QueuingForm";
            Text = "QueuingForm";
            Load += QueuingForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label lblQueue;
        private Label label1;
        private Button btnCashier;
    }
}