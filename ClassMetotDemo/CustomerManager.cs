using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Ekle (Customer customer) 
        {
            Console.WriteLine("Müşteri Eklendi. : " + customer.NameSurname + " | " + "İşleminize Devam Edebilirsiniz.");
        }

        public void Ekle2 (Customer customer) 
        {
            Console.WriteLine("Müşteri Silindi. : " + customer.NameSurname + " | " + "Çıkış");
        }
    }
}
