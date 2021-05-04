using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBehavior : MonoBehaviour
{

    
    private Text healthText;
    public static int health;
    // Start is called before the first frame update
    void Start()
    {
        healthText = GetComponent<Text>();

        health = 10;


    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + health;
    }

    public static void UpdateHealth()
    {
        health--;
    }
}
