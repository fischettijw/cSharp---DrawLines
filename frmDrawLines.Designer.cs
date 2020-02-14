namespace cSharp___DrawLines
{
    partial class frmDrawLines
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
            this.pnlUI = new System.Windows.Forms.Panel();
            this.btnGO = new System.Windows.Forms.Button();
            this.txtIncrement = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtAngle = new System.Windows.Forms.TextBox();
            this.txtNumOfLines = new System.Windows.Forms.TextBox();
            this.lblIncrement = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblAngle = new System.Windows.Forms.Label();
            this.lblNumOfLines = new System.Windows.Forms.Label();
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.pnlUI.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUI
            // 
            this.pnlUI.BackColor = System.Drawing.Color.Gray;
            this.pnlUI.Controls.Add(this.btnGO);
            this.pnlUI.Controls.Add(this.txtIncrement);
            this.pnlUI.Controls.Add(this.txtLength);
            this.pnlUI.Controls.Add(this.txtAngle);
            this.pnlUI.Controls.Add(this.txtNumOfLines);
            this.pnlUI.Controls.Add(this.lblIncrement);
            this.pnlUI.Controls.Add(this.lblLength);
            this.pnlUI.Controls.Add(this.lblAngle);
            this.pnlUI.Controls.Add(this.lblNumOfLines);
            this.pnlUI.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUI.Location = new System.Drawing.Point(0, 0);
            this.pnlUI.Name = "pnlUI";
            this.pnlUI.Size = new System.Drawing.Size(525, 69);
            this.pnlUI.TabIndex = 0;
            // 
            // btnGO
            // 
            this.btnGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGO.Location = new System.Drawing.Point(447, 15);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(65, 45);
            this.btnGO.TabIndex = 8;
            this.btnGO.Text = "GO";
            this.btnGO.UseVisualStyleBackColor = true;
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // txtIncrement
            // 
            this.txtIncrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncrement.Location = new System.Drawing.Point(338, 32);
            this.txtIncrement.Name = "txtIncrement";
            this.txtIncrement.Size = new System.Drawing.Size(86, 29);
            this.txtIncrement.TabIndex = 7;
            this.txtIncrement.Text = "1";
            this.txtIncrement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLength
            // 
            this.txtLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLength.Location = new System.Drawing.Point(230, 32);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(86, 29);
            this.txtLength.TabIndex = 6;
            this.txtLength.Text = "5";
            this.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAngle
            // 
            this.txtAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAngle.Location = new System.Drawing.Point(122, 32);
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(86, 29);
            this.txtAngle.TabIndex = 5;
            this.txtAngle.Text = "74";
            this.txtAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumOfLines
            // 
            this.txtNumOfLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumOfLines.Location = new System.Drawing.Point(14, 32);
            this.txtNumOfLines.Name = "txtNumOfLines";
            this.txtNumOfLines.Size = new System.Drawing.Size(86, 29);
            this.txtNumOfLines.TabIndex = 4;
            this.txtNumOfLines.Text = "100";
            this.txtNumOfLines.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIncrement
            // 
            this.lblIncrement.AutoSize = true;
            this.lblIncrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncrement.ForeColor = System.Drawing.Color.White;
            this.lblIncrement.Location = new System.Drawing.Point(332, 6);
            this.lblIncrement.Name = "lblIncrement";
            this.lblIncrement.Size = new System.Drawing.Size(99, 24);
            this.lblIncrement.TabIndex = 3;
            this.lblIncrement.Text = "Imcrement";
            this.lblIncrement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.ForeColor = System.Drawing.Color.White;
            this.lblLength.Location = new System.Drawing.Point(239, 6);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(68, 24);
            this.lblLength.TabIndex = 2;
            this.lblLength.Text = "Length";
            this.lblLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAngle
            // 
            this.lblAngle.AutoSize = true;
            this.lblAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAngle.ForeColor = System.Drawing.Color.White;
            this.lblAngle.Location = new System.Drawing.Point(135, 6);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(60, 24);
            this.lblAngle.TabIndex = 1;
            this.lblAngle.Text = "Angle";
            this.lblAngle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumOfLines
            // 
            this.lblNumOfLines.AutoSize = true;
            this.lblNumOfLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfLines.ForeColor = System.Drawing.Color.White;
            this.lblNumOfLines.Location = new System.Drawing.Point(12, 6);
            this.lblNumOfLines.Name = "lblNumOfLines";
            this.lblNumOfLines.Size = new System.Drawing.Size(90, 24);
            this.lblNumOfLines.TabIndex = 0;
            this.lblNumOfLines.Text = "# of Lines";
            this.lblNumOfLines.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCanvas.Location = new System.Drawing.Point(0, 69);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(525, 393);
            this.pnlCanvas.TabIndex = 1;
            this.pnlCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCanvas_Paint);
            // 
            // frmDrawLines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 462);
            this.Controls.Add(this.pnlCanvas);
            this.Controls.Add(this.pnlUI);
            this.Name = "frmDrawLines";
            this.Text = "cSharp - DrawLines";
            this.Load += new System.EventHandler(this.frmDrawLines_Load);
            this.pnlUI.ResumeLayout(false);
            this.pnlUI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUI;
        private System.Windows.Forms.Label lblIncrement;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblAngle;
        private System.Windows.Forms.Label lblNumOfLines;
        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.TextBox txtIncrement;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtAngle;
        private System.Windows.Forms.TextBox txtNumOfLines;
        private System.Windows.Forms.Button btnGO;
    }
}

