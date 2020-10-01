namespace KeyCode_Viewer
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
            this.lblKeyInput = new System.Windows.Forms.Label();
            this.txtKeyInput = new System.Windows.Forms.TextBox();
            this.lblKeyCode = new System.Windows.Forms.Label();
            this.cmdCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKeyInput
            // 
            this.lblKeyInput.AutoSize = true;
            this.lblKeyInput.Location = new System.Drawing.Point(12, 22);
            this.lblKeyInput.Name = "lblKeyInput";
            this.lblKeyInput.Size = new System.Drawing.Size(52, 13);
            this.lblKeyInput.TabIndex = 0;
            this.lblKeyInput.Text = "Key Input";
            // 
            // txtKeyInput
            // 
            this.txtKeyInput.Font = new System.Drawing.Font("Pyidaungsu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeyInput.Location = new System.Drawing.Point(70, 13);
            this.txtKeyInput.Name = "txtKeyInput";
            this.txtKeyInput.Size = new System.Drawing.Size(696, 31);
            this.txtKeyInput.TabIndex = 1;
            this.txtKeyInput.TextChanged += new System.EventHandler(this.txtKeyInput_TextChanged);
            // 
            // lblKeyCode
            // 
            this.lblKeyCode.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lblKeyCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKeyCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyCode.Location = new System.Drawing.Point(15, 58);
            this.lblKeyCode.Name = "lblKeyCode";
            this.lblKeyCode.Size = new System.Drawing.Size(751, 248);
            this.lblKeyCode.TabIndex = 2;
            this.lblKeyCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdCopy
            // 
            this.cmdCopy.Location = new System.Drawing.Point(689, 316);
            this.cmdCopy.Name = "cmdCopy";
            this.cmdCopy.Size = new System.Drawing.Size(77, 26);
            this.cmdCopy.TabIndex = 133;
            this.cmdCopy.Text = "Copy All";
            this.cmdCopy.UseVisualStyleBackColor = true;
            this.cmdCopy.Click += new System.EventHandler(this.cmdCopy_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 352);
            this.Controls.Add(this.cmdCopy);
            this.Controls.Add(this.lblKeyCode);
            this.Controls.Add(this.txtKeyInput);
            this.Controls.Add(this.lblKeyInput);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "KeyCode Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKeyInput;
        private System.Windows.Forms.TextBox txtKeyInput;
        private System.Windows.Forms.Label lblKeyCode;
        private System.Windows.Forms.Button cmdCopy;
    }
}

