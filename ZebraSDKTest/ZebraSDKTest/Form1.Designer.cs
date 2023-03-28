
namespace ZebraSDKTest
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtBarcodeString1 = new System.Windows.Forms.TextBox();
            this.txtBarcodeString2 = new System.Windows.Forms.TextBox();
            this.txtData2 = new System.Windows.Forms.TextBox();
            this.txtData1 = new System.Windows.Forms.TextBox();
            this.txtDataAscii2 = new System.Windows.Forms.TextBox();
            this.txtDataAscii1 = new System.Windows.Forms.TextBox();
            this.labId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtBarcodeString1
            // 
            this.txtBarcodeString1.Location = new System.Drawing.Point(12, 41);
            this.txtBarcodeString1.Multiline = true;
            this.txtBarcodeString1.Name = "txtBarcodeString1";
            this.txtBarcodeString1.Size = new System.Drawing.Size(652, 436);
            this.txtBarcodeString1.TabIndex = 2;
            // 
            // txtBarcodeString2
            // 
            this.txtBarcodeString2.Location = new System.Drawing.Point(670, 41);
            this.txtBarcodeString2.Multiline = true;
            this.txtBarcodeString2.Name = "txtBarcodeString2";
            this.txtBarcodeString2.Size = new System.Drawing.Size(652, 436);
            this.txtBarcodeString2.TabIndex = 2;
            // 
            // txtData2
            // 
            this.txtData2.Location = new System.Drawing.Point(670, 640);
            this.txtData2.Multiline = true;
            this.txtData2.Name = "txtData2";
            this.txtData2.Size = new System.Drawing.Size(651, 149);
            this.txtData2.TabIndex = 3;
            // 
            // txtData1
            // 
            this.txtData1.Location = new System.Drawing.Point(12, 640);
            this.txtData1.Multiline = true;
            this.txtData1.Name = "txtData1";
            this.txtData1.Size = new System.Drawing.Size(652, 149);
            this.txtData1.TabIndex = 4;
            // 
            // txtDataAscii2
            // 
            this.txtDataAscii2.Location = new System.Drawing.Point(670, 483);
            this.txtDataAscii2.Multiline = true;
            this.txtDataAscii2.Name = "txtDataAscii2";
            this.txtDataAscii2.Size = new System.Drawing.Size(651, 149);
            this.txtDataAscii2.TabIndex = 5;
            // 
            // txtDataAscii1
            // 
            this.txtDataAscii1.Location = new System.Drawing.Point(12, 483);
            this.txtDataAscii1.Multiline = true;
            this.txtDataAscii1.Name = "txtDataAscii1";
            this.txtDataAscii1.Size = new System.Drawing.Size(652, 149);
            this.txtDataAscii1.TabIndex = 6;
            // 
            // labId
            // 
            this.labId.AutoSize = true;
            this.labId.Location = new System.Drawing.Point(536, 12);
            this.labId.Name = "labId";
            this.labId.Size = new System.Drawing.Size(35, 13);
            this.labId.TabIndex = 7;
            this.labId.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 797);
            this.Controls.Add(this.labId);
            this.Controls.Add(this.txtData2);
            this.Controls.Add(this.txtData1);
            this.Controls.Add(this.txtDataAscii2);
            this.Controls.Add(this.txtDataAscii1);
            this.Controls.Add(this.txtBarcodeString2);
            this.Controls.Add(this.txtBarcodeString1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBarcodeString1;
        private System.Windows.Forms.TextBox txtBarcodeString2;
        private System.Windows.Forms.TextBox txtData2;
        private System.Windows.Forms.TextBox txtData1;
        private System.Windows.Forms.TextBox txtDataAscii2;
        private System.Windows.Forms.TextBox txtDataAscii1;
        private System.Windows.Forms.Label labId;
    }
}

