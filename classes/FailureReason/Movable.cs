using System;

class Movable: FailureReason
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

    public void repeatedlyMove()
    {
        Console.WriteLine("repeatedly moving");
    }
}

