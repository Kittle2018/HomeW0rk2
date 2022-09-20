using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace HomeW0rk2
{

    public class Data
    {
        public int a;
        public int b;
        public int c;
        public int d;
        public int e;
    }

    public class tvr
    {
        public string Name;
        public string Adress;
        public string Description;
        public string PhoneNumber;
        public string EMail;
        private string v;

        public tvr(string Name, string Adress, string Description, string PhoneNumber, string EMail)
        {
            this.Name = Name;
            this.Adress = Adress;
            this.Description = Description;
            this.PhoneNumber = PhoneNumber;
            this.EMail = EMail;
        }

        public tvr(string Name, string Adress, string Description, string PhoneNumber, string EMail, string v) : this(Name, Adress, Description, PhoneNumber, EMail)
        {
            this.v = v;
        }

        public void Print()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("adress: {0}", Adress);
            Console.WriteLine("Description: {0}", Description);
            Console.WriteLine("PhoneNumber: {0}", PhoneNumber);
            Console.WriteLine("EMail: {0}", EMail);
        }

    }
    class Info
    {
        static void Main(string[] args)
        {
            tvr ss = new tvr("DNS", "г. Шахты, Победа Революции, дом 118", "Российская компания, владелец розничной сети, специализирующейся на продаже компьютерной, цифровой и бытовой техники.", "+79896304079", "korp.yug@dns-shop.ru");
            tvr sb = new tvr("Сitilink", "ул. Победы Революции, д.111,", "одна из крупнейших сетей магазинов электроники и бытовой техники", "+7(863)627-90-09 ", "Zapros_rndb2b@citilink.ru");

            ss.Print();
            sb.Print();

            Console.ReadKey();
        }

    }




}
