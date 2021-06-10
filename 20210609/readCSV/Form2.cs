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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            StreamReader reader = new StreamReader("daegu.csv", Encoding.GetEncoding("UTF-8"));
            reader.ReadLine();
            List<Daegu> daegu_form2 = new List<Daegu>();
            while (!reader.EndOfStream)
            {
                string[] input = reader.ReadLine().Split('|');



                daegu_form2.Add(new Daegu(input[0], input[1], input[2], input[3], input[4], input[5], input[6],
 input[7],
 input[8],
 input[9],
input[10],
input[11],
input[12],
input[13],
input[14],
input[15],
input[16],
input[17],
input[18],
input[19],
input[20],
input[21],
input[22],
input[23],
input[24],
input[25],
input[26],
input[27],
input[28],
input[29],
input[30],
input[31],
input[32],
input[33],
input[34],
input[35],
input[36],
input[37],
input[38]));
            }
            dataGridView_daegu.DataSource = daegu_form2;
            reader.Dispose();
            // string[] temp = "상가업소번호|상호명|지점명|상권업종대분류코드|상권업종대분류명|상권업종중분류코드|상권업종중분류명|상권업종소분류코드|상권업종소분류명|표준산업분류코드|표준산업분류명|시도코드|시도명|시군구코드|시군구명|행정동코드|행정동명|법정동코드|법정동명|지번코드|대지구분코드|대지구분명|지번본번지|지번부번지|지번주소|도로명코드|도로명|건물본번지|건물부번지|건물관리번호|건물명|도로명주소|구우편번호|신우편번호|동정보|층정보|호정보|경도|위도".Split('|');

            //for (int i = 0; i < temp.Length; i++)
            //{
            //    Console.WriteLine("input[" + i + "]");
            //}
            //for (int i = 0; i < temp.Length; i++)
            //{
            //    Console.WriteLine("string " + temp[i] + ",");
            //}
            //for (int i = 0; i < temp.Length; i++)
            //{
            //    Console.WriteLine("public string " + temp[i] + "{get;set;}");
            //}
            //for (int i = 0; i < temp.Length; i++)
            //{
            //    Console.WriteLine("this." + temp[i] + "="+temp[i]+";");
            //}
        }
    }
}
