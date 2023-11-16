using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundTile : MonoBehaviour
{
    public GameObject[] dots;

    void Start()
    {
        Setup();
    }

    void Update()
    {
        
    }

    void Setup()
    {
        int dotIndex = Random.Range(0, dots.Length);
        GameObject dot = Instantiate(dots[dotIndex], transform.position, Quaternion.identity, transform);
        dot.name = transform.name.Replace("Tile", "Dot");
    }
}
