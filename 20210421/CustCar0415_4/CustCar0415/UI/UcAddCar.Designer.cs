
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
            this.addCarCancel = new Sunny.UI.UISymbolButton();
            this.addCarOK = new Sunny.UI.UISymbolButton();
            this.infoPrice = new Sunny.UI.UISymbolLabel();
            this.infoColor = new Sunny.UI.UISymbolLabel();
            this.infoCompany = new Sunny.UI.UISymbolLabel();
            this.infoModel = new Sunny.UI.UISymbolLabel();
            this.comboPrice = new Sunny.UI.UIComboBox();
            this.comboColor = new Sunny.UI.UIComboBox();
            this.comboCompany = new Sunny.UI.UIComboBox();
            this.comboModel = new Sunny.UI.UIComboBox();
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
            // addCarCancel
            // 
            this.addCarCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCarCancel.FillColor = System.Drawing.Color.Red;
            this.addCarCancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addCarCancel.Location = new System.Drawing.Point(440, 573);
            this.addCarCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.addCarCancel.Name = "addCarCancel";
            this.addCarCancel.Size = new System.Drawing.Size(78, 28);
            this.addCarCancel.Style = Sunny.UI.UIStyle.Custom;
            this.addCarCancel.Symbol = 61453;
            this.addCarCancel.TabIndex = 27;
            this.addCarCancel.Text = "취소";
            // 
            // addCarOK
            // 
            this.addCarOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCarOK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addCarOK.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addCarOK.Location = new System.Drawing.Point(352, 573);
            this.addCarOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.addCarOK.Name = "addCarOK";
            this.addCarOK.Size = new System.Drawing.Size(82, 28);
            this.addCarOK.Style = Sunny.UI.UIStyle.Custom;
            this.addCarOK.TabIndex = 26;
            this.addCarOK.Text = "확인";
            // 
            // infoPrice
            // 
            this.infoPrice.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.infoPrice.Location = new System.Drawing.Point(684, 520);
            this.infoPrice.MinimumSize = new System.Drawing.Size(1, 1);
            this.infoPrice.Name = "infoPrice";
            this.infoPrice.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.infoPrice.Size = new System.Drawing.Size(142, 37);
            this.infoPrice.Symbol = 61785;
            this.infoPrice.TabIndex = 25;
            this.infoPrice.Text = "가격";
            // 
            // infoColor
            // 
            this.infoColor.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.infoColor.Location = new System.Drawing.Point(475, 520);
            this.infoColor.MinimumSize = new System.Drawing.Size(1, 1);
            this.infoColor.Name = "infoColor";
            this.infoColor.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.infoColor.Size = new System.Drawing.Size(142, 37);
            this.infoColor.Symbol = 57467;
            this.infoColor.TabIndex = 24;
            this.infoColor.Text = "색상";
            // 
            // infoCompany
            // 
            this.infoCompany.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.infoCompany.Location = new System.Drawing.Point(258, 520);
            this.infoCompany.MinimumSize = new System.Drawing.Size(1, 1);
            this.infoCompany.Name = "infoCompany";
            this.infoCompany.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.infoCompany.Size = new System.Drawing.Size(142, 37);
            this.infoCompany.Symbol = 62069;
            this.infoCompany.TabIndex = 23;
            this.infoCompany.Text = "제조사";
            // 
            // infoModel
            // 
            this.infoModel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.infoModel.Location = new System.Drawing.Point(52, 520);
            this.infoModel.MinimumSize = new System.Drawing.Size(1, 1);
            this.infoModel.Name = "infoModel";
            this.infoModel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.infoModel.Size = new System.Drawing.Size(142, 37);
            this.infoModel.Symbol = 61881;
            this.infoModel.TabIndex = 22;
            this.infoModel.Text = "모델명";
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
            this.comboPrice.Location = new System.Drawing.Point(687, 87);
            this.comboPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboPrice.MinimumSize = new System.Drawing.Size(63, 0);
            this.comboPrice.Name = "comboPrice";
            this.comboPrice.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comboPrice.Size = new System.Drawing.Size(139, 29);
            this.comboPrice.TabIndex = 17;
            this.comboPrice.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.comboColor.Location = new System.Drawing.Point(478, 87);
            this.comboColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboColor.MinimumSize = new System.Drawing.Size(63, 0);
            this.comboColor.Name = "comboColor";
            this.comboColor.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comboColor.Size = new System.Drawing.Size(139, 29);
            this.comboColor.TabIndex = 16;
            this.comboColor.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboCompany
            // 
            this.comboCompany.FillColor = System.Drawing.Color.White;
            this.comboCompany.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.comboCompany.Items.AddRange(new object[] {
            "현대",
            "기아",
            "르노삼성"});
            this.comboCompany.Location = new System.Drawing.Point(261, 87);
            this.comboCompany.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboCompany.MinimumSize = new System.Drawing.Size(63, 0);
            this.comboCompany.Name = "comboCompany";
            this.comboCompany.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comboCompany.Size = new System.Drawing.Size(139, 29);
            this.comboCompany.TabIndex = 15;
            this.comboCompany.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.comboModel.Location = new System.Drawing.Point(52, 87);
            this.comboModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboModel.MinimumSize = new System.Drawing.Size(63, 0);
            this.comboModel.Name = "comboModel";
            this.comboModel.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comboModel.Size = new System.Drawing.Size(139, 29);
            this.comboModel.TabIndex = 14;
            this.comboModel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CustCar0415.Properties.Resources.그랜저후방;
            this.pictureBox4.Location = new System.Drawing.Point(440, 313);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(275, 167);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CustCar0415.Properties.Resources.그랜저내부;
            this.pictureBox3.Location = new System.Drawing.Point(159, 313);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(275, 167);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CustCar0415.Properties.Resources.그랜저2;
            this.pictureBox2.Location = new System.Drawing.Point(440, 140);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(275, 167);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CustCar0415.Properties.Resources.그랜저;
            this.pictureBox1.Location = new System.Drawing.Point(159, 140);
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
            this.Name = "UcAddCar";
            this.Size = new System.Drawing.Size(893, 689);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton addCarCancel;
        private Sunny.UI.UISymbolButton addCarOK;
        private Sunny.UI.UISymbolLabel infoPrice;
        private Sunny.UI.UISymbolLabel infoColor;
        private Sunny.UI.UISymbolLabel infoCompany;
        private Sunny.UI.UISymbolLabel infoModel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UIComboBox comboPrice;
        private Sunny.UI.UIComboBox comboColor;
        private Sunny.UI.UIComboBox comboCompany;
        private Sunny.UI.UIComboBox comboModel;
    }
}
