using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer1 = new Customer();
            customer1.NameSurname = "Zehra Nur Koyuncu";
            customer1.CustomerNo = 200001;
            customer1.Iban = "TR00 0000 000 123";
            customer1.Explanation = "Checking Account";

            Customer customer2 = new Customer();
            customer2.NameSurname = "Rukiye İsen";
            customer2.CustomerNo = 100002;
            customer2.Iban = "TR00 0000 000 321";
            customer2.Explanation = "Deposit Account";

            Customer[] customers = new Customer[] { customer1, customer2 };

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.NameSurname);
                Console.WriteLine(customer.CustomerNo);
                Console.WriteLine(customer.Explanation);
                Console.WriteLine("----------------------------");
            }

            CustomerManager customerManager = new CustomerManager();

            customerManager.Ekle(customer1);
            customerManager.Ekle(customer2);

            customerManager.Ekle2(customer1);
            customerManager.Ekle2(customer2);


        }
    }
}
