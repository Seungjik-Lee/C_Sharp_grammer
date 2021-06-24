using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210623
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var even = from item in input where item % 2 == 0 select item;
            string test = "";
            foreach (var item in even)
            {
                test += item + "  ";
            }
            Console.WriteLine(test);

            button3.Click += button3_Click;
            button4.Click += (sender, e) => { MessageBox.Show("람다로 이벤트 추가"); };
            button3.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*            // 특정 폴더가 있는지 여부 확인 후 없으면 생성
                        DirectoryInfo di = new DirectoryInfo("History");
                        if(di.Exists == false)
                        {
                            di.Create();
                        }

                        // 만약 해당 폴더가 있을 경우 해당 폴더 안에 파일을 적음
                        using (StreamWriter writer = new StreamWriter("History\\History.txt", true))
                        {
                            writer.WriteLine(DateTime.Now.ToString("yyyy/mm/dd HH:mm:ss.fff"));
                        }

                        // 텍스트 파일에 적은 내용을 listbox에도 표시한다.*/
            printLog("[" + DateTime.Now.ToString("yyyy/mm/dd HH:mm:ss.fff") + "]" + textBox1.Text);
            displayLog("[" + DateTime.Now.ToString("yyyy/mm/dd HH:mm:ss.fff") + "]");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printLog("[" + DateTime.Now.ToString("yyyy/mm/dd HH:mm:ss.fff") + "]" + textBox1.Text);
            displayLog("[" + DateTime.Now.ToString("yyyy/mm/dd HH:mm:ss.fff") + "]" + textBox1.Text);
        }

        private void displayLog(string v)
        {
            // 가장 최근에 추가한 것이 맨 밑으로
            //listBox1.Items.Add(v);

            // 가장 최근에 추가한 것이 맨 위로
            listBox1.Items.Insert(0, v);
        }

        private void printLog(string text)
        {
            // 특정 폴더가 있는지 여부 확인 후 없으면 생성
            DirectoryInfo di = new DirectoryInfo("History");
            if (di.Exists == false)
            {
                di.Create();
            }

            // 만약 해당 폴더가 있을 경우 해당 폴더 안에 파일을 적음
            using (StreamWriter writer = new StreamWriter("History\\History.txt", true))
            {
                writer.WriteLine(text);
            }

            // 텍스트 파일에 적은 내용을 listbox에도 표시한다.
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }

        public delegate void voidFunction();
        private void button_study_Delegate_Click(object sender, EventArgs e)
        {

#if DEBUG // Debug 모드일때만 실행

#else
            if (false)
            {
                voidFunction v = temp;
                v();
                useDelegate(v);
            }
#endif

            voidFunction v2 = delegate () { MessageBox.Show("익명 델리게이트 사용"); };
            useDelegate(v2);

            voidFunction lamda = () =>
            {
                MessageBox.Show("람다 사용");
            };

            lamda();
        }

        public void temp()
        {
            MessageBox.Show("매개변수랑 반환값 없는 함수");
        }

        public void useDelegate(voidFunction v)
        {
            for(int i = 0; i <3; i++)
            {
                v();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("이벤트 추가시 이미 델리게이트 썼었음");
        }
    }
}
