using System.Collections.Generic;
using UnityEngine;

public class Band : MonoBehaviour, IComponent
{
    private List<GameObject> band = new List<GameObject>();

    public void Add (GameObject gameObject)
    {
        band.Add(gameObject);
    }

    public void Create()
    {
        Spawner.Instance.SpawnBand(this);
    }

    public List<GameObject> GetBand()
    {
        return band;
    }
}
