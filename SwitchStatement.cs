using UnityEngine;
using System.Collections;

public class SwitchStatement : MonoBehaviour
{

    public int PianoKeys;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        PianoKeys = Random.Range(1, 3);
        switch(PianoKeys)
        {
            case 1:
                Debug.Log("Do");
                break;
            case 2:
                Debug.Log("Re");
                break;
            case 3:
                Debug.Log("Mi");
                break;
        }
	}
}
