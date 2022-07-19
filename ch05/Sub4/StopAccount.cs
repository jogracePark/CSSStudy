using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch05.Sub4
{
    internal class StopAccount : Account
    {
        private string stock;
        private int amount;
        private int price;

        public StopAccount(string bank, string id, string name, int balance, string stock, int amount, int price) : base(bank, id, name, balance)
        {
            this.stock = stock;
            this.amount = amount;
            this.price = price;
        }

        public void Sell(int amount, int price)
        {
            this.amount -= amount;
            this.balance += amount * price;
        }

        public void Buy(int amount, int price)
        {
            this.amount += amount;
            this.balance -= amount * price;
        }

        public void Show()
        {
            base.Show();
            Console.WriteLine("주식 종목 : " + stock);
            Console.WriteLine("주식 수량 : " + amount);
            Console.WriteLine("주식 가격 : " + price);

        }
    }
}
