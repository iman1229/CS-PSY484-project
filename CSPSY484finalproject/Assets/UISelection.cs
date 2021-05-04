using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISelection : MonoBehaviour
{
    public static string selection;
    public static bool testStart;
    public static Canvas input;
    public Button left;
    public Button right;

    // Start is called before the first frame update
    void Start()
    {
        input = GameObject.FindObjectOfType<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public static void OnLeftSelected()
    {
        selection = "Left";
        SideSelector.SetSide(selection);
        testStart = true;
        input.gameObject.SetActive(false);
    }

    public static void OnRightSelected()
    {
        selection = "Right";
        SideSelector.SetSide(selection);
        testStart = true;
        input.gameObject.SetActive(false);
    }

    
    
}
