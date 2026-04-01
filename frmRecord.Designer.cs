namespace BMICalculator
{
    partial class frmRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecord));
            this.listRecord = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listRecord
            // 
            this.listRecord.FormattingEnabled = true;
            this.listRecord.ItemHeight = 19;
            this.listRecord.Location = new System.Drawing.Point(34, 41);
            this.listRecord.Name = "listRecord";
            this.listRecord.Size = new System.Drawing.Size(766, 441);
            this.listRecord.TabIndex = 0;
            // 
            // frmRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(900, 570);
            this.Controls.Add(this.listRecord);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmRecord";
            this.Text = "過往紀錄";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listRecord;
    }
}