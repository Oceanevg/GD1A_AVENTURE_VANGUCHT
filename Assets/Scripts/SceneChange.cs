using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public string SceneName;
    public bool CheckKey;
    public PlayerMovement Key;


    public void Awake()
    {
        Key = GameObject.FindObjectOfType<PlayerMovement>();
        CheckKey = Key.HasKey;
    }
    public void AllerAuNiveau()
    {
        SceneManager.LoadScene(SceneName, LoadSceneMode.Single);
    }

    private void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.CompareTag ("Player") && CheckKey == true)
        {
            AllerAuNiveau();
        }
        
    }
}
