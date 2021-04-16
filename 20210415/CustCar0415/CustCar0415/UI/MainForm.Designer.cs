
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
            this.RandDataAdd = new CxFlatUI.CxFlatRoundButton();
            this.DataUpdate = new CxFlatUI.CxFlatRoundButton();
            this.DataAdd = new CxFlatUI.CxFlatRoundButton();
            this.DataView = new CxFlatUI.CxFlatRoundButton();
            this.DataDelete = new CxFlatUI.CxFlatRoundButton();
            this.MainExit = new Sunny.UI.UISymbolButton();
            this.Help = new Sunny.UI.UISymbolButton();
            this.RandDataDelete = new CxFlatUI.CxFlatRoundButton();
            this.MainTitle = new Sunny.UI.UISymbolLabel();
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
            // RandDataAdd
            // 
            this.RandDataAdd.BackColor = System.Drawing.Color.Transparent;
            this.RandDataAdd.ButtonType = CxFlatUI.ButtonType.Primary;
            this.RandDataAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.RandDataAdd.Location = new System.Drawing.Point(559, 71);
            this.RandDataAdd.Name = "RandDataAdd";
            this.RandDataAdd.Size = new System.Drawing.Size(376, 43);
            this.RandDataAdd.TabIndex = 3;
            this.RandDataAdd.Text = "랜덤데이터 추가";
            this.RandDataAdd.TextColor = System.Drawing.Color.White;
            this.RandDataAdd.Click += new System.EventHandler(this.RandDataAdd_Click);
            // 
            // DataUpdate
            // 
            this.DataUpdate.BackColor = System.Drawing.Color.Transparent;
            this.DataUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DataUpdate.ButtonType = CxFlatUI.ButtonType.Primary;
            this.DataUpdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DataUpdate.Location = new System.Drawing.Point(559, 267);
            this.DataUpdate.Name = "DataUpdate";
            this.DataUpdate.Size = new System.Drawing.Size(376, 43);
            this.DataUpdate.TabIndex = 6;
            this.DataUpdate.Text = "데이터 수정";
            this.DataUpdate.TextColor = System.Drawing.Color.White;
            this.DataUpdate.Click += new System.EventHandler(this.DataUpdate_Click);
            // 
            // DataAdd
            // 
            this.DataAdd.BackColor = System.Drawing.Color.Transparent;
            this.DataAdd.ButtonType = CxFlatUI.ButtonType.Primary;
            this.DataAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DataAdd.Location = new System.Drawing.Point(559, 218);
            this.DataAdd.Name = "DataAdd";
            this.DataAdd.Size = new System.Drawing.Size(376, 43);
            this.DataAdd.TabIndex = 7;
            this.DataAdd.Text = "데이터 추가";
            this.DataAdd.TextColor = System.Drawing.Color.White;
            this.DataAdd.Click += new System.EventHandler(this.DataAdd_Click);
            // 
            // DataView
            // 
            this.DataView.BackColor = System.Drawing.Color.Transparent;
            this.DataView.ButtonType = CxFlatUI.ButtonType.Primary;
            this.DataView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DataView.Location = new System.Drawing.Point(559, 169);
            this.DataView.Name = "DataView";
            this.DataView.Size = new System.Drawing.Size(376, 43);
            this.DataView.TabIndex = 8;
            this.DataView.Text = "데이터 보기";
            this.DataView.TextColor = System.Drawing.Color.White;
            this.DataView.Click += new System.EventHandler(this.DataView_Click);
            // 
            // DataDelete
            // 
            this.DataDelete.BackColor = System.Drawing.Color.Transparent;
            this.DataDelete.ButtonType = CxFlatUI.ButtonType.Primary;
            this.DataDelete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DataDelete.Location = new System.Drawing.Point(559, 120);
            this.DataDelete.Name = "DataDelete";
            this.DataDelete.Size = new System.Drawing.Size(376, 43);
            this.DataDelete.TabIndex = 9;
            this.DataDelete.Text = "데이터 삭제";
            this.DataDelete.TextColor = System.Drawing.Color.White;
            this.DataDelete.Click += new System.EventHandler(this.DataDelete_Click);
            // 
            // MainExit
            // 
            this.MainExit.BackColor = System.Drawing.Color.Transparent;
            this.MainExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainExit.FillColor = System.Drawing.Color.Red;
            this.MainExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.MainExit.IsCircle = true;
            this.MainExit.Location = new System.Drawing.Point(883, 367);
            this.MainExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.MainExit.Name = "MainExit";
            this.MainExit.Radius = 15;
            this.MainExit.Size = new System.Drawing.Size(52, 43);
            this.MainExit.Style = Sunny.UI.UIStyle.Custom;
            this.MainExit.Symbol = 61457;
            this.MainExit.TabIndex = 10;
            this.MainExit.Click += new System.EventHandler(this.MainExit_Click);
            // 
            // Help
            // 
            this.Help.BackColor = System.Drawing.Color.Transparent;
            this.Help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Help.FillColor = System.Drawing.Color.Orange;
            this.Help.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.Help.IsCircle = true;
            this.Help.Location = new System.Drawing.Point(559, 367);
            this.Help.MinimumSize = new System.Drawing.Size(1, 1);
            this.Help.Name = "Help";
            this.Help.Radius = 15;
            this.Help.Size = new System.Drawing.Size(52, 43);
            this.Help.Style = Sunny.UI.UIStyle.Custom;
            this.Help.Symbol = 61736;
            this.Help.TabIndex = 11;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // RandDataDelete
            // 
            this.RandDataDelete.BackColor = System.Drawing.Color.Transparent;
            this.RandDataDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RandDataDelete.ButtonType = CxFlatUI.ButtonType.Primary;
            this.RandDataDelete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.RandDataDelete.Location = new System.Drawing.Point(559, 316);
            this.RandDataDelete.Name = "RandDataDelete";
            this.RandDataDelete.Size = new System.Drawing.Size(376, 43);
            this.RandDataDelete.TabIndex = 12;
            this.RandDataDelete.Text = "랜덤데이터 삭제";
            this.RandDataDelete.TextColor = System.Drawing.Color.White;
            this.RandDataDelete.Click += new System.EventHandler(this.RandDataDelete_Click);
            // 
            // MainTitle
            // 
            this.MainTitle.BackColor = System.Drawing.Color.Transparent;
            this.MainTitle.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.MainTitle.ForeColor = System.Drawing.Color.White;
            this.MainTitle.Location = new System.Drawing.Point(12, 30);
            this.MainTitle.MinimumSize = new System.Drawing.Size(1, 1);
            this.MainTitle.Name = "MainTitle";
            this.MainTitle.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.MainTitle.Size = new System.Drawing.Size(249, 26);
            this.MainTitle.Style = Sunny.UI.UIStyle.Custom;
            this.MainTitle.Symbol = 61474;
            this.MainTitle.SymbolColor = System.Drawing.Color.PaleTurquoise;
            this.MainTitle.TabIndex = 13;
            this.MainTitle.Text = "고객차량관리프로그램 v1.1";
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 423);
            this.Controls.Add(this.MainTitle);
            this.Controls.Add(this.RandDataDelete);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.MainExit);
            this.Controls.Add(this.DataDelete);
            this.Controls.Add(this.DataView);
            this.Controls.Add(this.DataAdd);
            this.Controls.Add(this.DataUpdate);
            this.Controls.Add(this.RandDataAdd);
            this.Controls.Add(this.cxFlatPictureBox1);
            this.Name = "MainWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CxFlatUI.CxFlatPictureBox cxFlatPictureBox1;
        private CxFlatUI.CxFlatRoundButton RandDataAdd;
        private CxFlatUI.CxFlatRoundButton DataUpdate;
        private CxFlatUI.CxFlatRoundButton DataAdd;
        private CxFlatUI.CxFlatRoundButton DataView;
        private CxFlatUI.CxFlatRoundButton DataDelete;
        private Sunny.UI.UISymbolButton MainExit;
        private Sunny.UI.UISymbolButton Help;
        private CxFlatUI.CxFlatRoundButton RandDataDelete;
        private Sunny.UI.UISymbolLabel MainTitle;
    }
}

