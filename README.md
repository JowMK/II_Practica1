# II_Practica1

Practica inicial de Interfaces Inteligentes

Esta practica consiste en familiarizarse con el editor de Unity así como fundar una base de conocimientos y procedimientos para las practicas subsecuentes.

Aqui se muestra el funcionamiento de el pack Starter Assets, en concreto el de primera persona además de otro asset pack de la Unity Store: [Simple Sky - Cartoon assets](https://assetstore.unity.com/packages/3d/environments/simple-sky-cartoon-assets-42373)

Funcionamiento:

![run.gif](https://github.com/JowMK/II_Practica1/blob/main/run.gif)

Script `ConsoleLogger.cs`:
```cs
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

```
