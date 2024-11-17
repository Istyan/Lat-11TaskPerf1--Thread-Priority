namespace ThreadPrio
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
            lbl_Thread = new Label();
            btn_Run = new Button();
            SuspendLayout();
            // 
            // lbl_Thread
            // 
            lbl_Thread.AutoSize = true;
            lbl_Thread.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Thread.Location = new Point(72, 41);
            lbl_Thread.Name = "lbl_Thread";
            lbl_Thread.Size = new Size(148, 28);
            lbl_Thread.TabIndex = 0;
            lbl_Thread.Text = "-Thread Starts-";
            // 
            // btn_Run
            // 
            btn_Run.Location = new Point(93, 96);
            btn_Run.Name = "btn_Run";
            btn_Run.Size = new Size(102, 36);
            btn_Run.TabIndex = 1;
            btn_Run.Text = "Run";
            btn_Run.UseVisualStyleBackColor = true;
            btn_Run.Click += btn_Run_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 155);
            Controls.Add(btn_Run);
            Controls.Add(lbl_Thread);
            Name = "Form1";
            Text = "frmTrackThread";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Thread;
        private Button btn_Run;
    }
}
