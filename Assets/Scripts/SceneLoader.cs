using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private Button _prob1;
    [SerializeField] private Button _prob2;
    [SerializeField] private Button _prob3;
    [SerializeField] private Button _prob4;
    [SerializeField] private Button _prob5;
    [SerializeField] private Button _prob6;
    [SerializeField] private Button _prob7;
    [SerializeField] private Button _prob8;
    [SerializeField] private Button _prob9;

    private void Start ()
    {
        _prob1.onClick.AddListener (() =>
        {
            SetButtonInteractable (false);
            SceneManager.LoadScene (1);
        });

        _prob2.onClick.AddListener (() =>
        {
            SetButtonInteractable (false);
            SceneManager.LoadScene (2);
        });

        _prob3.onClick.AddListener (() =>
        {
            SetButtonInteractable (false);
            SceneManager.LoadScene (3);
        });

        _prob4.onClick.AddListener (() =>
        {
            SetButtonInteractable (false);
            SceneManager.LoadScene (4);
        });

        _prob5.onClick.AddListener (() =>
        {
            SetButtonInteractable (false);
            SceneManager.LoadScene (5);
        });

        _prob6.onClick.AddListener (() =>
        {
            SetButtonInteractable (false);
            SceneManager.LoadScene (6);
        });

        _prob7.onClick.AddListener (() =>
        {
            SetButtonInteractable (false);
            SceneManager.LoadScene (7);
        });

        _prob8.onClick.AddListener (() =>
        {
            SetButtonInteractable (false);
            SceneManager.LoadScene (8);
        });

        _prob9.onClick.AddListener (() =>
        {
            SetButtonInteractable (false);
            SceneManager.LoadScene (9);
        });
    }

    private void SetButtonInteractable (bool interactable)
    {
        _prob1.interactable = interactable;
        _prob2.interactable = interactable;
        _prob3.interactable = interactable;
        _prob4.interactable = interactable;
        _prob5.interactable = interactable;
        _prob6.interactable = interactable;
        _prob7.interactable = interactable;
        _prob8.interactable = interactable;
        _prob9.interactable = interactable;
    }
}
