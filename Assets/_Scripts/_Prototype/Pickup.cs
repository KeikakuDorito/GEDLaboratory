using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pickup : MonoBehaviour
{
    public abstract GameObject Spawn();
    public abstract Pickup Clone();
}


public class Coin : Pickup
{
    private int score;
    private GameObject clone;
    public Coin(GameObject clone, int score)
    {
        this.clone = clone;
        this.score = score;
    }

    
    public override GameObject Spawn()
    {
        if (!clone.GetComponent<Collectable>())
        {
            clone.AddComponent<Collectable>();
        }

        clone.GetComponent<Collectable>().score = score;

        return clone;
    }

    public override Pickup Clone()
    {
        return new Coin(Instantiate(clone), score);
    }
}

public class BlueGem : Pickup
{
    private int score;
    private GameObject clone;
    public BlueGem(GameObject clone, int score)
    {
        this.clone = clone;
        this.score = score;
    }


    public override GameObject Spawn()
    {
        if (!clone.GetComponent<Collectable>())
        {
            clone.AddComponent<Collectable>();
        }

        clone.GetComponent<Collectable>().score = score;

        return clone;
    }

    public override Pickup Clone()
    {
        return new BlueGem(Instantiate(clone), score);
    }
}

public class GreenGem : Pickup
{
    private int score;
    private GameObject clone;
    public GreenGem(GameObject clone, int score)
    {
        this.clone = clone;
        this.score = score;
    }


    public override GameObject Spawn()
    {
        if (!clone.GetComponent<Collectable>())
        {
            clone.AddComponent<Collectable>();
        }

        clone.GetComponent<Collectable>().score = score;

        return clone;
    }

    public override Pickup Clone()
    {
        return new GreenGem(Instantiate(clone), score);
    }
}

public class PinkGem : Pickup
{
    private int score;
    private GameObject clone;
    public PinkGem(GameObject clone, int score)
    {
        this.clone = clone;
        this.score = score;
    }


    public override GameObject Spawn()
    {
        if (!clone.GetComponent<Collectable>())
        {
            clone.AddComponent<Collectable>();
        }

        clone.GetComponent<Collectable>().score = score;

        return clone;
    }

    public override Pickup Clone()
    {
        return new PinkGem(Instantiate(clone), score);
    }
}