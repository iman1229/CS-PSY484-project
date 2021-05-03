using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideSelector : MonoBehaviour
{
    private static List<Launcher> side;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(UISelection.testStart)
        {
            int output = Random.Range(0, 1000);
            switch(output)
            {
                case 0:
                    {
                        side[0].LaunchGood();
                        break;
                    }
                case 1:
                    {
                        side[1].LaunchGood();
                        break;
                    }
                case 3:
                    {
                        if(side.Count >= 3)
                        {
                            side[2].LaunchGood();
                        }
                        break;
                    }
                case 4:
                    {
                        side[0].LaunchGood();
                        break;
                    }
                case 5:
                    {
                        side[1].LaunchGood();
                        break;
                    }
                case 6:
                    {
                        if (side.Count >= 3)
                        {
                            side[2].LaunchGood();
                        }
                        break;
                    }
                case 7:
                    {
                        side[0].LaunchBad();
                        break;
                    }
                case 8:
                    {
                        side[1].LaunchBad();
                        break;
                    }
                case 9:
                    {
                        if (side.Count >= 3)
                        {
                            side[2].LaunchBad();
                        }
                        break;
                    }
            }
        }
    }

    public static void SetSide(string tag)
    {
        GameObject[] sided = GameObject.FindGameObjectsWithTag(tag);
        GameObject[] both = GameObject.FindGameObjectsWithTag("Both");
        both.CopyTo(sided, sided.Length);
        Launcher[] objects = GameObject.FindObjectsOfType<Launcher>();
        foreach(Launcher thing in objects)
        {
            foreach(GameObject tagged in sided)
            {
                if(thing.gameObject.name == tagged.gameObject.name)
                {
                    side.Add(thing);
                }
            }
        }
        

    }
}
