
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
            this.randInsert = new Sunny.UI.UISymbolButton();
            this.randDel = new Sunny.UI.UISymbolButton();
            this.dataView = new Sunny.UI.UISymbolButton();
            this.dataInsert = new Sunny.UI.UISymbolButton();
            this.dataUpdate = new Sunny.UI.UISymbolButton();
            this.dataDel = new Sunny.UI.UISymbolButton();
            this.mainExit = new Sunny.UI.UISymbolButton();
            this.help = new Sunny.UI.UISymbolButton();
            this.mainTitle = new Sunny.UI.UISymbolLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // randInsert
            // 
            this.randInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.randInsert.FillColor = System.Drawing.Color.Gray;
            this.randInsert.FillHoverColor = System.Drawing.Color.Gray;
            this.randInsert.FillPressColor = System.Drawing.Color.DarkGray;
            this.randInsert.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.randInsert.ForeColor = System.Drawing.Color.Black;
            this.randInsert.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.randInsert.Location = new System.Drawing.Point(432, 77);
            this.randInsert.MinimumSize = new System.Drawing.Size(1, 1);
            this.randInsert.Name = "randInsert";
            this.randInsert.RectColor = System.Drawing.Color.Gray;
            this.randInsert.Size = new System.Drawing.Size(149, 40);
            this.randInsert.Style = Sunny.UI.UIStyle.Custom;
            this.randInsert.Symbol = 0;
            this.randInsert.TabIndex = 1;
            this.randInsert.Text = "랜덤데이터 추가";
            this.randInsert.Click += new System.EventHandler(this.randInsert_Click);
            // 
            // randDel
            // 
            this.randDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.randDel.FillColor = System.Drawing.Color.Gray;
            this.randDel.FillHoverColor = System.Drawing.Color.Gray;
            this.randDel.FillPressColor = System.Drawing.Color.DarkGray;
            this.randDel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.randDel.ForeColor = System.Drawing.Color.Black;
            this.randDel.Location = new System.Drawing.Point(432, 123);
            this.randDel.MinimumSize = new System.Drawing.Size(1, 1);
            this.randDel.Name = "randDel";
            this.randDel.RectColor = System.Drawing.Color.Gray;
            this.randDel.Size = new System.Drawing.Size(149, 40);
            this.randDel.Style = Sunny.UI.UIStyle.Custom;
            this.randDel.Symbol = 0;
            this.randDel.TabIndex = 2;
            this.randDel.Text = "랜덤데이터 삭제";
            this.randDel.Click += new System.EventHandler(this.randDel_Click);
            // 
            // dataView
            // 
            this.dataView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataView.FillColor = System.Drawing.Color.Gray;
            this.dataView.FillHoverColor = System.Drawing.Color.Gray;
            this.dataView.FillPressColor = System.Drawing.Color.DarkGray;
            this.dataView.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dataView.ForeColor = System.Drawing.Color.Black;
            this.dataView.Location = new System.Drawing.Point(432, 169);
            this.dataView.MinimumSize = new System.Drawing.Size(1, 1);
            this.dataView.Name = "dataView";
            this.dataView.RectColor = System.Drawing.Color.Gray;
            this.dataView.Size = new System.Drawing.Size(149, 40);
            this.dataView.Style = Sunny.UI.UIStyle.Custom;
            this.dataView.Symbol = 0;
            this.dataView.TabIndex = 3;
            this.dataView.Text = "데이터 보기";
            this.dataView.Click += new System.EventHandler(this.dataView_Click);
            // 
            // dataInsert
            // 
            this.dataInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataInsert.FillColor = System.Drawing.Color.Gray;
            this.dataInsert.FillHoverColor = System.Drawing.Color.Gray;
            this.dataInsert.FillPressColor = System.Drawing.Color.DarkGray;
            this.dataInsert.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dataInsert.ForeColor = System.Drawing.Color.Black;
            this.dataInsert.Location = new System.Drawing.Point(432, 261);
            this.dataInsert.MinimumSize = new System.Drawing.Size(1, 1);
            this.dataInsert.Name = "dataInsert";
            this.dataInsert.RectColor = System.Drawing.Color.Gray;
            this.dataInsert.Size = new System.Drawing.Size(149, 40);
            this.dataInsert.Style = Sunny.UI.UIStyle.Custom;
            this.dataInsert.Symbol = 0;
            this.dataInsert.TabIndex = 4;
            this.dataInsert.Text = "데이터 추가";
            this.dataInsert.Click += new System.EventHandler(this.dataInsert_Click);
            // 
            // dataUpdate
            // 
            this.dataUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataUpdate.FillColor = System.Drawing.Color.Gray;
            this.dataUpdate.FillHoverColor = System.Drawing.Color.Gray;
            this.dataUpdate.FillPressColor = System.Drawing.Color.DarkGray;
            this.dataUpdate.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dataUpdate.ForeColor = System.Drawing.Color.Black;
            this.dataUpdate.Location = new System.Drawing.Point(432, 215);
            this.dataUpdate.MinimumSize = new System.Drawing.Size(1, 1);
            this.dataUpdate.Name = "dataUpdate";
            this.dataUpdate.RectColor = System.Drawing.Color.Gray;
            this.dataUpdate.Size = new System.Drawing.Size(149, 40);
            this.dataUpdate.Style = Sunny.UI.UIStyle.Custom;
            this.dataUpdate.Symbol = 0;
            this.dataUpdate.TabIndex = 5;
            this.dataUpdate.Text = "데이터 수정";
            // 
            // dataDel
            // 
            this.dataDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataDel.FillColor = System.Drawing.Color.Gray;
            this.dataDel.FillHoverColor = System.Drawing.Color.Gray;
            this.dataDel.FillPressColor = System.Drawing.Color.DarkGray;
            this.dataDel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dataDel.ForeColor = System.Drawing.Color.Black;
            this.dataDel.Location = new System.Drawing.Point(432, 307);
            this.dataDel.MinimumSize = new System.Drawing.Size(1, 1);
            this.dataDel.Name = "dataDel";
            this.dataDel.RectColor = System.Drawing.Color.Gray;
            this.dataDel.Size = new System.Drawing.Size(149, 40);
            this.dataDel.Style = Sunny.UI.UIStyle.Custom;
            this.dataDel.Symbol = 0;
            this.dataDel.TabIndex = 6;
            this.dataDel.Text = "데이터 삭제";
            // 
            // mainExit
            // 
            this.mainExit.BackColor = System.Drawing.Color.Transparent;
            this.mainExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainExit.FillColor = System.Drawing.Color.Transparent;
            this.mainExit.FillDisableColor = System.Drawing.Color.Transparent;
            this.mainExit.FillHoverColor = System.Drawing.Color.Transparent;
            this.mainExit.FillPressColor = System.Drawing.Color.Transparent;
            this.mainExit.FillSelectedColor = System.Drawing.Color.Transparent;
            this.mainExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.mainExit.ForeColor = System.Drawing.Color.Red;
            this.mainExit.ForeHoverColor = System.Drawing.Color.Orange;
            this.mainExit.IsCircle = true;
            this.mainExit.Location = new System.Drawing.Point(535, 353);
            this.mainExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainExit.Name = "mainExit";
            this.mainExit.RectColor = System.Drawing.Color.Transparent;
            this.mainExit.RectHoverColor = System.Drawing.Color.Transparent;
            this.mainExit.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mainExit.Size = new System.Drawing.Size(46, 52);
            this.mainExit.Style = Sunny.UI.UIStyle.Custom;
            this.mainExit.Symbol = 61457;
            this.mainExit.SymbolSize = 40;
            this.mainExit.TabIndex = 7;
            this.mainExit.Click += new System.EventHandler(this.mainExit_Click);
            // 
            // help
            // 
            this.help.BackColor = System.Drawing.Color.Transparent;
            this.help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.help.FillColor = System.Drawing.Color.Transparent;
            this.help.FillDisableColor = System.Drawing.Color.Transparent;
            this.help.FillHoverColor = System.Drawing.Color.Transparent;
            this.help.FillPressColor = System.Drawing.Color.Transparent;
            this.help.FillSelectedColor = System.Drawing.Color.Transparent;
            this.help.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.help.ForeColor = System.Drawing.Color.Orange;
            this.help.ForeHoverColor = System.Drawing.Color.Orange;
            this.help.ForePressColor = System.Drawing.Color.Cyan;
            this.help.ForeSelectedColor = System.Drawing.Color.Cyan;
            this.help.IsCircle = true;
            this.help.Location = new System.Drawing.Point(432, 353);
            this.help.MinimumSize = new System.Drawing.Size(1, 1);
            this.help.Name = "help";
            this.help.RectColor = System.Drawing.Color.Transparent;
            this.help.RectHoverColor = System.Drawing.Color.Transparent;
            this.help.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.help.Size = new System.Drawing.Size(49, 52);
            this.help.Style = Sunny.UI.UIStyle.Custom;
            this.help.Symbol = 61736;
            this.help.SymbolSize = 40;
            this.help.TabIndex = 8;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // mainTitle
            // 
            this.mainTitle.BackColor = System.Drawing.Color.Transparent;
            this.mainTitle.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.mainTitle.ForeColor = System.Drawing.Color.FloralWhite;
            this.mainTitle.Location = new System.Drawing.Point(12, 23);
            this.mainTitle.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Padding = new System.Windows.Forms.Padding(34, 0, 0, 0);
            this.mainTitle.Size = new System.Drawing.Size(194, 35);
            this.mainTitle.Style = Sunny.UI.UIStyle.Custom;
            this.mainTitle.Symbol = 62160;
            this.mainTitle.SymbolColor = System.Drawing.Color.Silver;
            this.mainTitle.SymbolSize = 30;
            this.mainTitle.TabIndex = 9;
            this.mainTitle.Text = "고객차량관리앱 v1.0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CustCar0415.Properties.Resources.타이칸;
            this.pictureBox1.Location = new System.Drawing.Point(12, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(405, 387);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainWin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(614, 450);
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
            this.ForeColor = System.Drawing.Color.Gold;
            this.Name = "MainWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UISymbolButton randInsert;
        private Sunny.UI.UISymbolButton randDel;
        private Sunny.UI.UISymbolButton dataView;
        private Sunny.UI.UISymbolButton dataInsert;
        private Sunny.UI.UISymbolButton dataUpdate;
        private Sunny.UI.UISymbolButton dataDel;
        private Sunny.UI.UISymbolButton mainExit;
        private Sunny.UI.UISymbolButton help;
        private Sunny.UI.UISymbolLabel mainTitle;
    }
}

