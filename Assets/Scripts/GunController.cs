using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public Transform start;
    public GameObject bullet;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject newBullet = Instantiate(bullet, start.position, Quaternion.Euler(start.position));
            //Debug.Log(start.transform.position);
            //Debug.Log(start.transform.forward);

            newBullet.GetComponent<Rigidbody>().AddForce(start.transform.forward * 50, ForceMode.Impulse);
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
