
namespace Extends_Interface
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
            this.button_Animal = new System.Windows.Forms.Button();
            this.button_Cat = new System.Windows.Forms.Button();
            this.button_Dog = new System.Windows.Forms.Button();
            this.button_Animals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Animal
            // 
            this.button_Animal.Location = new System.Drawing.Point(12, 12);
            this.button_Animal.Name = "button_Animal";
            this.button_Animal.Size = new System.Drawing.Size(75, 23);
            this.button_Animal.TabIndex = 0;
            this.button_Animal.Text = "동물";
            this.button_Animal.UseVisualStyleBackColor = true;
            this.button_Animal.Click += new System.EventHandler(this.button_Animal_Click);
            // 
            // button_Cat
            // 
            this.button_Cat.Location = new System.Drawing.Point(93, 12);
            this.button_Cat.Name = "button_Cat";
            this.button_Cat.Size = new System.Drawing.Size(75, 23);
            this.button_Cat.TabIndex = 1;
            this.button_Cat.Text = "고양이";
            this.button_Cat.UseVisualStyleBackColor = true;
            this.button_Cat.Click += new System.EventHandler(this.button_Cat_Click);
            // 
            // button_Dog
            // 
            this.button_Dog.Location = new System.Drawing.Point(174, 12);
            this.button_Dog.Name = "button_Dog";
            this.button_Dog.Size = new System.Drawing.Size(75, 23);
            this.button_Dog.TabIndex = 2;
            this.button_Dog.Text = "개";
            this.button_Dog.UseVisualStyleBackColor = true;
            this.button_Dog.Click += new System.EventHandler(this.button_Dog_Click);
            // 
            // button_Animals
            // 
            this.button_Animals.Location = new System.Drawing.Point(12, 215);
            this.button_Animals.Name = "button_Animals";
            this.button_Animals.Size = new System.Drawing.Size(237, 23);
            this.button_Animals.TabIndex = 3;
            this.button_Animals.Text = "동물들";
            this.button_Animals.UseVisualStyleBackColor = true;
            this.button_Animals.Click += new System.EventHandler(this.button_Animals_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Animals);
            this.Controls.Add(this.button_Dog);
            this.Controls.Add(this.button_Cat);
            this.Controls.Add(this.button_Animal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Animal;
        private System.Windows.Forms.Button button_Cat;
        private System.Windows.Forms.Button button_Dog;
        private System.Windows.Forms.Button button_Animals;
    }
}

