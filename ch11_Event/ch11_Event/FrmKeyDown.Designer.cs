namespace ch11_Event
{
    partial class FrmKeyDown
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
            this.components = new System.ComponentModel.Container();
            this.lbJumsu = new System.Windows.Forms.Label();
            this.timer_CircleDown = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbJumsu
            // 
            this.lbJumsu.AutoSize = true;
            this.lbJumsu.Location = new System.Drawing.Point(13, 437);
            this.lbJumsu.Name = "lbJumsu";
            this.lbJumsu.Size = new System.Drawing.Size(65, 12);
            this.lbJumsu.TabIndex = 0;
            this.lbJumsu.Text = "현재 상태 :";
            // 
            // timer_CircleDown
            // 
            this.timer_CircleDown.Interval = 70;
            this.timer_CircleDown.Tick += new System.EventHandler(this.Timer_CircleDown_Tick);
            // 
            // FrmKeyDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 461);
            this.Controls.Add(this.lbJumsu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmKeyDown";
            this.Text = "FrmKeyDown";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmKeyDown_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmKeyDown_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbJumsu;
        private System.Windows.Forms.Timer timer_CircleDown;
    }
}