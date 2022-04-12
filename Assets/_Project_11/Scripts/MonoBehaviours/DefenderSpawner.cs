using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    public List<Character> characters = new List<Character>();

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Spawn(0);
        }
    }

    public void Spawn(int id)
    {
        Instantiate(characters[id], transform.position, transform.rotation);
    }
}