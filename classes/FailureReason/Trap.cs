using System;

class Trap: UnMovable
{
    private string _trapType;

    public string trapType
    {
        get { return _trapType; }
        set { _trapType = value; }
    }
}
