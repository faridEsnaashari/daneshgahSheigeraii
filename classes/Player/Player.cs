using System;

class Player: IPlayerAssets
{
    private string _name;
    private string _gender;
    private int _health = 100;

    private int _coin;
    private string _weapon;

    public string name
    {
        set { _name = value; }
        get { return _name; }
    }

    public string gender
    {
        set { _gender = value; }
        get { return _gender; }
    }

    public int health
    {
        get { return _health; }
    }

    public string weapon
    {
        set { _weapon = value; }
        get { return _weapon; }
    }

    public int coin
    {
        set { _coin = value; }
        get { return _coin; }
    }

    public void resetHealth()
    {
        _health = 100;
    }

    public void getDamage(int damage)
    {
        _health -= damage;
    }

    public void move()
    {
        Console.WriteLine("player moved");
    }

    public void jump()
    {
        Console.WriteLine("player jumped");
    }
}

