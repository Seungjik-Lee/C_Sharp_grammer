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

namespace _20210609
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //mbox 치고 탭키 두번
            MessageBox.Show("오랜만에 하는 C#");
        }

        private void button_output_Click(object sender, EventArgs e)
        {
            int A = 100;
            MessageBox.Show(textBox_Contents.Text);
            MessageBox.Show(10 + "안녕" + 100 + A);
            int B = 1000;
            MessageBox.Show(B.ToString());

            //string.format
            string contents = string.Format("{0} + {1} = {2}", A, B, A + B);
            Console.WriteLine(contents);
            //$
            contents = $"{A} + {B} = {A + B + 9999}";
            Console.WriteLine(contents);

            contents = $"안녕 내 이름은 이승직이고 내 나이는" + 26 + "살이야";
            contents = $"안녕 내 이름은 이승직이고 내 나이는 {26}살이야";
            contents = string.Format("안녕 내 이름은 이승직이고 내 나이는 {0}살이야", 26);
            Console.WriteLine(contents);
        }

        private void button_txtWrite_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"./test.txt", "안녕하세요~");
            File.WriteAllText(@"./test2.txt", textBox_memo.Text);
            File.WriteAllText("D:\\A\\test.txt", textBox_memo.Text);
            File.WriteAllText(@"D:\A\test2.txt", textBox_memo.Text);

        }

        private void button_textread_Click(object sender, EventArgs e)
        {
            label_contents.Visible = true;
            label_contents.Text = File.ReadAllText("./test2.txt");
        }

        private void button_continueWrite_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("./test2.txt", true))
            {
                writer.WriteLine(textBox_memo.Text);
                writer.Write("한줄 안 띄운다");
                writer.Write("ㅁㅁㅁㅁㅁㅁㅁ");
            }
        }

        private void button_usingRead_Click(object sender, EventArgs e)
        {
            label_from_using.Text = "";
            using (StreamReader reader = new StreamReader("./test2.txt"))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    label_from_using.Text += line + Environment.NewLine;
                    // "\n"
                }
            }

        }
    }
}
