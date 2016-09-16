using UnityEngine;
using System.Collections;

public class Variables : MonoBehaviour {

    int MyInt = 22;

	void Start () {
        MyInt = MultiplyByTwo(MyInt);
        Debug.Log(MyInt);
	}

    int MultiplyByTwo(int number)
    {
        int ret;
        ret = MyInt * 2;
        return ret;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
