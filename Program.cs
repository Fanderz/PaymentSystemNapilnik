using System;
using System.Text;

namespace PaymentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Default; 

            Order order = new Order(1,12000);

            PaySystem1 paySystem1 = new PaySystem1();
            PaySystem2 paySystem2 = new PaySystem2();
            PaySystem3 paySystem3 = new PaySystem3();

            Console.WriteLine(paySystem1.GetPayingLink(order));
            Console.WriteLine(paySystem2.GetPayingLink(order));
            Console.WriteLine(paySystem3.GetPayingLink(order));

            Console.ReadKey();

            //Выведите платёжные ссылки для трёх разных систем платежа: 
            //pay.system1.ru/order?amount=12000RUB&hash={MD5 хеш ID заказа}
            //order.system2.ru/pay?hash={MD5 хеш ID заказа + сумма заказа}
            //system3.com/pay?amount=12000&curency=RUB&hash={SHA-1 хеш сумма заказа + ID заказа + секретный ключ от системы}
        }
    }
}
