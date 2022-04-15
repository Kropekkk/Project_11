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
        Instantiate(characters[id], transform.position, transform.rotation);
    }
}