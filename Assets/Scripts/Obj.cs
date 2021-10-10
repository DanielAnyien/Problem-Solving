using UnityEngine;
using System.Collections;

public class Obj : MonoBehaviour
{
    public int scorevalue = 1;
    [SerializeField] private bool _isrespawn;

    protected virtual void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Ball"))
        {
            if (!_isrespawn)
                GameManager.Instance.AddScore(scorevalue);
            else
                GameManager.Instance.AddScore(scorevalue, this.gameObject);
            
            gameObject.SetActive(false);
        }
    }
}
