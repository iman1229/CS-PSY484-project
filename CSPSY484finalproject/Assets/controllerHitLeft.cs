using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controllerHitLeft : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains("SquareTarget"))
        {
            ScoreBehavior.UpdateScore(500);
        }
        else if(collision.gameObject.name == "right")
        {
            UISelection.OnRightSelected();
        }
        else if(collision.gameObject.name == "left")
        {
            UISelection.OnLeftSelected();
        }
        else
        {
            ScoreBehavior.UpdateScore(-250);
        }
    }
}
