namespace WFA241108
{
    partial class FrmMain
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
            tb = new TextBox();
            rtb = new RichTextBox();
            SuspendLayout();
            // 
            // tb
            // 
            tb.Location = new Point(12, 21);
            tb.Name = "tb";
            tb.Size = new Size(751, 43);
            tb.TabIndex = 0;
            // 
            // rtb
            // 
            rtb.Location = new Point(12, 82);
            rtb.Name = "rtb";
            rtb.Size = new Size(751, 539);
            rtb.TabIndex = 1;
            rtb.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 633);
            Controls.Add(rtb);
            Controls.Add(tb);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(7, 7, 7, 7);
            Name = "Form1";
            Text = "Adatbázis";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb;
        private RichTextBox rtb;
    }
}
