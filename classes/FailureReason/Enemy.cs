using System;

class Enemy: Movable
{
    public int _health;

    public int health
    {
        get { return _health; }
    }

    public void decreaseHealth()
    {
        _health -= 1;
    }
}
