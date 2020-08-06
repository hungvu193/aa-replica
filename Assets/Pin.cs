using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    public bool isPin = false;
    public float pinSpeed = 20f;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!isPin)
            rb.MovePosition(rb.position + Vector2.up * pinSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Rotator")
        {
            // transform follows parents
            transform.SetParent(collision.transform);
            isPin = true;
        } else if(collision.tag == "Pin")
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
