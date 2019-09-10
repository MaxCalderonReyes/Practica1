using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dentroCirculo : MonoBehaviour
{
    public float radio;
  Transform objetivo;
    void Start()
    {
        print("HOla");
        objetivo=GameObject.Find("agent").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(objetivo!=null){
 float d=(objetivo.transform.position-transform.position).magnitude;
        if(d<radio){
            
            Debug.Log("Ganaste");
        }
        }
       
    }
    void OnDrawGizmos(){
        Gizmos.color=Color.magenta;
        Gizmos.DrawWireSphere(transform.position,radio);
    }
}
