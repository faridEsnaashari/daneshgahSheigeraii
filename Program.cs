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
            bank.addEmploye();
            bank.addEmploye();
            bank.addEmploye();
            bank.addEmploye();


            Console.WriteLine("\n\n######### ADDING ATMS #########");
            bank.addAtm();
            bank.addAtm();
            bank.addAtm();
            bank.addAtm();


            Console.WriteLine("\n\n######### ADDING NEOBranches #########");
            bank.addNeoBranch();
            bank.addNeoBranch();
            bank.addNeoBranch();
            bank.addNeoBranch();


            Console.WriteLine("\n\n######### ADDING InternalBranches #########");
            bank.addInternalBranch();
            bank.addInternalBranch();
            bank.addInternalBranch();
            bank.addInternalBranch();
        }

    }
}
