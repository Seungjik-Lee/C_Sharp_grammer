
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
            this.cxFlatRoundButton1 = new CxFlatUI.CxFlatRoundButton();
            this.cxFlatRoundButton2 = new CxFlatUI.CxFlatRoundButton();
            this.cxFlatRoundButton3 = new CxFlatUI.CxFlatRoundButton();
            this.cxFlatRoundButton4 = new CxFlatUI.CxFlatRoundButton();
            this.cxFlatRoundButton5 = new CxFlatUI.CxFlatRoundButton();
            this.cxFlatRoundButton6 = new CxFlatUI.CxFlatRoundButton();
            this.mainExit = new Sunny.UI.UISymbolButton();
            this.help = new Sunny.UI.UISymbolButton();
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
            // cxFlatRoundButton1
            // 
            this.cxFlatRoundButton1.ButtonType = CxFlatUI.ButtonType.Primary;
            this.cxFlatRoundButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatRoundButton1.Location = new System.Drawing.Point(379, 94);
            this.cxFlatRoundButton1.Name = "cxFlatRoundButton1";
            this.cxFlatRoundButton1.Size = new System.Drawing.Size(183, 50);
            this.cxFlatRoundButton1.TabIndex = 2;
            this.cxFlatRoundButton1.Text = "랜덤데이터 추가";
            this.cxFlatRoundButton1.TextColor = System.Drawing.Color.White;
            // 
            // cxFlatRoundButton2
            // 
            this.cxFlatRoundButton2.ButtonType = CxFlatUI.ButtonType.Primary;
            this.cxFlatRoundButton2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatRoundButton2.Location = new System.Drawing.Point(427, 166);
            this.cxFlatRoundButton2.Name = "cxFlatRoundButton2";
            this.cxFlatRoundButton2.Size = new System.Drawing.Size(183, 50);
            this.cxFlatRoundButton2.TabIndex = 3;
            this.cxFlatRoundButton2.Text = "랜덤 데이터 삭제";
            this.cxFlatRoundButton2.TextColor = System.Drawing.Color.White;
            // 
            // cxFlatRoundButton3
            // 
            this.cxFlatRoundButton3.ButtonType = CxFlatUI.ButtonType.Primary;
            this.cxFlatRoundButton3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatRoundButton3.Location = new System.Drawing.Point(468, 237);
            this.cxFlatRoundButton3.Name = "cxFlatRoundButton3";
            this.cxFlatRoundButton3.Size = new System.Drawing.Size(183, 50);
            this.cxFlatRoundButton3.TabIndex = 4;
            this.cxFlatRoundButton3.Text = "데이터 보기";
            this.cxFlatRoundButton3.TextColor = System.Drawing.Color.White;
            // 
            // cxFlatRoundButton4
            // 
            this.cxFlatRoundButton4.ButtonType = CxFlatUI.ButtonType.Primary;
            this.cxFlatRoundButton4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatRoundButton4.Location = new System.Drawing.Point(468, 303);
            this.cxFlatRoundButton4.Name = "cxFlatRoundButton4";
            this.cxFlatRoundButton4.Size = new System.Drawing.Size(183, 50);
            this.cxFlatRoundButton4.TabIndex = 5;
            this.cxFlatRoundButton4.Text = "데이터 추가";
            this.cxFlatRoundButton4.TextColor = System.Drawing.Color.White;
            // 
            // cxFlatRoundButton5
            // 
            this.cxFlatRoundButton5.ButtonType = CxFlatUI.ButtonType.Primary;
            this.cxFlatRoundButton5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatRoundButton5.Location = new System.Drawing.Point(427, 376);
            this.cxFlatRoundButton5.Name = "cxFlatRoundButton5";
            this.cxFlatRoundButton5.Size = new System.Drawing.Size(183, 50);
            this.cxFlatRoundButton5.TabIndex = 6;
            this.cxFlatRoundButton5.Text = "데이터 수정";
            this.cxFlatRoundButton5.TextColor = System.Drawing.Color.White;
            // 
            // cxFlatRoundButton6
            // 
            this.cxFlatRoundButton6.ButtonType = CxFlatUI.ButtonType.Primary;
            this.cxFlatRoundButton6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatRoundButton6.Location = new System.Drawing.Point(379, 451);
            this.cxFlatRoundButton6.Name = "cxFlatRoundButton6";
            this.cxFlatRoundButton6.Size = new System.Drawing.Size(183, 50);
            this.cxFlatRoundButton6.TabIndex = 7;
            this.cxFlatRoundButton6.Text = "데이터 삭제";
            this.cxFlatRoundButton6.TextColor = System.Drawing.Color.White;
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
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 526);
            this.Controls.Add(this.help);
            this.Controls.Add(this.mainExit);
            this.Controls.Add(this.cxFlatRoundButton6);
            this.Controls.Add(this.cxFlatRoundButton5);
            this.Controls.Add(this.cxFlatRoundButton4);
            this.Controls.Add(this.cxFlatRoundButton3);
            this.Controls.Add(this.cxFlatRoundButton2);
            this.Controls.Add(this.cxFlatRoundButton1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "고객차량관리앱 v1.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private CxFlatUI.CxFlatRoundButton cxFlatRoundButton1;
        private CxFlatUI.CxFlatRoundButton cxFlatRoundButton2;
        private CxFlatUI.CxFlatRoundButton cxFlatRoundButton3;
        private CxFlatUI.CxFlatRoundButton cxFlatRoundButton4;
        private CxFlatUI.CxFlatRoundButton cxFlatRoundButton5;
        private CxFlatUI.CxFlatRoundButton cxFlatRoundButton6;
        private Sunny.UI.UISymbolButton mainExit;
        private Sunny.UI.UISymbolButton help;
    }
}

