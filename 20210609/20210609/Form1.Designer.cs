
namespace _20210609
{
    partial class Form1
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
            this.button_insa = new System.Windows.Forms.Button();
            this.button_output = new System.Windows.Forms.Button();
            this.textBox_Contents = new System.Windows.Forms.TextBox();
            this.button_txtWrite = new System.Windows.Forms.Button();
            this.button_readText = new System.Windows.Forms.Button();
            this.textBox_memo = new System.Windows.Forms.TextBox();
            this.label_contents = new System.Windows.Forms.Label();
            this.button_continueWrite = new System.Windows.Forms.Button();
            this.button_usingRead = new System.Windows.Forms.Button();
            this.label_from_using = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_insa
            // 
            this.button_insa.Location = new System.Drawing.Point(12, 12);
            this.button_insa.Name = "button_insa";
            this.button_insa.Size = new System.Drawing.Size(156, 42);
            this.button_insa.TabIndex = 0;
            this.button_insa.Text = "인사 버튼";
            this.button_insa.UseVisualStyleBackColor = true;
            this.button_insa.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_output
            // 
            this.button_output.Location = new System.Drawing.Point(12, 60);
            this.button_output.Name = "button_output";
            this.button_output.Size = new System.Drawing.Size(156, 42);
            this.button_output.TabIndex = 1;
            this.button_output.Text = "텍스트박스내용";
            this.button_output.UseVisualStyleBackColor = true;
            this.button_output.Click += new System.EventHandler(this.button_output_Click);
            // 
            // textBox_Contents
            // 
            this.textBox_Contents.Location = new System.Drawing.Point(192, 24);
            this.textBox_Contents.Name = "textBox_Contents";
            this.textBox_Contents.Size = new System.Drawing.Size(193, 21);
            this.textBox_Contents.TabIndex = 2;
            // 
            // button_txtWrite
            // 
            this.button_txtWrite.AutoSize = true;
            this.button_txtWrite.Location = new System.Drawing.Point(12, 108);
            this.button_txtWrite.Name = "button_txtWrite";
            this.button_txtWrite.Size = new System.Drawing.Size(156, 42);
            this.button_txtWrite.TabIndex = 3;
            this.button_txtWrite.Text = "메모장에 쓰기";
            this.button_txtWrite.UseVisualStyleBackColor = true;
            this.button_txtWrite.Click += new System.EventHandler(this.button_txtWrite_Click);
            // 
            // button_readText
            // 
            this.button_readText.Location = new System.Drawing.Point(12, 156);
            this.button_readText.Name = "button_readText";
            this.button_readText.Size = new System.Drawing.Size(156, 42);
            this.button_readText.TabIndex = 4;
            this.button_readText.Text = "메모장에서 읽기";
            this.button_readText.UseVisualStyleBackColor = true;
            this.button_readText.Click += new System.EventHandler(this.button_textread_Click);
            // 
            // textBox_memo
            // 
            this.textBox_memo.Location = new System.Drawing.Point(192, 120);
            this.textBox_memo.Name = "textBox_memo";
            this.textBox_memo.Size = new System.Drawing.Size(193, 21);
            this.textBox_memo.TabIndex = 5;
            // 
            // label_contents
            // 
            this.label_contents.AutoSize = true;
            this.label_contents.Location = new System.Drawing.Point(200, 171);
            this.label_contents.Name = "label_contents";
            this.label_contents.Size = new System.Drawing.Size(11, 12);
            this.label_contents.TabIndex = 6;
            this.label_contents.Text = "-";
            this.label_contents.Visible = false;
            // 
            // button_continueWrite
            // 
            this.button_continueWrite.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_continueWrite.Location = new System.Drawing.Point(12, 204);
            this.button_continueWrite.Name = "button_continueWrite";
            this.button_continueWrite.Size = new System.Drawing.Size(156, 42);
            this.button_continueWrite.TabIndex = 7;
            this.button_continueWrite.Text = "이어서적기";
            this.button_continueWrite.UseVisualStyleBackColor = true;
            this.button_continueWrite.Click += new System.EventHandler(this.button_continueWrite_Click);
            // 
            // button_usingRead
            // 
            this.button_usingRead.Location = new System.Drawing.Point(429, 12);
            this.button_usingRead.Name = "button_usingRead";
            this.button_usingRead.Size = new System.Drawing.Size(140, 42);
            this.button_usingRead.TabIndex = 8;
            this.button_usingRead.Text = "using으로 읽기";
            this.button_usingRead.UseVisualStyleBackColor = true;
            this.button_usingRead.Click += new System.EventHandler(this.button_usingRead_Click);
            // 
            // label_from_using
            // 
            this.label_from_using.AutoSize = true;
            this.label_from_using.Location = new System.Drawing.Point(442, 61);
            this.label_from_using.Name = "label_from_using";
            this.label_from_using.Size = new System.Drawing.Size(65, 12);
            this.label_from_using.TabIndex = 9;
            this.label_from_using.Text = "아무렇게나";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_from_using);
            this.Controls.Add(this.button_usingRead);
            this.Controls.Add(this.button_continueWrite);
            this.Controls.Add(this.label_contents);
            this.Controls.Add(this.textBox_memo);
            this.Controls.Add(this.button_readText);
            this.Controls.Add(this.button_txtWrite);
            this.Controls.Add(this.textBox_Contents);
            this.Controls.Add(this.button_output);
            this.Controls.Add(this.button_insa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_insa;
        private System.Windows.Forms.Button button_output;
        private System.Windows.Forms.TextBox textBox_Contents;
        private System.Windows.Forms.Button button_txtWrite;
        private System.Windows.Forms.Button button_readText;
        private System.Windows.Forms.TextBox textBox_memo;
        private System.Windows.Forms.Label label_contents;
        private System.Windows.Forms.Button button_continueWrite;
        private System.Windows.Forms.Button button_usingRead;
        private System.Windows.Forms.Label label_from_using;
    }
}

