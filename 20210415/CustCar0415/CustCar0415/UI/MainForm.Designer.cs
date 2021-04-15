
namespace CustCar0415
{
    partial class MainWin
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWin));
            this.cxFlatPictureBox1 = new CxFlatUI.CxFlatPictureBox();
            this.cxFlatRoundButton1 = new CxFlatUI.CxFlatRoundButton();
            this.DataUpdate = new CxFlatUI.CxFlatRoundButton();
            this.DataAdd = new CxFlatUI.CxFlatRoundButton();
            this.DataView = new CxFlatUI.CxFlatRoundButton();
            this.DataDelete = new CxFlatUI.CxFlatRoundButton();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton2 = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cxFlatPictureBox1
            // 
            this.cxFlatPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.cxFlatPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("cxFlatPictureBox1.Image")));
            this.cxFlatPictureBox1.Location = new System.Drawing.Point(12, 71);
            this.cxFlatPictureBox1.Name = "cxFlatPictureBox1";
            this.cxFlatPictureBox1.Size = new System.Drawing.Size(539, 339);
            this.cxFlatPictureBox1.TabIndex = 0;
            this.cxFlatPictureBox1.TabStop = false;
            this.cxFlatPictureBox1.Click += new System.EventHandler(this.DataDelete_Click);
            // 
            // cxFlatRoundButton1
            // 
            this.cxFlatRoundButton1.ButtonType = CxFlatUI.ButtonType.Primary;
            this.cxFlatRoundButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatRoundButton1.Location = new System.Drawing.Point(557, 71);
            this.cxFlatRoundButton1.Name = "cxFlatRoundButton1";
            this.cxFlatRoundButton1.Size = new System.Drawing.Size(376, 43);
            this.cxFlatRoundButton1.TabIndex = 3;
            this.cxFlatRoundButton1.Text = "랜덤데이터 추가";
            this.cxFlatRoundButton1.TextColor = System.Drawing.Color.White;
            this.cxFlatRoundButton1.Click += new System.EventHandler(this.RandDataAdd_Click);
            // 
            // DataUpdate
            // 
            this.DataUpdate.ButtonType = CxFlatUI.ButtonType.Primary;
            this.DataUpdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DataUpdate.Location = new System.Drawing.Point(559, 318);
            this.DataUpdate.Name = "DataUpdate";
            this.DataUpdate.Size = new System.Drawing.Size(376, 43);
            this.DataUpdate.TabIndex = 6;
            this.DataUpdate.Text = "데이터 수정";
            this.DataUpdate.TextColor = System.Drawing.Color.White;
            this.DataUpdate.Click += new System.EventHandler(this.DataUpdate_Click);
            // 
            // DataAdd
            // 
            this.DataAdd.ButtonType = CxFlatUI.ButtonType.Primary;
            this.DataAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DataAdd.Location = new System.Drawing.Point(559, 256);
            this.DataAdd.Name = "DataAdd";
            this.DataAdd.Size = new System.Drawing.Size(376, 43);
            this.DataAdd.TabIndex = 7;
            this.DataAdd.Text = "데이터 추가";
            this.DataAdd.TextColor = System.Drawing.Color.White;
            this.DataAdd.Click += new System.EventHandler(this.DataAdd_Click);
            // 
            // DataView
            // 
            this.DataView.ButtonType = CxFlatUI.ButtonType.Primary;
            this.DataView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DataView.Location = new System.Drawing.Point(559, 194);
            this.DataView.Name = "DataView";
            this.DataView.Size = new System.Drawing.Size(376, 43);
            this.DataView.TabIndex = 8;
            this.DataView.Text = "데이터 보기";
            this.DataView.TextColor = System.Drawing.Color.White;
            this.DataView.Click += new System.EventHandler(this.DataView_Click);
            // 
            // DataDelete
            // 
            this.DataDelete.ButtonType = CxFlatUI.ButtonType.Primary;
            this.DataDelete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DataDelete.Location = new System.Drawing.Point(557, 129);
            this.DataDelete.Name = "DataDelete";
            this.DataDelete.Size = new System.Drawing.Size(376, 43);
            this.DataDelete.TabIndex = 9;
            this.DataDelete.Text = "데이터 삭제";
            this.DataDelete.TextColor = System.Drawing.Color.White;
            this.DataDelete.Click += new System.EventHandler(this.DataDelete_Click);
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.FillColor = System.Drawing.Color.Red;
            this.uiSymbolButton1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton1.IsCircle = true;
            this.uiSymbolButton1.Location = new System.Drawing.Point(892, 367);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.Radius = 15;
            this.uiSymbolButton1.Size = new System.Drawing.Size(52, 43);
            this.uiSymbolButton1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton1.Symbol = 61457;
            this.uiSymbolButton1.TabIndex = 10;
            this.uiSymbolButton1.Click += new System.EventHandler(this.MainExit_Click);
            // 
            // uiSymbolButton2
            // 
            this.uiSymbolButton2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton2.FillColor = System.Drawing.Color.Orange;
            this.uiSymbolButton2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton2.IsCircle = true;
            this.uiSymbolButton2.Location = new System.Drawing.Point(559, 367);
            this.uiSymbolButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton2.Name = "uiSymbolButton2";
            this.uiSymbolButton2.Radius = 15;
            this.uiSymbolButton2.Size = new System.Drawing.Size(52, 43);
            this.uiSymbolButton2.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton2.Symbol = 61736;
            this.uiSymbolButton2.TabIndex = 11;
            this.uiSymbolButton2.Click += new System.EventHandler(this.Help_Click);
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 663);
            this.Controls.Add(this.uiSymbolButton2);
            this.Controls.Add(this.uiSymbolButton1);
            this.Controls.Add(this.DataDelete);
            this.Controls.Add(this.DataView);
            this.Controls.Add(this.DataAdd);
            this.Controls.Add(this.DataUpdate);
            this.Controls.Add(this.cxFlatRoundButton1);
            this.Controls.Add(this.cxFlatPictureBox1);
            this.Name = "MainWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "고객차량관리프로그램 v1.0";
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CxFlatUI.CxFlatPictureBox cxFlatPictureBox1;
        private CxFlatUI.CxFlatRoundButton cxFlatRoundButton1;
        private CxFlatUI.CxFlatRoundButton DataUpdate;
        private CxFlatUI.CxFlatRoundButton DataAdd;
        private CxFlatUI.CxFlatRoundButton DataView;
        private CxFlatUI.CxFlatRoundButton DataDelete;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UISymbolButton uiSymbolButton2;
    }
}

