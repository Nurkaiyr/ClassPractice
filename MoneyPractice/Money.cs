using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyPractice
{
    public class Money
    {
        private int denomination;// Номинал 
        private int count;//Количество 
        private int totalMoney;

        public Money(int denomination, int count)
        {
            this.denomination = denomination;
            this.count = count;
            this.totalMoney = denomination * count;
        }

        public void Show()
        {
            Console.WriteLine("Номинал: {0}, Количество: {1}",denomination, count);
        }

        public bool IsEnough(int productPrice)
        {
            if (totalMoney > productPrice)
            {
                Console.WriteLine("У вас достаточно денег!");
                return true;
            }
            else
            {
                Console.WriteLine("У вас не достаточно денег!");
                return false;
            }
        }

        public int GetNumberOfPieces(int productPrice) 
        {
            if (productPrice != 0)
            {
                return totalMoney / productPrice;
            }
            else
            {
                Console.WriteLine("Не правильная цена продукта!");
                return 0;
            }
        }

        public int Denomination
        {
            get { return this.denomination; }
            set { this.denomination = value; }
        }

        public int Count
        {
            get { return this.count; }
            set { this.count = value; }
        }

        public int TotalMoney
        {
            get { return this.totalMoney; }
        }
    }
}
