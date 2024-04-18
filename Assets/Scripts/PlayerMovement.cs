using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed;
    public float AttackLenght;

    private float horizontal;
    private float vertical;
    private float AttackCounter;

    public bool HasYellowKey = false;
    public bool HasRedKey = false;
    public bool HasSpear = false;

    public bool isAttacking;
    public GameObject LookUp;
    public GameObject LookRight;
    public GameObject LookLeft;
    public GameObject LookDown;

    //public Vector2 currentLookingPos;

    public GameObject attaqueMelee;



    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector2.right * horizontal * moveSpeed * Time.deltaTime);

        vertical = Input.GetAxisRaw("Vertical");
        transform.Translate(Vector2.up * vertical * moveSpeed * Time.deltaTime);


        if (Input.GetMouseButtonDown(0) && Input.GetKey(KeyCode.UpArrow))
        {

            LookUp.GetComponent<BoxCollider2D>().enabled = true;
            isAttacking = true;
           // currentLookingPos = LookUp.transform.position;
            //GameObject attaque_hitbox = Instantiate(attaqueMelee, currentLookingPos, Quaternion.identity);

        }
        
        if (Input.GetMouseButtonDown(0) && Input.GetKey(KeyCode.DownArrow))
        {

            LookDown.GetComponent<BoxCollider2D>().enabled = true;
            isAttacking = true;
            //currentLookingPos = LookDown.transform.position;
            //GameObject attaque_hitbox = Instantiate(attaqueMelee, currentLookingPos, Quaternion.identity);

        }

        if (Input.GetMouseButtonDown(0) && Input.GetKey(KeyCode.RightArrow))
        {

            LookRight.GetComponent<BoxCollider2D>().enabled = true;
            isAttacking = true;
            //currentLookingPos = LookRight.transform.position;
           // GameObject attaque_hitbox = Instantiate(attaqueMelee, currentLookingPos, Quaternion.identity);

        }

        if (Input.GetMouseButtonDown(0) && Input.GetKey(KeyCode.LeftArrow))
        {

            LookLeft.GetComponent<BoxCollider2D>().enabled = true;
            isAttacking = true;
            //currentLookingPos = LookLeft.transform.position;
            //GameObject attaque_hitbox = Instantiate(attaqueMelee, currentLookingPos, Quaternion.identity);

        }



        if (isAttacking)
        {
            if (AttackCounter <= 0)
            {
                AttackCounter = AttackLenght;
            }
            isAttacking = false;
        }

        if (AttackCounter > 0)
        {
            AttackCounter -= Time.fixedDeltaTime;

            if (AttackCounter < 0)
            {
                LookUp.GetComponent<BoxCollider2D>().enabled = false;
                LookRight.GetComponent<BoxCollider2D>().enabled = false;
                LookDown.GetComponent<BoxCollider2D>().enabled = false;
                LookLeft.GetComponent<BoxCollider2D>().enabled = false;
            }
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ennemi")
        {
            Destroy(gameObject);
        }
    }








    private void Awake()
    {

        LookUp.GetComponent<BoxCollider2D>().enabled = false;
        LookRight.GetComponent<BoxCollider2D>().enabled = false;
        LookDown.GetComponent<BoxCollider2D>().enabled = false;
        LookLeft.GetComponent<BoxCollider2D>().enabled = false;
    }

    public void GetYellowKey()
    {
        HasYellowKey = true;
    }

    public void GetRedKey()
    {
        HasRedKey = true;
    }

   
}
