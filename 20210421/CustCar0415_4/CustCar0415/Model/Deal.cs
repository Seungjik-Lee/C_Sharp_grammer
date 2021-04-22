using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustCar0415.Model
{
    class Deal<Ca, Cu, Se>
    {
        private Ca ca;
        private Cu cu;
        private Se se;
        private string date;
        private string price;

        public Deal(Ca ca, Cu cu, Se se, 
            string date, string price)
        {
            this.ca = ca;
            this.cu = cu;
            this.se = se;
            this.date = date;
            this.price = price;
        }

        public Ca Car { get => ca; set => ca = value; }
        public Cu Customer { get => cu; set => cu = value; }
        public Se Seller { get => se; set => se = value; }
        public string Date { get => date; set => date = value; }
        public string Price { get => price; set => price = value; }

        public override string ToString()
        {
            Car car = this.Car as Car;
            Customer customer = this.Customer as Customer;
            Seller seller = this.Seller as Seller;
            string data = "★★구매 차량 정보★★\n";
            data += car.ToString();
            data += "★★구매 고객 정보★★\n";
            data += customer.ToString();
            data += "★★판매자 정보★★\n";
            data += seller.ToString();
            data += "★★거래 정보★★\n";
            data += "거래날짜: " + date + "\n";
            data += "거래금액: " + price + "\n";
            return data;
        }

        public void dealInfo()
        {
            Car car = this.Car as Car;
            Customer customer = this.Customer as Customer;
            Seller seller = this.Seller as Seller;
            Console.WriteLine("★★거래 요약 정보★★");
            Console.WriteLine("차량모델: " + car.Model);
            Console.WriteLine("차량가격: " + car.Price);
            Console.WriteLine("구매자: " + customer.Name);
            Console.WriteLine("판매자: " + seller.Name);
            Console.WriteLine("거래일: " + date);
            Console.WriteLine("실거래가: " + price);

        }
    }
}
