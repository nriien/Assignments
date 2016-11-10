using UnityEngine;
using System.Collections;

public class Functions : MonoBehaviour
{

    int Flies;

    void FliesGather()
    {
        Input.GetKeyDown(KeyCode.UpArrow);
        Flies++;
        print("There are now" + Flies + "Flies.");
    }

    void Update()
    {
        FliesGather();
    }
}
