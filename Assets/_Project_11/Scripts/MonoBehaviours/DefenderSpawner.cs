using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    public List<Character> characters = new List<Character>();

    public static DefenderSpawner instance;


    private void Start()
    {
        instance = this;
    }

    public void Spawn(int id)
    {
        Instantiate(characters[id], new Vector3(transform.position.x, transform.position.y, Random.RandomRange(transform.position.z-3f, transform.position.z+3f)), transform.rotation);
    }
}