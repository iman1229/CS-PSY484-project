using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideSelector : MonoBehaviour
{
    public List<Launcher> Left;
    public List<Launcher> Right;
    public Launcher Both;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(HealthBehavior.health > 0 && ScoreBehavior.score < 50)
        {
            if (UISelection.testStart)
            {
                if (UISelection.selection == "Left")
                {
                    int output = Random.Range(0, 1000);
                    switch (output)
                    {
                        case 0:
                            {
                                Left[0].LaunchGood();
                                break;
                            }
                        case 1:
                            {
                                Left[1].LaunchGood();
                                break;
                            }
                        case 3:
                            {
                                Both.LaunchGood();
                                break;
                            }
                        case 4:
                            {
                                Left[0].LaunchGood();
                                break;
                            }
                        case 5:
                            {
                                Left[1].LaunchGood();
                                break;
                            }
                        case 6:
                            {
                                Both.LaunchGood();
                                break;
                            }
                        case 7:
                            {
                                Left[0].LaunchBad();
                                break;
                            }
                        case 8:
                            {
                                Left[1].LaunchBad();
                                break;
                            }
                        case 9:
                            {
                                Both.LaunchBad();
                                break;
                            }
                        case 10:
                            {
                                Right[0].LaunchGood();
                                break;
                            }
                        case 11:
                            {
                                Right[0].LaunchBad();
                                break;
                            }
                        case 12:
                            {
                                Right[1].LaunchGood();
                                break;
                            }
                        case 13:
                            {
                                Right[1].LaunchBad();
                                break;
                            }
                    }
                }
                else
                {
                    int rand = Random.Range(0, 1000);
                    switch (rand)
                    {
                        case 0:
                            {
                                Right[0].LaunchGood();
                                break;
                            }
                        case 1:
                            {
                                Right[1].LaunchGood();
                                break;
                            }
                        case 3:
                            {
                                Both.LaunchGood();
                                break;
                            }
                        case 4:
                            {
                                Right[0].LaunchGood();
                                break;
                            }
                        case 5:
                            {
                                Right[1].LaunchGood();
                                break;
                            }
                        case 6:
                            {
                                Both.LaunchGood();
                                break;
                            }
                        case 7:
                            {
                                Right[0].LaunchBad();
                                break;
                            }
                        case 8:
                            {
                                Right[1].LaunchBad();
                                break;
                            }
                        case 9:
                            {
                                Both.LaunchBad();
                                break;
                            }
                        case 10:
                            {
                                Left[0].LaunchGood();
                                break;
                            }
                        case 11:
                            {
                                Left[0].LaunchBad();
                                break;
                            }
                        case 12:
                            {
                                Left[1].LaunchGood();
                                break;
                            }
                        case 13:
                            {
                                Left[1].LaunchBad();
                                break;
                            }
                    }
                }
                
            }
        }
        
    }

    public static void SetSide(string tag)
    {
       
        

    }
}
