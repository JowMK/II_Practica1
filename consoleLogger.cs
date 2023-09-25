using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class consoleLogger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() {
        Debug.Log("Hi, im " + gameObject.tag);
    }

    // Update is called once per frame
    void Update() {
        
    }
}
