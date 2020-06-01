namespace MorseAlphabet
{
    partial class frmMain
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
            this.lblName = new System.Windows.Forms.Label();
            this.tbText = new System.Windows.Forms.TextBox();
            this.lblDescText = new System.Windows.Forms.Label();
            this.lblShowText = new System.Windows.Forms.Label();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblShowMorse = new System.Windows.Forms.Label();
            this.lblDescMorse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(142, 24);
            this.lblName.MinimumSize = new System.Drawing.Size(500, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(500, 39);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Wpisz tekst jaki chcesz przekształcić";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbText
            // 
            this.tbText.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbText.Location = new System.Drawing.Point(143, 90);
            this.tbText.MinimumSize = new System.Drawing.Size(4, 150);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbText.Size = new System.Drawing.Size(501, 275);
            this.tbText.TabIndex = 1;
            // 
            // lblDescText
            // 
            this.lblDescText.AutoSize = true;
            this.lblDescText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblDescText.Location = new System.Drawing.Point(144, 377);
            this.lblDescText.MinimumSize = new System.Drawing.Size(300, 0);
            this.lblDescText.Name = "lblDescText";
            this.lblDescText.Size = new System.Drawing.Size(300, 29);
            this.lblDescText.TabIndex = 2;
            this.lblDescText.Text = "Wyraz z tekstu";
            // 
            // lblShowText
            // 
            this.lblShowText.AutoSize = true;
            this.lblShowText.BackColor = System.Drawing.SystemColors.Window;
            this.lblShowText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowText.Location = new System.Drawing.Point(144, 420);
            this.lblShowText.MinimumSize = new System.Drawing.Size(500, 0);
            this.lblShowText.Name = "lblShowText";
            this.lblShowText.Size = new System.Drawing.Size(500, 29);
            this.lblShowText.TabIndex = 4;
            this.lblShowText.Text = "tekst";
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(288, 566);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(87, 48);
            this.btnTranslate.TabIndex = 6;
            this.btnTranslate.Text = "Wykonaj";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(464, 566);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 48);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Wyczyść";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblShowMorse
            // 
            this.lblShowMorse.AutoSize = true;
            this.lblShowMorse.BackColor = System.Drawing.SystemColors.Window;
            this.lblShowMorse.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowMorse.Location = new System.Drawing.Point(144, 517);
            this.lblShowMorse.MinimumSize = new System.Drawing.Size(500, 0);
            this.lblShowMorse.Name = "lblShowMorse";
            this.lblShowMorse.Size = new System.Drawing.Size(500, 29);
            this.lblShowMorse.TabIndex = 9;
            this.lblShowMorse.Text = "tekst";
            // 
            // lblDescMorse
            // 
            this.lblDescMorse.AutoSize = true;
            this.lblDescMorse.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescMorse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblDescMorse.Location = new System.Drawing.Point(144, 474);
            this.lblDescMorse.MinimumSize = new System.Drawing.Size(300, 0);
            this.lblDescMorse.Name = "lblDescMorse";
            this.lblDescMorse.Size = new System.Drawing.Size(300, 29);
            this.lblDescMorse.TabIndex = 8;
            this.lblDescMorse.Text = "Wyraz wg Morse\'a";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 665);
            this.Controls.Add(this.lblShowMorse);
            this.Controls.Add(this.lblDescMorse);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.lblShowText);
            this.Controls.Add(this.lblDescText);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.lblName);
            this.Name = "frmMain";
            this.Text = "Morse Alphabet";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Label lblDescText;
        private System.Windows.Forms.Label lblShowText;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblShowMorse;
        private System.Windows.Forms.Label lblDescMorse;
    }
}

