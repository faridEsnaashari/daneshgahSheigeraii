using System;

abstract class UnMovable: FailureReason
{
    public override string failureType 
    {
        set { _failureType = value; }
        get { return _failureType; }
    }

    public override int damage 
    {
        set { _damage = value; }
        get { return _damage; }
    }

    public void defuse()
    {
        Console.WriteLine("defused");
    }
}

