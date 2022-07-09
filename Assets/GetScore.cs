using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetScore : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag =="Player")
        {
            GameManager.score ++;
            GameManager.addSpeedCount++;
            if (GameManager.addSpeedCount >= 10)
            {
                MovePipe.addSpeed += 0.1f;
                if (MovePipe.addSpeed >= 1.8f)
                {
                    return;
                }
                GameManager.addSpeedCount = 0;
            }
        }
    }
}
