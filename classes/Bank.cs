using System;

class Bank
{
    private Acount[] _acounts = new Acount[200];
    private Customer[] _customers = new Customer[200];
    private Employe[] _employes = new Employe[200];
    private ATM[] _atms = new ATM[200];

    private int _acountsCounter = 0;
    private int _customersCounter = 0;
    private int _employesCounter = 0;
    private int _atmsCounter = 0;

    public Bank()
    {
        Console.WriteLine("A bank created");
    }

    public void addCustomer(Customer customer)
    {
        for(int i = 0; i < _customersCounter; i++)
        {
            if(customer == _customers[i])
            {
                Console.WriteLine("This customer already existed");
                return;
            }
        }

        _customers[_customersCounter++] = customer;
        Console.WriteLine("Customer added");
    }

    public void addEmploye()
    {
        _employes[_employesCounter++] = new Employe();
        Console.WriteLine("Employe added");
    }

    public void addAtm()
    {
        _atms[_atmsCounter++] = new Atm();
        Console.WriteLine("ATM added");
    }

    private void addAcount(Customer customer)
    {
        for(int i = 0; i < _acountsCounter; i++)
        {
            if(_acounts[i].isBelongTo(customer))
            {
                Console.WriteLine("This acount already existed");
                return;
            }
        }

        _acounts[_acountsCounter++] = new Acount(customer);
        Console.WriteLine("Acount added");
    }

    public void createAcount(Customer customer)
    {
        this.addCustomer(customer);
        this.addAcount(customer);
    }
}
