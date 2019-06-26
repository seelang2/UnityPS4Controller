using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    // Just a test callback
    public void TestCallback(string name, float value)
    {
        Debug.Log("Testcallback: " + name + ":" + value);
    }

    public void TestButtonCallback(string name)
    {
        Debug.Log("Testcallback: " + name + " pressed");
    }

}
