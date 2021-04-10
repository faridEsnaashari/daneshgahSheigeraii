using System;

class MovableLaser: Movable, ILaser
{
    private string _color;

    public string color
    {
        get { return _color; }
        set { _color = value; }
    }
}
