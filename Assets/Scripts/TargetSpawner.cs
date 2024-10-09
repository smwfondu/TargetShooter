using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    public GameObject[] differentTargets = null;

    public int offsetValue = 15;
    public int forceValue = 100;

    private int timer = 0;
    private SettingsHolder sh;

    private void Start()
    {
        sh = GameObject.FindGameObjectWithTag("SettingsHolder").GetComponent<SettingsHolder>();
    }

    // Update is called once per frame
    void Update()
    {
        timer++;

        if(timer % sh.GetSpawnTime() == 0)
        {
            int num = Random.Range(0, differentTargets.Length);

            float randomXOffset = Random.Range(-offsetValue, offsetValue);
            float randomYOffset = Random.Range(-8, 2);
            float randomZOffset = Random.Range(-offsetValue, offsetValue);

            Vector3 offset = new Vector3(randomXOffset, randomYOffset, randomZOffset);

            GameObject currentTarget = Instantiate(differentTargets[num], transform.position + offset, Quaternion.identity);

            float randomXForce = Random.Range(-forceValue, forceValue);
            float randomYForce = Random.Range(-forceValue, forceValue);
            float randomZForce = Random.Range(-forceValue, forceValue);

            Vector3 force = new Vector3(randomXForce, randomYForce, randomZForce);

            currentTarget.GetComponent<Rigidbody>().AddForce(force);
            timer = 0;
        }
    }
}
