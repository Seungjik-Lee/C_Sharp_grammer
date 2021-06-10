
namespace readCSV
{
    partial class Form2
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
            this.dataGridView_daegu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_daegu)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_daegu
            // 
            this.dataGridView_daegu.AllowUserToAddRows = false;
            this.dataGridView_daegu.AllowUserToDeleteRows = false;
            this.dataGridView_daegu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_daegu.Location = new System.Drawing.Point(12, 52);
            this.dataGridView_daegu.Name = "dataGridView_daegu";
            this.dataGridView_daegu.ReadOnly = true;
            this.dataGridView_daegu.RowTemplate.Height = 23;
            this.dataGridView_daegu.Size = new System.Drawing.Size(841, 585);
            this.dataGridView_daegu.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 649);
            this.Controls.Add(this.dataGridView_daegu);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_daegu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_daegu;
    }
}