using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipe : MonoBehaviour
{
    [SerializeField] float speed;
    static public float addSpeed = 1f;
    
    private void Update()
    {
        if (GameManager.playerAlive == true)
        {
            transform.Translate(Time.deltaTime * -speed * addSpeed, 0, 0);
            if (transform.position.x <= -10f)
            {
                Destroy(gameObject);
            }
        }
        
    }
    
}
