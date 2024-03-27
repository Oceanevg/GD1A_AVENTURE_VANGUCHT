using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] element;

    void Awake ()
    {
        foreach(var item in element)
        {
            DontDestroyOnLoad(item);
        }
    }
}
