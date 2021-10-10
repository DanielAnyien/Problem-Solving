using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjSpawn : MonoBehaviour
{
    public GameObject square;
    public int totalSpawn;

    Queue<GameObject> squareQue = new Queue<GameObject>();
    Queue<float> respawnQue = new Queue<float>();

    [SerializeField] private LayerMask unspawnable;

    float currentTime;

    void Start()
    {
        for (int i = 0; i < totalSpawn; i++)
        {
            GameObject box = Instantiate(square);
            box.transform.position = SpawnPos();
        }
    }

    private void Update()
    {
        currentTime += Time.deltaTime;

        if (respawnQue.Count > 0 && currentTime >= respawnQue.Peek())
        {
            respawnQue.Dequeue();

            GameObject respawnObj = squareQue.Dequeue();
            respawnObj.transform.position = SpawnPos();
            respawnObj.gameObject.SetActive(true);
        }
    }

    protected virtual Vector2 SpawnPos()
    {
        Vector2 spawnPoint = new Vector2();
        spawnPoint.x = Random.Range(-7.5f, 7.5f);
        spawnPoint.y = Random.Range(-4.5f, 4.5f);

        if(Physics2D.OverlapBox(spawnPoint, Vector2.one, unspawnable))
            return SpawnPos();

        return spawnPoint;
    }

    public void Respawn(GameObject box)
    {
        string scname = SceneManager.GetActiveScene().name;
        if (scname == "Problem 9")
        {
            squareQue.Enqueue(box);
            respawnQue.Enqueue(currentTime);
        }
        else
        {
            squareQue.Enqueue(box);
            respawnQue.Enqueue(currentTime + 3f);
        }
    }
}