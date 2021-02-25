namespace IKEA
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
            this.Ikea = new System.Windows.Forms.Label();
            this.listIkea = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listSeriesNames = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Ikea
            // 
            this.Ikea.AutoSize = true;
            this.Ikea.Location = new System.Drawing.Point(99, 91);
            this.Ikea.Name = "Ikea";
            this.Ikea.Size = new System.Drawing.Size(28, 13);
            this.Ikea.TabIndex = 0;
            this.Ikea.Text = "Ikea";
            // 
            // listIkea
            // 
            this.listIkea.FormattingEnabled = true;
            this.listIkea.Location = new System.Drawing.Point(102, 154);
            this.listIkea.Name = "listIkea";
            this.listIkea.Size = new System.Drawing.Size(120, 95);
            this.listIkea.TabIndex = 1;
            this.listIkea.SelectedIndexChanged += new System.EventHandler(this.listIkea_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(482, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Series Names";
            // 
            // listSeriesNames
            // 
            this.listSeriesNames.FormattingEnabled = true;
            this.listSeriesNames.Location = new System.Drawing.Point(485, 154);
            this.listSeriesNames.Name = "listSeriesNames";
            this.listSeriesNames.Size = new System.Drawing.Size(120, 95);
            this.listSeriesNames.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listSeriesNames);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listIkea);
            this.Controls.Add(this.Ikea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ikea;
        private System.Windows.Forms.ListBox listIkea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listSeriesNames;
    }
}

