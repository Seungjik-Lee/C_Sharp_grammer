
namespace CustCar0415.UI
{
    partial class UcAddSell
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
            this.addCustAddr = new Sunny.UI.UITextBox();
            this.uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            this.addCusttel = new Sunny.UI.UITextBox();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.addCustname = new Sunny.UI.UITextBox();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.SuspendLayout();
            // 
            // addCarCancel
            // 
            this.addCarCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCarCancel.FillColor = System.Drawing.Color.Red;
            this.addCarCancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addCarCancel.Location = new System.Drawing.Point(346, 386);
            this.addCarCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.addCarCancel.Name = "addCarCancel";
            this.addCarCancel.Size = new System.Drawing.Size(78, 28);
            this.addCarCancel.Style = Sunny.UI.UIStyle.Custom;
            this.addCarCancel.Symbol = 61453;
            this.addCarCancel.TabIndex = 41;
            this.addCarCancel.Text = "취소";
            // 
            // addCarOK
            // 
            this.addCarOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCarOK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addCarOK.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addCarOK.Location = new System.Drawing.Point(258, 386);
            this.addCarOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.addCarOK.Name = "addCarOK";
            this.addCarOK.Size = new System.Drawing.Size(82, 28);
            this.addCarOK.Style = Sunny.UI.UIStyle.Custom;
            this.addCarOK.TabIndex = 40;
            this.addCarOK.Text = "확인";
            // 
            // addCustAddr
            // 
            this.addCustAddr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addCustAddr.FillColor = System.Drawing.Color.White;
            this.addCustAddr.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addCustAddr.Location = new System.Drawing.Point(240, 262);
            this.addCustAddr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addCustAddr.Maximum = 2147483647D;
            this.addCustAddr.Minimum = -2147483648D;
            this.addCustAddr.MinimumSize = new System.Drawing.Size(1, 1);
            this.addCustAddr.Name = "addCustAddr";
            this.addCustAddr.Padding = new System.Windows.Forms.Padding(5);
            this.addCustAddr.Size = new System.Drawing.Size(374, 29);
            this.addCustAddr.TabIndex = 39;
            // 
            // uiSymbolLabel4
            // 
            this.uiSymbolLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel4.Location = new System.Drawing.Point(102, 262);
            this.uiSymbolLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel4.Name = "uiSymbolLabel4";
            this.uiSymbolLabel4.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel4.Size = new System.Drawing.Size(107, 29);
            this.uiSymbolLabel4.Symbol = 62139;
            this.uiSymbolLabel4.TabIndex = 38;
            this.uiSymbolLabel4.Text = "직급";
            this.uiSymbolLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addCusttel
            // 
            this.addCusttel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addCusttel.FillColor = System.Drawing.Color.White;
            this.addCusttel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addCusttel.Location = new System.Drawing.Point(240, 223);
            this.addCusttel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addCusttel.Maximum = 2147483647D;
            this.addCusttel.Minimum = -2147483648D;
            this.addCusttel.MinimumSize = new System.Drawing.Size(1, 1);
            this.addCusttel.Name = "addCusttel";
            this.addCusttel.Padding = new System.Windows.Forms.Padding(5);
            this.addCusttel.Size = new System.Drawing.Size(374, 29);
            this.addCusttel.TabIndex = 37;
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel3.Location = new System.Drawing.Point(102, 226);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(107, 29);
            this.uiSymbolLabel3.Symbol = 61592;
            this.uiSymbolLabel3.TabIndex = 36;
            this.uiSymbolLabel3.Text = "전화번호";
            this.uiSymbolLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addCustname
            // 
            this.addCustname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addCustname.FillColor = System.Drawing.Color.White;
            this.addCustname.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addCustname.Location = new System.Drawing.Point(240, 184);
            this.addCustname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addCustname.Maximum = 2147483647D;
            this.addCustname.Minimum = -2147483648D;
            this.addCustname.MinimumSize = new System.Drawing.Size(1, 1);
            this.addCustname.Name = "addCustname";
            this.addCustname.Padding = new System.Windows.Forms.Padding(5);
            this.addCustname.Size = new System.Drawing.Size(374, 29);
            this.addCustname.TabIndex = 33;
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(102, 187);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(107, 29);
            this.uiSymbolLabel1.Symbol = 61447;
            this.uiSymbolLabel1.TabIndex = 32;
            this.uiSymbolLabel1.Text = "이름";
            this.uiSymbolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.FillColor = System.Drawing.Color.White;
            this.uiTextBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiTextBox1.Location = new System.Drawing.Point(240, 301);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.Maximum = 2147483647D;
            this.uiTextBox1.Minimum = -2147483648D;
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox1.Size = new System.Drawing.Size(374, 29);
            this.uiTextBox1.TabIndex = 41;
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel2.Location = new System.Drawing.Point(102, 301);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(107, 29);
            this.uiSymbolLabel2.Symbol = 61476;
            this.uiSymbolLabel2.TabIndex = 40;
            this.uiSymbolLabel2.Text = "영업소";
            this.uiSymbolLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UcAddSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uiTextBox1);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.addCarCancel);
            this.Controls.Add(this.addCarOK);
            this.Controls.Add(this.addCustAddr);
            this.Controls.Add(this.uiSymbolLabel4);
            this.Controls.Add(this.addCusttel);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.addCustname);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Name = "UcAddSell";
            this.Size = new System.Drawing.Size(716, 678);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton addCarCancel;
        private Sunny.UI.UISymbolButton addCarOK;
        private Sunny.UI.UITextBox addCustAddr;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private Sunny.UI.UITextBox addCusttel;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UITextBox addCustname;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
    }
}
