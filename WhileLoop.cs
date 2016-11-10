using UnityEngine;
using System.Collections;

public class WhileLoop : MonoBehaviour
{
    bool WeeHoursOfTheMorning = true;

    void Start()
    {
        while (WeeHoursOfTheMorning == true)
        {
            print("It's not time to get up yet.");
        }
    }
	
}
