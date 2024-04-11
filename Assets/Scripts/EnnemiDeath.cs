using UnityEngine;

public class EnnemiDeath : MonoBehaviour
{
    public GameObject objectToDestroy;

    private void Awake()
    {
        objectToDestroy = GameObject.FindWithTag("Ennemi");
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Look"))
        {
            Destroy(gameObject);
        }
    }
}