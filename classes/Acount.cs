using System;

class Acount
{
    private Customer _costomer;

    public Acount(Customer customer)
    {
        Console.WriteLine("An acount created");
        this._costomer = customer;
    }

    public bool isBelongTo(Customer customer)
    {
        return this._costomer == customer;
    }
}
