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
        //if(ScoreBehavior.score < 50 && HealthBehavior.health > 0)
        //{
        //    int rand = Random.Range(0, 1000);

        //    if (rand == 1 || rand == 2 || rand == 3)
        //    {
        //        Rigidbody p = Instantiate(goodProjectile, transform.position, transform.rotation);
        //        p.velocity = transform.forward * speed;
        //    }
        //    if (rand == 4)
        //    {
        //        Rigidbody p = Instantiate(badProjectile, transform.position, transform.rotation);
        //        p.velocity = transform.forward * speed;
        //    }
        //}
       
       
    }

    public void LaunchGood()
    {
        Rigidbody p = Instantiate(goodProjectile, transform.position, transform.rotation);
        p.velocity = transform.forward * speed;
    }

    public void LaunchBad()
    {
        Rigidbody p = Instantiate(badProjectile, transform.position, transform.rotation);
        p.velocity = transform.forward * speed;
    }
}
