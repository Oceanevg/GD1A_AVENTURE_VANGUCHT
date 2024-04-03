using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public string SceneName;
    public bool CheckYellowKey;
    public PlayerMovement Key;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Key = GameObject.FindObjectOfType<PlayerMovement>();
            CheckYellowKey = Key.HasYellowKey;

            if (CheckYellowKey == true)
            {
                SceneManager.LoadScene(SceneName, LoadSceneMode.Single);
            }
        }
    }
}
