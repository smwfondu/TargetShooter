using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public int type;
    private int score = 0;

    private int timer = 0;

    private SettingsHolder sh;

    // Start is called before the first frame update
    void Start()
    {
        sh = GameObject.FindGameObjectWithTag("SettingsHolder").GetComponent<SettingsHolder>();

        if (type == 1)
        {
            score = 100;
        }
        else if (type == 2)
        {
            score = 50;
        }
        else if (type == 3)
        {
            score = -300;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Bullet"))
        {
            GameObject.FindGameObjectWithTag("ScoreHolder").gameObject.GetComponent<ScoreManager>().SetCurrentScore(score);
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        timer++;

        if(timer > sh.GetDespawnTime())
        {
            Destroy(gameObject);
        }
    }
}
