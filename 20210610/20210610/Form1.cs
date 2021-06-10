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
using System.Xml.Linq;

namespace _20210610
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button_XMLread_Click(object sender, EventArgs e)
        {
            try
            {
                string xmlfile = File.ReadAllText("Student.xml");
                XElement student_xml = XElement.Parse(xmlfile);

                //Parse
                //문자열을 숫자로 변환하는 방법
                //1. int num1 = int.Parse("1234");
                //2. int num2 = 0;
                //   TryParse("1234", out num2);
                //3. 1번 방법으로 하되, try catch로 감싼다.

                students.Clear(); // 읽기 눌렀을때 중복되는것 방지

                foreach(var item in student_xml.Descendants("student"))
                {
                    string name = item.Element("name").Value;
                    int age = int.Parse(item.Element("age").Value);
                    string hakbeon = item.Element("hakbeon").Value;
                    string hakgwa = item.Element("hakgwa").Value;
                    string gender = item.Element("gender").Value;

                    students.Add(new Student(name, age, hakbeon, hakgwa, gender));
                }
                dataGridView1_student.DataSource = null;
                dataGridView1_student.DataSource = students;
            }
            catch (Exception ee)
            {

            }
        }

        private void button_write_Click(object sender, EventArgs e)
        {
            students.Add(new Student(textBox_name.Text, int.Parse(textBox_age.Text), textBox_hakbeon.Text, textBox_hakgwa.Text, comboBox_gender.Text));

            dataGridView1_student.DataSource = null;
            dataGridView1_student.DataSource = students;

            string input = "<students>\n";
            foreach (var item in students)
            {
                input += "<student>";
                input += $" <name>{item.name}</name>{Environment.NewLine}";
                input += $" <age>{item.age}</age>{Environment.NewLine}";
                input += $" <hakbeon>{item.hakbeon}</hakbeon>{Environment.NewLine}";
                input += $" <hakgwa>{item.hakgwa}</hakgwa>{Environment.NewLine}";
                input += $" <gender>{item.gender}</gender>{Environment.NewLine}";
                input += "</student>\n";
            }
            
            input += "</students>";
            File.WriteAllText("Student.xml", input);
        }

        private void button_api_Click(object sender, EventArgs e)
        {
            string url = $"http://apis.data.go.kr/1470000/DURPrdlstInfoService/getUsjntTabooInfoList";
            string myKey = "OdXDUPZk1H5uGX4y0vqwIi2zUsKo6rJTaf7n87m0lLKmr2fr1D1156FYBO1thOiWeZ5sL3u078PqfRmambn9rQ%3D%3D";
            //?ServiceKey=서비스키(URL Encode)&numOfRows=3&pageNo=1
            url += "?ServiceKey=" + myKey;
            url += "&numOfRows=3";

            Console.WriteLine(url);
            XElement api = XElement.Load(url);
            List<Drug> drugs = new List<Drug>();

            foreach (var item in api.Descendants("item"))
            {
                string item_name = item.Element("ITEM_NAME").Value;
                string item_seq = item.Element("ITEM_SEQ").Value;
                string entp = item.Element("ENTP_NAME").Value;

                drugs.Add(new Drug(item_name, item_seq, entp));
            }
            dataGridView2_api.DataSource = drugs;
        }
    }
}
