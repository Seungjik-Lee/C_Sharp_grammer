
namespace CustCar0415.UI
{
    partial class UcAddCust
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
            this.selwoman = new Sunny.UI.UIRadioButton();
            this.selman = new Sunny.UI.UIRadioButton();
            this.uiSymbolLabel5 = new Sunny.UI.UISymbolLabel();
            this.addCarCancel = new Sunny.UI.UISymbolButton();
            this.addCarOK = new Sunny.UI.UISymbolButton();
            this.addCustAddr = new Sunny.UI.UITextBox();
            this.uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            this.addCusttel = new Sunny.UI.UITextBox();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.addCustage = new Sunny.UI.UITextBox();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.addCustname = new Sunny.UI.UITextBox();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.SuspendLayout();
            // 
            // selwoman
            // 
            this.selwoman.BackColor = System.Drawing.Color.Transparent;
            this.selwoman.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selwoman.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.selwoman.Location = new System.Drawing.Point(407, 343);
            this.selwoman.MinimumSize = new System.Drawing.Size(1, 1);
            this.selwoman.Name = "selwoman";
            this.selwoman.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.selwoman.Size = new System.Drawing.Size(180, 29);
            this.selwoman.TabIndex = 31;
            this.selwoman.Text = "여";
            // 
            // selman
            // 
            this.selman.BackColor = System.Drawing.Color.Transparent;
            this.selman.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selman.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.selman.Location = new System.Drawing.Point(213, 343);
            this.selman.MinimumSize = new System.Drawing.Size(1, 1);
            this.selman.Name = "selman";
            this.selman.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.selman.Size = new System.Drawing.Size(180, 29);
            this.selman.TabIndex = 30;
            this.selman.Text = "남";
            // 
            // uiSymbolLabel5
            // 
            this.uiSymbolLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel5.Location = new System.Drawing.Point(75, 343);
            this.uiSymbolLabel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel5.Name = "uiSymbolLabel5";
            this.uiSymbolLabel5.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel5.Size = new System.Drawing.Size(107, 29);
            this.uiSymbolLabel5.Symbol = 61988;
            this.uiSymbolLabel5.TabIndex = 29;
            this.uiSymbolLabel5.Text = "성별";
            this.uiSymbolLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addCarCancel
            // 
            this.addCarCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCarCancel.FillColor = System.Drawing.Color.Red;
            this.addCarCancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addCarCancel.Location = new System.Drawing.Point(301, 467);
            this.addCarCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.addCarCancel.Name = "addCarCancel";
            this.addCarCancel.Size = new System.Drawing.Size(78, 28);
            this.addCarCancel.Style = Sunny.UI.UIStyle.Custom;
            this.addCarCancel.Symbol = 61453;
            this.addCarCancel.TabIndex = 28;
            this.addCarCancel.Text = "취소";
            // 
            // addCarOK
            // 
            this.addCarOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCarOK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addCarOK.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addCarOK.Location = new System.Drawing.Point(213, 467);
            this.addCarOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.addCarOK.Name = "addCarOK";
            this.addCarOK.Size = new System.Drawing.Size(82, 28);
            this.addCarOK.Style = Sunny.UI.UIStyle.Custom;
            this.addCarOK.TabIndex = 27;
            this.addCarOK.Text = "확인";
            // 
            // addCustAddr
            // 
            this.addCustAddr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addCustAddr.FillColor = System.Drawing.Color.White;
            this.addCustAddr.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addCustAddr.Location = new System.Drawing.Point(213, 301);
            this.addCustAddr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addCustAddr.Maximum = 2147483647D;
            this.addCustAddr.Minimum = -2147483648D;
            this.addCustAddr.MinimumSize = new System.Drawing.Size(1, 1);
            this.addCustAddr.Name = "addCustAddr";
            this.addCustAddr.Padding = new System.Windows.Forms.Padding(5);
            this.addCustAddr.Size = new System.Drawing.Size(374, 29);
            this.addCustAddr.TabIndex = 26;
            // 
            // uiSymbolLabel4
            // 
            this.uiSymbolLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel4.Location = new System.Drawing.Point(75, 301);
            this.uiSymbolLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel4.Name = "uiSymbolLabel4";
            this.uiSymbolLabel4.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel4.Size = new System.Drawing.Size(107, 29);
            this.uiSymbolLabel4.Symbol = 62137;
            this.uiSymbolLabel4.TabIndex = 25;
            this.uiSymbolLabel4.Text = "주소";
            this.uiSymbolLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addCusttel
            // 
            this.addCusttel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addCusttel.FillColor = System.Drawing.Color.White;
            this.addCusttel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addCusttel.Location = new System.Drawing.Point(213, 262);
            this.addCusttel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addCusttel.Maximum = 2147483647D;
            this.addCusttel.Minimum = -2147483648D;
            this.addCusttel.MinimumSize = new System.Drawing.Size(1, 1);
            this.addCusttel.Name = "addCusttel";
            this.addCusttel.Padding = new System.Windows.Forms.Padding(5);
            this.addCusttel.Size = new System.Drawing.Size(374, 29);
            this.addCusttel.TabIndex = 24;
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel3.Location = new System.Drawing.Point(75, 265);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(107, 29);
            this.uiSymbolLabel3.Symbol = 61592;
            this.uiSymbolLabel3.TabIndex = 23;
            this.uiSymbolLabel3.Text = "전화번호";
            this.uiSymbolLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addCustage
            // 
            this.addCustage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addCustage.FillColor = System.Drawing.Color.White;
            this.addCustage.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addCustage.Location = new System.Drawing.Point(213, 223);
            this.addCustage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addCustage.Maximum = 2147483647D;
            this.addCustage.Minimum = -2147483648D;
            this.addCustage.MinimumSize = new System.Drawing.Size(1, 1);
            this.addCustage.Name = "addCustage";
            this.addCustage.Padding = new System.Windows.Forms.Padding(5);
            this.addCustage.Size = new System.Drawing.Size(374, 29);
            this.addCustage.TabIndex = 22;
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel2.Location = new System.Drawing.Point(75, 226);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(107, 29);
            this.uiSymbolLabel2.Symbol = 61641;
            this.uiSymbolLabel2.TabIndex = 21;
            this.uiSymbolLabel2.Text = "나이";
            this.uiSymbolLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addCustname
            // 
            this.addCustname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addCustname.FillColor = System.Drawing.Color.White;
            this.addCustname.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addCustname.Location = new System.Drawing.Point(213, 184);
            this.addCustname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addCustname.Maximum = 2147483647D;
            this.addCustname.Minimum = -2147483648D;
            this.addCustname.MinimumSize = new System.Drawing.Size(1, 1);
            this.addCustname.Name = "addCustname";
            this.addCustname.Padding = new System.Windows.Forms.Padding(5);
            this.addCustname.Size = new System.Drawing.Size(374, 29);
            this.addCustname.TabIndex = 20;
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(75, 187);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(107, 29);
            this.uiSymbolLabel1.Symbol = 61447;
            this.uiSymbolLabel1.TabIndex = 19;
            this.uiSymbolLabel1.Text = "이름";
            this.uiSymbolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UcAddCust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.selwoman);
            this.Controls.Add(this.selman);
            this.Controls.Add(this.uiSymbolLabel5);
            this.Controls.Add(this.addCarCancel);
            this.Controls.Add(this.addCarOK);
            this.Controls.Add(this.addCustAddr);
            this.Controls.Add(this.uiSymbolLabel4);
            this.Controls.Add(this.addCusttel);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.addCustage);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.addCustname);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Name = "UcAddCust";
            this.Size = new System.Drawing.Size(672, 681);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIRadioButton selwoman;
        private Sunny.UI.UIRadioButton selman;
        private Sunny.UI.UISymbolLabel uiSymbolLabel5;
        private Sunny.UI.UISymbolButton addCarCancel;
        private Sunny.UI.UISymbolButton addCarOK;
        private Sunny.UI.UITextBox addCustAddr;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private Sunny.UI.UITextBox addCusttel;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UITextBox addCustage;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UITextBox addCustname;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
    }
}
