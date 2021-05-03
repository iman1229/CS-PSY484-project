using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISelection : MonoBehaviour
{
    public static string selection;
    public static bool testStart;
    public static Canvas input;

    // Start is called before the first frame update
    void Start()
    {
   
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
        input.enabled = false;
    }

    public static void OnRightSelected()
    {
        selection = "Right";
        SideSelector.SetSide(selection);
        testStart = true;
        input.enabled = false;
    }
}
