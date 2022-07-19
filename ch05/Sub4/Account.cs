using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch05.Sub4
{
    internal class Account
    {
        protected string bank;
        protected string id;
        protected string name;
        protected int balance;

        public Account(string bank, string id, string name, int balance)
        {
            this.bank = bank;
            this.id = id;
            this.name = name;
            this.balance = balance;
        }

        public void Deposit(int balance)
        {
            this.balance = balance;
        }

        public void Show()
        {
            Console.WriteLine("=====================");
            Console.WriteLine("은행명 : " + bank);
            Console.WriteLine("계좌번호 : " + id);
            Console.WriteLine("주식명 : " + name);
            Console.WriteLine("현재잔액 : " + balance);
        }
    }
}
