
namespace CustCar0415.UI
{
    partial class AddCar
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
            this.comboModel = new Sunny.UI.UIComboBox();
            this.comboCompany = new Sunny.UI.UIComboBox();
            this.comboColor = new Sunny.UI.UIComboBox();
            this.comboPrice = new Sunny.UI.UIComboBox();
            this.infoModel = new Sunny.UI.UISymbolLabel();
            this.infoCompany = new Sunny.UI.UISymbolLabel();
            this.infoColor = new Sunny.UI.UISymbolLabel();
            this.infoPrice = new Sunny.UI.UISymbolLabel();
            this.addCarOK = new Sunny.UI.UISymbolButton();
            this.addCarCancel = new Sunny.UI.UISymbolButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addCarExit = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboModel
            // 
            this.comboModel.FillColor = System.Drawing.Color.White;
            this.comboModel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.comboModel.Items.AddRange(new object[] {
            "그랜저",
            "제네시스",
            "K8",
            "K7",
            "SM6"});
            this.comboModel.Location = new System.Drawing.Point(12, 92);
            this.comboModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboModel.MinimumSize = new System.Drawing.Size(63, 0);
            this.comboModel.Name = "comboModel";
            this.comboModel.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comboModel.Size = new System.Drawing.Size(139, 29);
            this.comboModel.TabIndex = 0;
            this.comboModel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comboModel.SelectedIndexChanged += new System.EventHandler(this.comboModel_SelectedIndexChanged);
            // 
            // comboCompany
            // 
            this.comboCompany.FillColor = System.Drawing.Color.White;
            this.comboCompany.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.comboCompany.Items.AddRange(new object[] {
            "현대",
            "기아",
            "르노삼성"});
            this.comboCompany.Location = new System.Drawing.Point(221, 92);
            this.comboCompany.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboCompany.MinimumSize = new System.Drawing.Size(63, 0);
            this.comboCompany.Name = "comboCompany";
            this.comboCompany.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comboCompany.Size = new System.Drawing.Size(139, 29);
            this.comboCompany.TabIndex = 1;
            this.comboCompany.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comboCompany.SelectedIndexChanged += new System.EventHandler(this.comboCompany_SelectedIndexChanged);
            // 
            // comboColor
            // 
            this.comboColor.FillColor = System.Drawing.Color.White;
            this.comboColor.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.comboColor.Items.AddRange(new object[] {
            "검정색",
            "은색",
            "흰색",
            "파랑색",
            "빨강색"});
            this.comboColor.Location = new System.Drawing.Point(438, 92);
            this.comboColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboColor.MinimumSize = new System.Drawing.Size(63, 0);
            this.comboColor.Name = "comboColor";
            this.comboColor.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comboColor.Size = new System.Drawing.Size(139, 29);
            this.comboColor.TabIndex = 2;
            this.comboColor.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comboColor.SelectedIndexChanged += new System.EventHandler(this.comboColor_SelectedIndexChanged);
            // 
            // comboPrice
            // 
            this.comboPrice.FillColor = System.Drawing.Color.White;
            this.comboPrice.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.comboPrice.Items.AddRange(new object[] {
            "10억원",
            "100억원",
            "1000억원",
            "1조원",
            "10조원"});
            this.comboPrice.Location = new System.Drawing.Point(647, 92);
            this.comboPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboPrice.MinimumSize = new System.Drawing.Size(63, 0);
            this.comboPrice.Name = "comboPrice";
            this.comboPrice.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comboPrice.Size = new System.Drawing.Size(139, 29);
            this.comboPrice.TabIndex = 3;
            this.comboPrice.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comboPrice.SelectedIndexChanged += new System.EventHandler(this.comboPrice_SelectedIndexChanged);
            // 
            // infoModel
            // 
            this.infoModel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.infoModel.Location = new System.Drawing.Point(12, 525);
            this.infoModel.MinimumSize = new System.Drawing.Size(1, 1);
            this.infoModel.Name = "infoModel";
            this.infoModel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.infoModel.Size = new System.Drawing.Size(142, 37);
            this.infoModel.Symbol = 61881;
            this.infoModel.TabIndex = 8;
            this.infoModel.Text = "모델명";
            // 
            // infoCompany
            // 
            this.infoCompany.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.infoCompany.Location = new System.Drawing.Point(218, 525);
            this.infoCompany.MinimumSize = new System.Drawing.Size(1, 1);
            this.infoCompany.Name = "infoCompany";
            this.infoCompany.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.infoCompany.Size = new System.Drawing.Size(142, 37);
            this.infoCompany.Symbol = 62069;
            this.infoCompany.TabIndex = 9;
            this.infoCompany.Text = "제조사";
            // 
            // infoColor
            // 
            this.infoColor.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.infoColor.Location = new System.Drawing.Point(435, 525);
            this.infoColor.MinimumSize = new System.Drawing.Size(1, 1);
            this.infoColor.Name = "infoColor";
            this.infoColor.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.infoColor.Size = new System.Drawing.Size(142, 37);
            this.infoColor.Symbol = 57467;
            this.infoColor.TabIndex = 10;
            this.infoColor.Text = "색상";
            // 
            // infoPrice
            // 
            this.infoPrice.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.infoPrice.Location = new System.Drawing.Point(644, 525);
            this.infoPrice.MinimumSize = new System.Drawing.Size(1, 1);
            this.infoPrice.Name = "infoPrice";
            this.infoPrice.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.infoPrice.Size = new System.Drawing.Size(142, 37);
            this.infoPrice.Symbol = 61785;
            this.infoPrice.TabIndex = 11;
            this.infoPrice.Text = "가격";
            // 
            // addCarOK
            // 
            this.addCarOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCarOK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addCarOK.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addCarOK.Location = new System.Drawing.Point(312, 578);
            this.addCarOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.addCarOK.Name = "addCarOK";
            this.addCarOK.Size = new System.Drawing.Size(82, 28);
            this.addCarOK.Style = Sunny.UI.UIStyle.Custom;
            this.addCarOK.TabIndex = 12;
            this.addCarOK.Text = "확인";
            this.addCarOK.Click += new System.EventHandler(this.addCarOK_Click);
            // 
            // addCarCancel
            // 
            this.addCarCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCarCancel.FillColor = System.Drawing.Color.Red;
            this.addCarCancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addCarCancel.Location = new System.Drawing.Point(400, 578);
            this.addCarCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.addCarCancel.Name = "addCarCancel";
            this.addCarCancel.Size = new System.Drawing.Size(78, 28);
            this.addCarCancel.Style = Sunny.UI.UIStyle.Custom;
            this.addCarCancel.Symbol = 61453;
            this.addCarCancel.TabIndex = 13;
            this.addCarCancel.Text = "취소";
            this.addCarCancel.Click += new System.EventHandler(this.addCarCancel_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CustCar0415.Properties.Resources.그랜저후방;
            this.pictureBox4.Location = new System.Drawing.Point(400, 318);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(275, 167);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CustCar0415.Properties.Resources.그랜저내부;
            this.pictureBox3.Location = new System.Drawing.Point(119, 318);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(275, 167);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CustCar0415.Properties.Resources.그랜저2;
            this.pictureBox2.Location = new System.Drawing.Point(400, 145);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(275, 167);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CustCar0415.Properties.Resources.그랜저;
            this.pictureBox1.Location = new System.Drawing.Point(119, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // addCarExit
            // 
            this.addCarExit.BackColor = System.Drawing.Color.Transparent;
            this.addCarExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCarExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addCarExit.Location = new System.Drawing.Point(753, 28);
            this.addCarExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.addCarExit.Name = "addCarExit";
            this.addCarExit.Radius = 30;
            this.addCarExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.addCarExit.Size = new System.Drawing.Size(33, 31);
            this.addCarExit.Symbol = 61527;
            this.addCarExit.TabIndex = 14;
            this.addCarExit.Click += new System.EventHandler(this.addCarCancel_Click);
            // 
            // AddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 625);
            this.Controls.Add(this.addCarExit);
            this.Controls.Add(this.addCarCancel);
            this.Controls.Add(this.addCarOK);
            this.Controls.Add(this.infoPrice);
            this.Controls.Add(this.infoColor);
            this.Controls.Add(this.infoCompany);
            this.Controls.Add(this.infoModel);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboPrice);
            this.Controls.Add(this.comboColor);
            this.Controls.Add(this.comboCompany);
            this.Controls.Add(this.comboModel);
            this.Name = "AddCar";
            this.Text = "AddCar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIComboBox comboModel;
        private Sunny.UI.UIComboBox comboCompany;
        private Sunny.UI.UIComboBox comboColor;
        private Sunny.UI.UIComboBox comboPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Sunny.UI.UISymbolLabel infoModel;
        private Sunny.UI.UISymbolLabel infoCompany;
        private Sunny.UI.UISymbolLabel infoColor;
        private Sunny.UI.UISymbolLabel infoPrice;
        private Sunny.UI.UISymbolButton addCarOK;
        private Sunny.UI.UISymbolButton addCarCancel;
        private Sunny.UI.UISymbolButton addCarExit;
    }
}