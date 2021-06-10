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

namespace readCSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_readcsv_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("test.csv", Encoding.GetEncoding("UTF-8"));

            label_contents.Text = reader.ReadLine() + Environment.NewLine;
            //label_contents.Text += reader.ReadLine();

            List<Student> students = new List<Student>();
            List<Student_Gridview> students_gridview = new List<Student_Gridview>();


            while (!reader.EndOfStream) // 아무것도 없을 때까지 읽음
            {
                string[] temp = reader.ReadLine().Split(',');
                string name = temp[0]; //이승직
                int age = int.Parse(temp[1]); //"26"
                string hakbeon = temp[2]; //5610674
                string hakgwa = temp[3]; // 전자공학과
                string gender = temp[4]; // 남
                Student st = new Student(name, age, hakbeon, hakgwa, gender);
                students.Add(st);
                Student_Gridview stg = new Student_Gridview(name, age, hakbeon, hakgwa, gender);
                students_gridview.Add(stg);
            }

            for(int i = 0; i < students.Count; i++)
            {
                label_contents.Text += students[i].name + " " + students[i].age + " " + students[i].hakbeon + " " + students[i].hakgwa + " " + students[i].gender + " " + Environment.NewLine;
            }
            reader.Dispose(); // 내가 직접 해제 해줌
            dataGridView1.DataSource = students_gridview;
        }

        private void button_writecsv_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("test.csv", true);

            writer.WriteLine($"{textBox_name.Text},{textBox_age.Text},{textBox_hakbeon.Text},{textBox_hakgwa.Text},{comboBox_gender.Text}");
            writer.Dispose(); // 수동으로 메모리 해제
        }

        private void button_readcsv2_Click(object sender, EventArgs e)
        {
            //Modal
            //창이 뜨면 코드가 그 줄에서 멈춤
            //Modeless
            //창 띄우고 그 다음 코드 진행함, 그 뒤에꺼 클릭 가능

            //1. 인스턴스 바로 생성하고 띄우기
            new Form2().ShowDialog();

            //2. 변수 선언하고 그 변수 띄우기
            Form2 temp = new Form2();
            temp.ShowDialog();

        }
    }
}
