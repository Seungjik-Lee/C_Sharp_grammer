
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
            this.ucAddCustInit = new Sunny.UI.UISymbolButton();
            this.ucAddCustOK = new Sunny.UI.UISymbolButton();
            this.ucAddCustAddr = new Sunny.UI.UITextBox();
            this.uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            this.ucAddCustTel = new Sunny.UI.UITextBox();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.ucAddCustAge = new Sunny.UI.UITextBox();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.ucAddCustName = new Sunny.UI.UITextBox();
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
            // ucAddCustInit
            // 
            this.ucAddCustInit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucAddCustInit.FillColor = System.Drawing.Color.Red;
            this.ucAddCustInit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucAddCustInit.Location = new System.Drawing.Point(301, 467);
            this.ucAddCustInit.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucAddCustInit.Name = "ucAddCustInit";
            this.ucAddCustInit.Size = new System.Drawing.Size(78, 28);
            this.ucAddCustInit.Style = Sunny.UI.UIStyle.Custom;
            this.ucAddCustInit.Symbol = 61453;
            this.ucAddCustInit.TabIndex = 28;
            this.ucAddCustInit.Text = "초기화";
            this.ucAddCustInit.Click += new System.EventHandler(this.ucAddCustInit_Click);
            // 
            // ucAddCustOK
            // 
            this.ucAddCustOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucAddCustOK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ucAddCustOK.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucAddCustOK.Location = new System.Drawing.Point(213, 467);
            this.ucAddCustOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucAddCustOK.Name = "ucAddCustOK";
            this.ucAddCustOK.Size = new System.Drawing.Size(82, 28);
            this.ucAddCustOK.Style = Sunny.UI.UIStyle.Custom;
            this.ucAddCustOK.TabIndex = 27;
            this.ucAddCustOK.Text = "확인";
            this.ucAddCustOK.Click += new System.EventHandler(this.ucAddCustOK_Click);
            // 
            // ucAddCustAddr
            // 
            this.ucAddCustAddr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ucAddCustAddr.FillColor = System.Drawing.Color.White;
            this.ucAddCustAddr.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucAddCustAddr.Location = new System.Drawing.Point(213, 301);
            this.ucAddCustAddr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucAddCustAddr.Maximum = 2147483647D;
            this.ucAddCustAddr.Minimum = -2147483648D;
            this.ucAddCustAddr.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucAddCustAddr.Name = "ucAddCustAddr";
            this.ucAddCustAddr.Padding = new System.Windows.Forms.Padding(5);
            this.ucAddCustAddr.Size = new System.Drawing.Size(374, 29);
            this.ucAddCustAddr.TabIndex = 26;
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
            // ucAddCustTel
            // 
            this.ucAddCustTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ucAddCustTel.FillColor = System.Drawing.Color.White;
            this.ucAddCustTel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucAddCustTel.Location = new System.Drawing.Point(213, 262);
            this.ucAddCustTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucAddCustTel.Maximum = 2147483647D;
            this.ucAddCustTel.Minimum = -2147483648D;
            this.ucAddCustTel.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucAddCustTel.Name = "ucAddCustTel";
            this.ucAddCustTel.Padding = new System.Windows.Forms.Padding(5);
            this.ucAddCustTel.Size = new System.Drawing.Size(374, 29);
            this.ucAddCustTel.TabIndex = 24;
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
            // ucAddCustAge
            // 
            this.ucAddCustAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ucAddCustAge.FillColor = System.Drawing.Color.White;
            this.ucAddCustAge.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucAddCustAge.Location = new System.Drawing.Point(213, 223);
            this.ucAddCustAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucAddCustAge.Maximum = 2147483647D;
            this.ucAddCustAge.Minimum = -2147483648D;
            this.ucAddCustAge.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucAddCustAge.Name = "ucAddCustAge";
            this.ucAddCustAge.Padding = new System.Windows.Forms.Padding(5);
            this.ucAddCustAge.Size = new System.Drawing.Size(374, 29);
            this.ucAddCustAge.TabIndex = 22;
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
            // ucAddCustName
            // 
            this.ucAddCustName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ucAddCustName.FillColor = System.Drawing.Color.White;
            this.ucAddCustName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucAddCustName.Location = new System.Drawing.Point(213, 184);
            this.ucAddCustName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucAddCustName.Maximum = 2147483647D;
            this.ucAddCustName.Minimum = -2147483648D;
            this.ucAddCustName.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucAddCustName.Name = "ucAddCustName";
            this.ucAddCustName.Padding = new System.Windows.Forms.Padding(5);
            this.ucAddCustName.Size = new System.Drawing.Size(374, 29);
            this.ucAddCustName.TabIndex = 20;
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
            this.Controls.Add(this.ucAddCustInit);
            this.Controls.Add(this.ucAddCustOK);
            this.Controls.Add(this.ucAddCustAddr);
            this.Controls.Add(this.uiSymbolLabel4);
            this.Controls.Add(this.ucAddCustTel);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.ucAddCustAge);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.ucAddCustName);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Name = "UcAddCust";
            this.Size = new System.Drawing.Size(672, 681);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIRadioButton selwoman;
        private Sunny.UI.UIRadioButton selman;
        private Sunny.UI.UISymbolLabel uiSymbolLabel5;
        private Sunny.UI.UISymbolButton ucAddCustInit;
        private Sunny.UI.UISymbolButton ucAddCustOK;
        private Sunny.UI.UITextBox ucAddCustAddr;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private Sunny.UI.UITextBox ucAddCustTel;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UITextBox ucAddCustAge;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UITextBox ucAddCustName;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
    }
}
