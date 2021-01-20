using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add (Customer customer) 
        {
            Console.WriteLine("Müşteri Eklendi. : " + customer.NameSurname + " | " + "İşleminize Devam Edebilirsiniz.");
        }

        public void Add2 (Customer customer) 
        {
            Console.WriteLine("Müşteri Silindi. : " + customer.NameSurname + " | " + "Çıkış");
        }
    }
}
