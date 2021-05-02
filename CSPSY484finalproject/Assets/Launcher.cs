using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody goodProjectile;
    public Rigidbody badProjectile;
    public float speed = 4;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int launch = Random.Range(0, 1000);
        if (launch == 1 || launch == 2 || launch == 4)
        {
            Rigidbody p = Instantiate(goodProjectile, transform.position, transform.rotation);
            p.velocity = transform.forward * speed;
        }
        else if(launch == 3)
        {
            Rigidbody p = Instantiate(badProjectile, transform.position, transform.rotation);
            p.velocity = transform.forward * speed;
        }
    }
}
