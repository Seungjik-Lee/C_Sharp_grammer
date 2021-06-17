using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210617
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //차트에 데이터 넣기
            chart1.Series[0].Name = "성적";
            for (int i = 1; i < 10; i++)
            {
                //chart1.Series[0].Points.AddXY(i, i * 10);
                chart1.Series["성적"].Points.AddXY(i, i * 10);
            }
            chart1.Series.Add("나이");
            for (int i = 1; i < 10; i++)
            {
                chart1.Series[1].Points.AddXY(i, i * 10);
            }
        }

        private void button_write_Click(object sender, EventArgs e)
        {
            var jDoctorArray = new JArray();
            var jDoctorObject = new JObject();

            try
            {
                load();
            }
            catch(Exception ex)
            {

            }

            //doctors 안에 아무것도 없다면
            if(doctors.Count > 0)
            {
                foreach(var item in doctors)
                {
                    jDoctorObject.Add("name", item.name);
                    jDoctorObject.Add("sabeon", item.sabeon);
                    jDoctorArray.Add(jDoctorObject);
                    jDoctorObject = new JObject();
                }
            }

            jDoctorObject = new JObject();
            jDoctorObject.Add("name", textBox_name.Text);
            jDoctorObject.Add("sabeon", textBox_sabeon.Text);

            jDoctorArray.Add(jDoctorObject);

            var jDoctorArray_object = new JObject();
            jDoctorArray_object.Add("doctors", jDoctorArray);
            var jDoctors_object = new JObject();
            jDoctors_object.Add("doctors", jDoctorArray_object);

            //특정 폴더에 넣고 싶을때 폴더가 없는 경우
            DirectoryInfo di = new DirectoryInfo("jsonEx");
            if (!di.Exists) //해당 폴더가 없는 경우
                di.Create(); // 만들기

            //파일만 생성하고 싶을 경우
            StreamWriter writer = File.CreateText("Docters.json");
            writer.Dispose(); //메모리 해제

            File.WriteAllText(@"jsonEx\Doctors.json", jDoctors_object.ToString());
        }

        List<Doctor> doctors = new List<Doctor>();

        private void button_read_Click(object sender, EventArgs e)
        {
            load();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = doctors;
        }

        private void load()
        {
            doctors.Clear();

            string source = File.ReadAllText(@"jsonEx\Doctor.json");
            JObject jsonObjectDoctor = JObject.Parse(source);

            foreach (var item in jsonObjectDoctor["doctors"]["doctor"])
            {
                Doctor temp = new Doctor();
                temp.name = item["name"].ToString().Replace("{", "").Replace("}", "");
                temp.sabeon = item["sabeon"].ToString().Replace("{", "").Replace("}", "");
                doctors.Add(temp);
            }
        }

        private void button_jsonAPI_Click(object sender, EventArgs e)
        {
            int count = 860;
            string url = "https://www.dhlottery.co.kr/common.do?method=getLottoNumber&drwNo=" + count;

            using (WebClient wc = new WebClient())
            {
                var json = new WebClient().DownloadString(url);
                var jarray = JObject.Parse(json);

                foreach (var item in jarray)
                {
                    Console.WriteLine(item.Key);
                    Console.WriteLine(item.Value);
                }

                Console.WriteLine(jarray["totSellanmt"]);
                DisplayLotto();
            }

        }

        private void DisplayLotto()
        {
            List<Lotto> lottos = new List<Lotto>();
            int[] array1 = new int[45];
            int count = 900;
            while (true)
            {
                using (WebClient wc = new WebClient())
                {
                    var joson = wc.DownloadString("https://www.dhlottery.co.kr/common.do?method=getLottoNumber&drwNo=" + count);
                    count++;

                    var jArray = JObject.Parse(joson);

                    if (jArray["returnValue"].ToString() == "fail")
                        break;

                    lottos.Add(new Lotto(
                        jArray["drwtNo1"].ToString(),
                        jArray["drwtNo2"].ToString(),
                        jArray["drwtNo3"].ToString(),
                        jArray["drwtNo4"].ToString(),
                        jArray["drwtNo5"].ToString(),
                        jArray["drwtNo6"].ToString(),
                        jArray["bnusNo"].ToString(),
                        jArray["drwNo"].ToString(),
                        jArray["drwNoDate"].ToString()
                        ));
                    array1[int.Parse(jArray["drwtNo1"].ToString()) - 1]++;
                    array1[int.Parse(jArray["drwtNo2"].ToString()) - 1]++;
                    array1[int.Parse(jArray["drwtNo3"].ToString()) - 1]++;
                    array1[int.Parse(jArray["drwtNo4"].ToString()) - 1]++;
                    array1[int.Parse(jArray["drwtNo5"].ToString()) - 1]++;
                    array1[int.Parse(jArray["drwtNo6"].ToString()) - 1]++;
                    array1[int.Parse(jArray["bnusNo"].ToString()) - 1]++;

                    
                }
            }

            chart2.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            chart2.ChartAreas[0].AxisX.Minimum = 1;

            for (int i = 0; i < 45; i++)
            {
                chart2.Series[0].Points.AddXY(i, array1[i]); 
            }
            dataGridView2.DataSource = lottos;
        }
    }
}
