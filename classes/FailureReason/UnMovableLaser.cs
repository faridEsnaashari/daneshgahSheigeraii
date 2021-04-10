using System;

class UnMovableLaser: UnMovable, ILaser
{
    private string _color;

    public string color
    {
        get { return _color; }
        set { _color = value; }
    }
}
