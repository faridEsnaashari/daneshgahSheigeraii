using System;

namespace gameExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();

            Console.WriteLine("\n\n######### ADDING CUSTOMERS #########");
            Customer customer1 = new Customer();
            Customer customer2 = new Customer();
            Customer customer3 = new Customer();
            Customer customer4 = new Customer();
            Customer customer5 = new Customer();

            bank.addCustomer(customer1);
            bank.addCustomer(customer2);
            bank.addCustomer(customer2);
            bank.addCustomer(customer3);


            Console.WriteLine("\n\n######### CREATING ACOUNTS #########");
            bank.createAcount(customer1);
            bank.createAcount(customer2);
            bank.createAcount(customer3);
            bank.createAcount(customer1);
            bank.createAcount(customer5);


            Console.WriteLine("\n\n######### ADDING EMPLOYES #########");
            Employe employe1 = new Employe();
            Employe employe2 = new Employe();
            Employe employe3 = new Employe();

            bank.addEmploye(employe1);
            bank.addEmploye(employe2);
            bank.addEmploye(employe1);
            bank.addEmploye(employe3);


            Console.WriteLine("\n\n######### ADDING ATMS #########");
            ATM atm1 = new ATM();
            ATM atm2 = new ATM();
            ATM atm3 = new ATM();

            bank.addAtm(atm1);
            bank.addAtm(atm2);
            bank.addAtm(atm3);
            bank.addAtm(atm3);
        }

    }
}
