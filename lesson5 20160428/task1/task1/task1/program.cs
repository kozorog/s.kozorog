using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class program
    {
        static void Main(string[] args)
        //   Реализовать классы для описания клиентов двух типов: ИП и ООО.
        //Каждый тип клиента имеет идентификатор, основной телефон, сумма заказа.
        //У ИП указывается ФИО, дата рождения.У ООО указывается название, 
        //банковский счет.Реализовать метод, который возвращает отформатированное название и сумму заказа.

        {
            List<Client> clients = new List<Client>();
            //создаем кучу объектов
            IpClient ip = new IpClient("Petya", new DateTime(1979, 11, 15), 23, "123456", 999);
            clients.Add(ip);
            OooClient ooo = new OooClient("Roga", "123456789101112", 555, "654321", 9999901);
            clients.Add(ooo);

            foreach (Client c in clients)
            {
                Console.WriteLine(c.GetInfo());
            }

        }

    }
}
