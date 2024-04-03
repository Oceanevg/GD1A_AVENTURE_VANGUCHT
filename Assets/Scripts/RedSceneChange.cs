using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedSceneChange : MonoBehaviour
{
    public string SceneName;
    public bool CheckRedKey;
    public PlayerMovement Key;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Key = GameObject.FindObjectOfType<PlayerMovement>();
            CheckRedKey = Key.HasRedKey;

            if (CheckRedKey == true)
            {
                SceneManager.LoadScene(SceneName, LoadSceneMode.Single);
            }
        }
    }
}
