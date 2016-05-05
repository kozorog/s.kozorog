using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class Program
    {
        static void Main(string[] args)
        {
            //ввод данных. 

            List<SettlementAccount> clients = new List<SettlementAccount>();
            //создаем кучу объектов
            IpClient ip = new IpClient("Petya", new DateTime(1979, 11, 15), 23, "123456", 999);
            clients.Add(ip);


            



        }
    }
}
