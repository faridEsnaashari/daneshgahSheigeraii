using System;

public interface IPlayerAssets
{
    public abstract int coin { get; }
    public abstract string weapon { get; set; }

    public abstract void increaseCoin();
}

