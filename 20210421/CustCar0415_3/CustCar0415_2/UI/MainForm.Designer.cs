
namespace CustCar0415_2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.randInsert = new CxFlatUI.CxFlatRoundButton();
            this.randDel = new CxFlatUI.CxFlatRoundButton();
            this.dataView = new CxFlatUI.CxFlatRoundButton();
            this.dataInsert = new CxFlatUI.CxFlatRoundButton();
            this.dataUpdate = new CxFlatUI.CxFlatRoundButton();
            this.dataDel = new CxFlatUI.CxFlatRoundButton();
            this.mainExit = new Sunny.UI.UISymbolButton();
            this.help = new Sunny.UI.UISymbolButton();
            this.mainTitle = new Sunny.UI.UISymbolLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 456);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // randInsert
            // 
            this.randInsert.ButtonType = CxFlatUI.ButtonType.Primary;
            this.randInsert.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.randInsert.Location = new System.Drawing.Point(379, 94);
            this.randInsert.Name = "randInsert";
            this.randInsert.Size = new System.Drawing.Size(183, 50);
            this.randInsert.TabIndex = 2;
            this.randInsert.Text = "랜덤데이터 추가";
            this.randInsert.TextColor = System.Drawing.Color.White;
            this.randInsert.Click += new System.EventHandler(this.randInsert_Click);
            // 
            // randDel
            // 
            this.randDel.ButtonType = CxFlatUI.ButtonType.Primary;
            this.randDel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.randDel.Location = new System.Drawing.Point(427, 166);
            this.randDel.Name = "randDel";
            this.randDel.Size = new System.Drawing.Size(183, 50);
            this.randDel.TabIndex = 3;
            this.randDel.Text = "랜덤 데이터 삭제";
            this.randDel.TextColor = System.Drawing.Color.White;
            this.randDel.Click += new System.EventHandler(this.randDel_Click);
            // 
            // dataView
            // 
            this.dataView.ButtonType = CxFlatUI.ButtonType.Primary;
            this.dataView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dataView.Location = new System.Drawing.Point(468, 237);
            this.dataView.Name = "dataView";
            this.dataView.Size = new System.Drawing.Size(183, 50);
            this.dataView.TabIndex = 4;
            this.dataView.Text = "데이터 보기";
            this.dataView.TextColor = System.Drawing.Color.White;
            this.dataView.Click += new System.EventHandler(this.dataView_Click);
            // 
            // dataInsert
            // 
            this.dataInsert.ButtonType = CxFlatUI.ButtonType.Primary;
            this.dataInsert.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dataInsert.Location = new System.Drawing.Point(468, 303);
            this.dataInsert.Name = "dataInsert";
            this.dataInsert.Size = new System.Drawing.Size(183, 50);
            this.dataInsert.TabIndex = 5;
            this.dataInsert.Text = "데이터 추가";
            this.dataInsert.TextColor = System.Drawing.Color.White;
            // 
            // dataUpdate
            // 
            this.dataUpdate.ButtonType = CxFlatUI.ButtonType.Primary;
            this.dataUpdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dataUpdate.Location = new System.Drawing.Point(427, 376);
            this.dataUpdate.Name = "dataUpdate";
            this.dataUpdate.Size = new System.Drawing.Size(183, 50);
            this.dataUpdate.TabIndex = 6;
            this.dataUpdate.Text = "데이터 수정";
            this.dataUpdate.TextColor = System.Drawing.Color.White;
            // 
            // dataDel
            // 
            this.dataDel.ButtonType = CxFlatUI.ButtonType.Primary;
            this.dataDel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dataDel.Location = new System.Drawing.Point(379, 451);
            this.dataDel.Name = "dataDel";
            this.dataDel.Size = new System.Drawing.Size(183, 50);
            this.dataDel.TabIndex = 7;
            this.dataDel.Text = "데이터 삭제";
            this.dataDel.TextColor = System.Drawing.Color.White;
            // 
            // mainExit
            // 
            this.mainExit.BackColor = System.Drawing.Color.Transparent;
            this.mainExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainExit.FillColor = System.Drawing.Color.Red;
            this.mainExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.mainExit.IsCircle = true;
            this.mainExit.Location = new System.Drawing.Point(658, 34);
            this.mainExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainExit.Name = "mainExit";
            this.mainExit.RectColor = System.Drawing.Color.Red;
            this.mainExit.Size = new System.Drawing.Size(62, 56);
            this.mainExit.Style = Sunny.UI.UIStyle.Custom;
            this.mainExit.Symbol = 61457;
            this.mainExit.SymbolSize = 40;
            this.mainExit.TabIndex = 8;
            this.mainExit.Click += new System.EventHandler(this.mainExit_Click);
            // 
            // help
            // 
            this.help.BackColor = System.Drawing.Color.Transparent;
            this.help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.help.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.help.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.help.IsCircle = true;
            this.help.Location = new System.Drawing.Point(590, 34);
            this.help.MinimumSize = new System.Drawing.Size(1, 1);
            this.help.Name = "help";
            this.help.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.help.Size = new System.Drawing.Size(62, 56);
            this.help.Style = Sunny.UI.UIStyle.Custom;
            this.help.Symbol = 61736;
            this.help.SymbolSize = 40;
            this.help.TabIndex = 9;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // mainTitle
            // 
            this.mainTitle.BackColor = System.Drawing.Color.Transparent;
            this.mainTitle.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.mainTitle.ForeColor = System.Drawing.Color.White;
            this.mainTitle.Location = new System.Drawing.Point(2, 26);
            this.mainTitle.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.mainTitle.Size = new System.Drawing.Size(193, 35);
            this.mainTitle.Style = Sunny.UI.UIStyle.Custom;
            this.mainTitle.Symbol = 61881;
            this.mainTitle.SymbolColor = System.Drawing.Color.Lime;
            this.mainTitle.TabIndex = 10;
            this.mainTitle.Text = "고객차량관리앱 v1.1";
            // 
            // MainWin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(732, 526);
            this.Controls.Add(this.mainTitle);
            this.Controls.Add(this.help);
            this.Controls.Add(this.mainExit);
            this.Controls.Add(this.dataDel);
            this.Controls.Add(this.dataUpdate);
            this.Controls.Add(this.dataInsert);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.randDel);
            this.Controls.Add(this.randInsert);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private CxFlatUI.CxFlatRoundButton randInsert;
        private CxFlatUI.CxFlatRoundButton randDel;
        private CxFlatUI.CxFlatRoundButton dataView;
        private CxFlatUI.CxFlatRoundButton dataInsert;
        private CxFlatUI.CxFlatRoundButton dataUpdate;
        private CxFlatUI.CxFlatRoundButton dataDel;
        private Sunny.UI.UISymbolButton mainExit;
        private Sunny.UI.UISymbolButton help;
        private Sunny.UI.UISymbolLabel mainTitle;
    }
}

