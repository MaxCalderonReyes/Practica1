using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour
{    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousepos=Camera.main.ScreenToWorldPoint(Input.mousePosition);
      
        transform.position=mousepos;
    }
}
