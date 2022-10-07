namespace GADE_6112_Project2
{
    partial class frmGame
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
            this.btnup = new System.Windows.Forms.Button();
            this.btnattack = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.redMap = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.cmbEnemyatk = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnup
            // 
            this.btnup.Location = new System.Drawing.Point(659, 304);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(94, 29);
            this.btnup.TabIndex = 0;
            this.btnup.Text = "Up";
            this.btnup.UseVisualStyleBackColor = true;
            this.btnup.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnattack
            // 
            this.btnattack.Location = new System.Drawing.Point(659, 350);
            this.btnattack.Name = "btnattack";
            this.btnattack.Size = new System.Drawing.Size(94, 29);
            this.btnattack.TabIndex = 1;
            this.btnattack.Text = "Attack";
            this.btnattack.UseVisualStyleBackColor = true;
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(546, 350);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(94, 29);
            this.btnLeft.TabIndex = 2;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(763, 350);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(94, 29);
            this.btnRight.TabIndex = 3;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(659, 394);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(94, 29);
            this.btnDown.TabIndex = 4;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            // 
            // redMap
            // 
            this.redMap.Location = new System.Drawing.Point(38, 21);
            this.redMap.Name = "redMap";
            this.redMap.Size = new System.Drawing.Size(380, 391);
            this.redMap.TabIndex = 5;
            this.redMap.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(505, 21);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(125, 120);
            this.richTextBox2.TabIndex = 6;
            this.richTextBox2.Text = "";
            // 
            // cmbEnemyatk
            // 
            this.cmbEnemyatk.FormattingEnabled = true;
            this.cmbEnemyatk.Location = new System.Drawing.Point(709, 21);
            this.cmbEnemyatk.Name = "cmbEnemyatk";
            this.cmbEnemyatk.Size = new System.Drawing.Size(242, 28);
            this.cmbEnemyatk.TabIndex = 7;
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 494);
            this.Controls.Add(this.cmbEnemyatk);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.redMap);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnattack);
            this.Controls.Add(this.btnup);
            this.Name = "frmGame";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnup;
        private Button btnattack;
        private Button btnLeft;
        private Button btnRight;
        private Button btnDown;
        private RichTextBox redMap;
        private RichTextBox richTextBox2;
        private ComboBox cmbEnemyatk;
    }
}