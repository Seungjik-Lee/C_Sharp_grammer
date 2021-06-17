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
using System.Xml.Linq;

namespace Json_Read_Write
{
    public partial class Form1 : Form
    {
        public List<Customer> customers = new List<Customer>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button_write_Json_Click(object sender, EventArgs e)
        {
            var jCustomerArray = new JArray();

            var jCustomerObject = new JObject();

            for (int i = 0; i < customers.Count; i++)
            {
                jCustomerObject = new JObject();
                jCustomerObject.Add("CustomerName", customers[i].CustomerName);
                jCustomerObject.Add("Telecom_Company", customers[i].Telecom_Company);
                jCustomerObject.Add("TeleNumber", customers[i].TeleNumber);
                jCustomerObject.Add("Period", customers[i].Period);
                jCustomerObject.Add("Model", customers[i].Model);
                jCustomerArray.Add(jCustomerObject);
            }

            jCustomerObject = new JObject();
            jCustomerObject.Add("CustomerName", textBox_name.Text);
            jCustomerObject.Add("Telecom_Company", textBox_company.Text);
            jCustomerObject.Add("TeleNumber", textBox_number.Text);
            jCustomerObject.Add("Period", textBox_period.Text);
            jCustomerObject.Add("Model", textBox_model.Text);

            jCustomerArray.Add(jCustomerObject);

            var jCustomerArray_object = new JObject();
            jCustomerArray_object.Add("customer", jCustomerArray);

            var jCustomer_Object = new JObject();
            jCustomer_Object.Add("customers", jCustomerArray_object);

            File.WriteAllText(@"./Customers.json", jCustomer_Object.ToString());
        }

        private void button_read_Json_Click(object sender, EventArgs e)
        {
            customers.Clear();

            string source = File.ReadAllText("Customers.json");
            JObject jsonObjectCustomer = JObject.Parse(source);

            //linq
            //리스트에 값을 넣는 방법 중 하나

            customers = (from item in jsonObjectCustomer["customers"]["customer"]
                         select new Customer()
                         {
                             CustomerName = item["CustomerName"].ToString().Replace("{", "").Replace("}", ""),
                             Telecom_Company = item["Telecom_Company"].ToString().Replace("{", "").Replace("}", ""),
                             TeleNumber = item["TeleNumber"].ToString().Replace("{", "").Replace("}", ""),
                             Period = item["Period"].ToString().Replace("{", "").Replace("}", ""),
                             Model = item["Model"].ToString().Replace("{", "").Replace("}", "")
                         }
            ).ToList<Customer>();

            dataGridView1.DataSource = customers;   
        }

        private void button_read_api_Click(object sender, EventArgs e)
        {
            try
            {
                string url = $"http://apis.data.go.kr/1721301/KpostDepositProductView/depositGoods";
                string myKey = "OdXDUPZk1H5uGX4y0vqwIi2zUsKo6rJTaf7n87m0lLKmr2fr1D1156FYBO1thOiWeZ5sL3u078PqfRmambn9rQ==";//"OdXDUPZk1H5uGX4y0vqwIi2zUsKo6rJTaf7n87m0lLKmr2fr1D1156FYBO1thOiWeZ5sL3u078PqfRmambn9rQ%3D%3D";
                /*string myKey2 = "OdXDUPZk1H5uGX4y0vqwIi2zUsKo6rJTaf7n87m0lLKmr2fr1D1156FYBO1thOiWeZ5sL3u078PqfRmambn9rQ%3D%3D";*/
                //?ServiceKey=서비스키(URL Encode)&numOfRows=3&pageNo=1
                url += "?serviceKey=" + myKey;
                url += "&GOOD_KOR_NM=Smart";

                Console.WriteLine(url);
                XElement api = XElement.Load(url);
                List<Post> posts = new List<Post>();
                Console.WriteLine(posts);

                using (WebClient wc = new WebClient()) 
                {
                    var json = new WebClient().DownloadString(url); 
                    Console.WriteLine(json.ToString()); 
                }

                foreach (var item in api.Descendants("item"))
                {
                    string item_1 = item.Element("GOOD_CLSF").Value;
                    string item_2 = item.Element("GOOD_KOR_NM").Value;
                    string item_3 = item.Element("MAN1_ACC1_ITMS_YN").Value;
                    string item_4 = item.Element("CARD_ISUE_PSBL_YN").Value;
                    string item_5 = item.Element("INTR_PAY_PSBL_YN").Value;
                    string item_6 = item.Element("INTR_PAY_KIND").Value;
                    string item_7 = item.Element("ENTR_CUST_DVSN").Value;
                    string item_8 = item.Element("GOOD_TAXT_DVSN").Value;
                    string item_9 = item.Element("REGISTER_MIN").Value;
                    string item_10 = item.Element("REGISTER_MAX").Value;
                    string item_11 = item.Element("resultCode").Value;
                    string item_12 = item.Element("resultMsg").Value;

                    posts.Add(new Post(item_1, item_2, item_3, item_4, item_5, item_6, item_7, item_8, item_9, item_10, item_11, item_12));
                }
                dataGridView2.DataSource = posts;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
