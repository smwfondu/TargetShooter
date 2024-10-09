using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private int timer = 0;

    private void Update()
    {
        timer++;

        if(timer > 800)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("YellowTarget"))
        {
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("GreenTarget"))
        {
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("RedTarget"))
        {
            Destroy(gameObject);
        }
    }
}
