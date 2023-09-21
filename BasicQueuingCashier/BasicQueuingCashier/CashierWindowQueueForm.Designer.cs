namespace BasicQueuingCashier
{
    partial class CashierWindowQueueForm
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
            btnRefresh = new Button();
            btnNext = new Button();
            listCashierQueue = new ListBox();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Snow;
            btnRefresh.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefresh.Location = new Point(28, 60);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(132, 55);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Snow;
            btnNext.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnNext.Location = new Point(28, 141);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(132, 55);
            btnNext.TabIndex = 1;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // listCashierQueue
            // 
            listCashierQueue.BackColor = Color.LavenderBlush;
            listCashierQueue.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            listCashierQueue.FormattingEnabled = true;
            listCashierQueue.ItemHeight = 22;
            listCashierQueue.Location = new Point(180, 12);
            listCashierQueue.Name = "listCashierQueue";
            listCashierQueue.Size = new Size(287, 378);
            listCashierQueue.TabIndex = 2;
            // 
            // CashierWindowQueueForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(488, 417);
            Controls.Add(listCashierQueue);
            Controls.Add(btnNext);
            Controls.Add(btnRefresh);
            Name = "CashierWindowQueueForm";
            Text = "CashierWindowQueueForm";
            Load += CashierWindowQueueForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnRefresh;
        private Button btnNext;
        private ListBox listCashierQueue;
    }
}