
namespace CustCar0415.UI
{
    partial class AddData
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
            this.topLayout = new System.Windows.Forms.Panel();
            this.addDataExit = new Sunny.UI.UISymbolButton();
            this.leftLayout = new System.Windows.Forms.Panel();
            this.addDataCancel = new Sunny.UI.UISymbolButton();
            this.addDataSell = new Sunny.UI.UIHeaderButton();
            this.addDataCar = new Sunny.UI.UIHeaderButton();
            this.addDataCust = new Sunny.UI.UIHeaderButton();
            this.centerLayout = new System.Windows.Forms.Panel();
            this.topLayout.SuspendLayout();
            this.leftLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // topLayout
            // 
            this.topLayout.BackColor = System.Drawing.Color.Transparent;
            this.topLayout.Controls.Add(this.addDataExit);
            this.topLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.topLayout.Location = new System.Drawing.Point(0, 0);
            this.topLayout.Name = "topLayout";
            this.topLayout.Size = new System.Drawing.Size(1055, 62);
            this.topLayout.TabIndex = 0;
            this.topLayout.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topLayout_MouseMove);
            // 
            // addDataExit
            // 
            this.addDataExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addDataExit.FillColor = System.Drawing.Color.Red;
            this.addDataExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addDataExit.Location = new System.Drawing.Point(977, 0);
            this.addDataExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.addDataExit.Name = "addDataExit";
            this.addDataExit.Size = new System.Drawing.Size(78, 28);
            this.addDataExit.Style = Sunny.UI.UIStyle.Custom;
            this.addDataExit.Symbol = 61453;
            this.addDataExit.TabIndex = 16;
            this.addDataExit.Text = "종료";
            this.addDataExit.Click += new System.EventHandler(this.addDataExit_Click);
            // 
            // leftLayout
            // 
            this.leftLayout.Controls.Add(this.addDataCancel);
            this.leftLayout.Controls.Add(this.addDataSell);
            this.leftLayout.Controls.Add(this.addDataCar);
            this.leftLayout.Controls.Add(this.addDataCust);
            this.leftLayout.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftLayout.Location = new System.Drawing.Point(0, 62);
            this.leftLayout.Name = "leftLayout";
            this.leftLayout.Size = new System.Drawing.Size(266, 624);
            this.leftLayout.TabIndex = 1;
            // 
            // addDataCancel
            // 
            this.addDataCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addDataCancel.FillColor = System.Drawing.Color.Red;
            this.addDataCancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addDataCancel.Location = new System.Drawing.Point(3, 564);
            this.addDataCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.addDataCancel.Name = "addDataCancel";
            this.addDataCancel.Size = new System.Drawing.Size(260, 57);
            this.addDataCancel.Style = Sunny.UI.UIStyle.Custom;
            this.addDataCancel.Symbol = 61453;
            this.addDataCancel.TabIndex = 15;
            this.addDataCancel.Text = "종료";
            this.addDataCancel.Click += new System.EventHandler(this.addDataExit_Click);
            // 
            // addDataSell
            // 
            this.addDataSell.CircleColor = System.Drawing.Color.Transparent;
            this.addDataSell.CircleHoverColor = System.Drawing.Color.Transparent;
            this.addDataSell.FillColor = System.Drawing.Color.Black;
            this.addDataSell.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDataSell.Location = new System.Drawing.Point(3, 377);
            this.addDataSell.MinimumSize = new System.Drawing.Size(1, 1);
            this.addDataSell.Name = "addDataSell";
            this.addDataSell.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.addDataSell.Radius = 0;
            this.addDataSell.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.addDataSell.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.addDataSell.Size = new System.Drawing.Size(260, 181);
            this.addDataSell.Style = Sunny.UI.UIStyle.Custom;
            this.addDataSell.Symbol = 62139;
            this.addDataSell.TabIndex = 2;
            this.addDataSell.Text = "판매자 정보 등록";
            this.addDataSell.Click += new System.EventHandler(this.addDataSell_Click);
            // 
            // addDataCar
            // 
            this.addDataCar.CircleColor = System.Drawing.Color.Transparent;
            this.addDataCar.CircleHoverColor = System.Drawing.Color.Transparent;
            this.addDataCar.FillColor = System.Drawing.Color.Black;
            this.addDataCar.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDataCar.Location = new System.Drawing.Point(3, 3);
            this.addDataCar.MinimumSize = new System.Drawing.Size(1, 1);
            this.addDataCar.Name = "addDataCar";
            this.addDataCar.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.addDataCar.Radius = 0;
            this.addDataCar.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.addDataCar.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.addDataCar.Size = new System.Drawing.Size(260, 181);
            this.addDataCar.Style = Sunny.UI.UIStyle.Custom;
            this.addDataCar.Symbol = 61881;
            this.addDataCar.TabIndex = 0;
            this.addDataCar.Text = "차량 정보 등록";
            this.addDataCar.Click += new System.EventHandler(this.addDataCar_Click);
            // 
            // addDataCust
            // 
            this.addDataCust.CircleColor = System.Drawing.Color.Transparent;
            this.addDataCust.CircleHoverColor = System.Drawing.Color.Transparent;
            this.addDataCust.FillColor = System.Drawing.Color.Black;
            this.addDataCust.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDataCust.Location = new System.Drawing.Point(3, 190);
            this.addDataCust.MinimumSize = new System.Drawing.Size(1, 1);
            this.addDataCust.Name = "addDataCust";
            this.addDataCust.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.addDataCust.Radius = 0;
            this.addDataCust.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.addDataCust.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.addDataCust.Size = new System.Drawing.Size(260, 181);
            this.addDataCust.Style = Sunny.UI.UIStyle.Custom;
            this.addDataCust.Symbol = 62137;
            this.addDataCust.TabIndex = 1;
            this.addDataCust.Text = "고객 정보 등록";
            this.addDataCust.Click += new System.EventHandler(this.addDataCust_Click);
            // 
            // centerLayout
            // 
            this.centerLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerLayout.Location = new System.Drawing.Point(266, 62);
            this.centerLayout.Name = "centerLayout";
            this.centerLayout.Size = new System.Drawing.Size(789, 624);
            this.centerLayout.TabIndex = 2;
            // 
            // AddData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 686);
            this.Controls.Add(this.centerLayout);
            this.Controls.Add(this.leftLayout);
            this.Controls.Add(this.topLayout);
            this.Name = "AddData";
            this.topLayout.ResumeLayout(false);
            this.leftLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topLayout;
        private System.Windows.Forms.Panel leftLayout;
        private System.Windows.Forms.Panel centerLayout;
        private Sunny.UI.UISymbolButton addDataExit;
        private Sunny.UI.UIHeaderButton addDataCar;
        private Sunny.UI.UIHeaderButton addDataSell;
        private Sunny.UI.UIHeaderButton addDataCust;
        private Sunny.UI.UISymbolButton addDataCancel;
    }
}