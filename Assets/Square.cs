using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    
    [SerializeField] float jumpPower;
    [SerializeField] GameObject gameOver;
    private void Update()
    {
        if (GameManager.playerAlive == true)
        {
            if (Input.GetMouseButton(0))
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumpPower);
            }
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Pipe"|| collision.gameObject.tag == "Ground")
        {
            GameManager.playerAlive = false;
            gameOver.SetActive(true);
            
        }
    }


}
