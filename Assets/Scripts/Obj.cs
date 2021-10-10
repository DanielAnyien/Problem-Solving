using UnityEngine;

public class Obj : MonoBehaviour
{
    public BoxCollider2D boxcol;
    public GameObject square;

    public int scorevalue = 1;

    void Start()
    {
        boxcol = GetComponent<BoxCollider2D>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(square);
        ScoreManager.score += scorevalue;
    }
}
