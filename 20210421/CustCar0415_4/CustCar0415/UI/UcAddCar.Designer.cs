
namespace CustCar0415.UI
{
    partial class UcAddCar
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.ucAddCarInit = new Sunny.UI.UISymbolButton();
            this.ucAddCarOK = new Sunny.UI.UISymbolButton();
            this.ucInfoPrice = new Sunny.UI.UISymbolLabel();
            this.ucInfoColor = new Sunny.UI.UISymbolLabel();
            this.ucInfoCompany = new Sunny.UI.UISymbolLabel();
            this.ucInfoModel = new Sunny.UI.UISymbolLabel();
            this.ucComboPrice = new Sunny.UI.UIComboBox();
            this.ucComboColor = new Sunny.UI.UIComboBox();
            this.ucComboCompany = new Sunny.UI.UIComboBox();
            this.ucComboModel = new Sunny.UI.UIComboBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ucAddCarInit
            // 
            this.ucAddCarInit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucAddCarInit.FillColor = System.Drawing.Color.Red;
            this.ucAddCarInit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucAddCarInit.Location = new System.Drawing.Point(313, 472);
            this.ucAddCarInit.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucAddCarInit.Name = "ucAddCarInit";
            this.ucAddCarInit.Size = new System.Drawing.Size(78, 28);
            this.ucAddCarInit.Style = Sunny.UI.UIStyle.Custom;
            this.ucAddCarInit.Symbol = 61453;
            this.ucAddCarInit.TabIndex = 27;
            this.ucAddCarInit.Text = "취소";
            this.ucAddCarInit.Click += new System.EventHandler(this.ucAddCarInit_Click);
            // 
            // ucAddCarOK
            // 
            this.ucAddCarOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucAddCarOK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ucAddCarOK.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucAddCarOK.Location = new System.Drawing.Point(225, 472);
            this.ucAddCarOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucAddCarOK.Name = "ucAddCarOK";
            this.ucAddCarOK.Size = new System.Drawing.Size(82, 28);
            this.ucAddCarOK.Style = Sunny.UI.UIStyle.Custom;
            this.ucAddCarOK.TabIndex = 26;
            this.ucAddCarOK.Text = "확인";
            this.ucAddCarOK.Click += new System.EventHandler(this.ucAddCarOK_Click);
            // 
            // ucInfoPrice
            // 
            this.ucInfoPrice.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucInfoPrice.Location = new System.Drawing.Point(456, 417);
            this.ucInfoPrice.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucInfoPrice.Name = "ucInfoPrice";
            this.ucInfoPrice.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.ucInfoPrice.Size = new System.Drawing.Size(142, 37);
            this.ucInfoPrice.Symbol = 61785;
            this.ucInfoPrice.TabIndex = 25;
            this.ucInfoPrice.Text = "가격";
            // 
            // ucInfoColor
            // 
            this.ucInfoColor.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucInfoColor.Location = new System.Drawing.Point(308, 417);
            this.ucInfoColor.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucInfoColor.Name = "ucInfoColor";
            this.ucInfoColor.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.ucInfoColor.Size = new System.Drawing.Size(142, 37);
            this.ucInfoColor.Symbol = 57467;
            this.ucInfoColor.TabIndex = 24;
            this.ucInfoColor.Text = "색상";
            // 
            // ucInfoCompany
            // 
            this.ucInfoCompany.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucInfoCompany.Location = new System.Drawing.Point(165, 417);
            this.ucInfoCompany.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucInfoCompany.Name = "ucInfoCompany";
            this.ucInfoCompany.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.ucInfoCompany.Size = new System.Drawing.Size(142, 37);
            this.ucInfoCompany.Symbol = 62069;
            this.ucInfoCompany.TabIndex = 23;
            this.ucInfoCompany.Text = "제조사";
            // 
            // ucInfoModel
            // 
            this.ucInfoModel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucInfoModel.Location = new System.Drawing.Point(17, 417);
            this.ucInfoModel.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucInfoModel.Name = "ucInfoModel";
            this.ucInfoModel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.ucInfoModel.Size = new System.Drawing.Size(142, 37);
            this.ucInfoModel.Symbol = 61881;
            this.ucInfoModel.TabIndex = 22;
            this.ucInfoModel.Text = "모델명";
            // 
            // ucComboPrice
            // 
            this.ucComboPrice.FillColor = System.Drawing.Color.White;
            this.ucComboPrice.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucComboPrice.Items.AddRange(new object[] {
            "10억원",
            "100억원",
            "1000억원",
            "1조원",
            "10조원"});
            this.ucComboPrice.Location = new System.Drawing.Point(458, 15);
            this.ucComboPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucComboPrice.MinimumSize = new System.Drawing.Size(63, 0);
            this.ucComboPrice.Name = "ucComboPrice";
            this.ucComboPrice.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.ucComboPrice.Size = new System.Drawing.Size(139, 29);
            this.ucComboPrice.TabIndex = 17;
            this.ucComboPrice.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucComboPrice.SelectedIndexChanged += new System.EventHandler(this.ucComboPrice_SelectedIndexChanged_1);
            // 
            // ucComboColor
            // 
            this.ucComboColor.FillColor = System.Drawing.Color.White;
            this.ucComboColor.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucComboColor.Items.AddRange(new object[] {
            "검정색",
            "은색",
            "흰색",
            "파랑색",
            "빨강색"});
            this.ucComboColor.Location = new System.Drawing.Point(311, 15);
            this.ucComboColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucComboColor.MinimumSize = new System.Drawing.Size(63, 0);
            this.ucComboColor.Name = "ucComboColor";
            this.ucComboColor.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.ucComboColor.Size = new System.Drawing.Size(139, 29);
            this.ucComboColor.TabIndex = 16;
            this.ucComboColor.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucComboColor.SelectedIndexChanged += new System.EventHandler(this.ucComboColor_SelectedIndexChanged_1);
            // 
            // ucComboCompany
            // 
            this.ucComboCompany.FillColor = System.Drawing.Color.White;
            this.ucComboCompany.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucComboCompany.Items.AddRange(new object[] {
            "현대",
            "기아",
            "르노삼성"});
            this.ucComboCompany.Location = new System.Drawing.Point(162, 15);
            this.ucComboCompany.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucComboCompany.MinimumSize = new System.Drawing.Size(63, 0);
            this.ucComboCompany.Name = "ucComboCompany";
            this.ucComboCompany.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.ucComboCompany.Size = new System.Drawing.Size(139, 29);
            this.ucComboCompany.TabIndex = 15;
            this.ucComboCompany.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucComboCompany.SelectedIndexChanged += new System.EventHandler(this.ucComboCompany_SelectedIndexChanged_1);
            // 
            // ucComboModel
            // 
            this.ucComboModel.FillColor = System.Drawing.Color.White;
            this.ucComboModel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucComboModel.Items.AddRange(new object[] {
            "그랜저",
            "제네시스",
            "K8",
            "K7",
            "SM6"});
            this.ucComboModel.Location = new System.Drawing.Point(11, 15);
            this.ucComboModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucComboModel.MinimumSize = new System.Drawing.Size(63, 0);
            this.ucComboModel.Name = "ucComboModel";
            this.ucComboModel.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.ucComboModel.Size = new System.Drawing.Size(139, 29);
            this.ucComboModel.TabIndex = 14;
            this.ucComboModel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucComboModel.SelectedIndexChanged += new System.EventHandler(this.ucComboModel_SelectedIndexChanged_1);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CustCar0415.Properties.Resources.그랜저후방;
            this.pictureBox4.Location = new System.Drawing.Point(311, 234);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(275, 167);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CustCar0415.Properties.Resources.그랜저내부;
            this.pictureBox3.Location = new System.Drawing.Point(30, 234);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(275, 167);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CustCar0415.Properties.Resources.그랜저2;
            this.pictureBox2.Location = new System.Drawing.Point(311, 61);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(275, 167);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CustCar0415.Properties.Resources.그랜저;
            this.pictureBox1.Location = new System.Drawing.Point(30, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // UcAddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucAddCarInit);
            this.Controls.Add(this.ucAddCarOK);
            this.Controls.Add(this.ucInfoPrice);
            this.Controls.Add(this.ucInfoColor);
            this.Controls.Add(this.ucInfoCompany);
            this.Controls.Add(this.ucInfoModel);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ucComboPrice);
            this.Controls.Add(this.ucComboColor);
            this.Controls.Add(this.ucComboCompany);
            this.Controls.Add(this.ucComboModel);
            this.Name = "UcAddCar";
            this.Size = new System.Drawing.Size(640, 524);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton ucAddCarInit;
        private Sunny.UI.UISymbolButton ucAddCarOK;
        private Sunny.UI.UISymbolLabel ucInfoPrice;
        private Sunny.UI.UISymbolLabel ucInfoColor;
        private Sunny.UI.UISymbolLabel ucInfoCompany;
        private Sunny.UI.UISymbolLabel ucInfoModel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UIComboBox ucComboPrice;
        private Sunny.UI.UIComboBox ucComboColor;
        private Sunny.UI.UIComboBox ucComboCompany;
        private Sunny.UI.UIComboBox ucComboModel;
    }
}
