using System;

abstract class FailureReason
{
    protected string _failureType;
    protected int _damage;

    public abstract string failureType { set; get; }
    public abstract int damage { set; get; }

    public void generate()
    {
        Console.WriteLine("generate");
    }
}

