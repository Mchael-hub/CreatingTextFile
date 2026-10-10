namespace CreatingTextFile
{
    partial class FrmMenu
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
            btnSimple = new Button();
            btnChallenge = new Button();
            SuspendLayout();
            // 
            // btnSimple
            // 
            btnSimple.Location = new Point(116, 44);
            btnSimple.Name = "btnSimple";
            btnSimple.Size = new Size(75, 23);
            btnSimple.TabIndex = 0;
            btnSimple.Text = "Simple lab";
            btnSimple.UseVisualStyleBackColor = true;
            btnSimple.Click += btnSimple_Click;
            // 
            // btnChallenge
            // 
            btnChallenge.Location = new Point(116, 83);
            btnChallenge.Name = "btnChallenge";
            btnChallenge.Size = new Size(75, 23);
            btnChallenge.TabIndex = 1;
            btnChallenge.Text = "Challenge";
            btnChallenge.UseVisualStyleBackColor = true;
            btnChallenge.Click += btnChallenge_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 164);
            Controls.Add(btnChallenge);
            Controls.Add(btnSimple);
            Name = "FrmMenu";
            Text = "FrmMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSimple;
        private Button btnChallenge;
    }
}
