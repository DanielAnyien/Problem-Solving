using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjSpawn : MonoBehaviour
{
    public GameObject square;
    Vector2 whereToSpawn;

    float x, y;

    void Start()
    {
        int jml = Random.Range (1, 7);
        
        for (int i = 0; i <= jml; i++)
        {
            x = Random.Range(-7.5f, 7.5f);
            y = Random.Range(-4.5f, 4.5f);

            whereToSpawn = new Vector2 (x, y);

            Instantiate (square, whereToSpawn, Quaternion.identity);
        }
    }
}
