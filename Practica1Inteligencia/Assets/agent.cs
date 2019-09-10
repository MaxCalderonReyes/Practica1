using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class agent : MonoBehaviour
{
    Transform camara;
   Transform objetivoradio;
    Vector3 velocidad=Vector3.zero;
   Vector3 desired=Vector3.zero;
   Vector3 steer=Vector3.zero;
  public float max_Speed=4;
  public float max_Steer=1;
   Transform objetivo;
    void Start()
    {
        camara=GameObject.Find("Main Camera").transform;
        objetivoradio=GameObject.Find("sa").transform;
        objetivo=GameObject.Find("target").transform;
    }

    // Update is called once per frame
    void Update()
    {
        float d=(objetivoradio.transform.position-transform.position).magnitude;
      
        if(d<2){
            print("Ganaste");
            Destroy(gameObject);
        }
       desired=-((objetivo.transform.position-transform.position).normalized)*max_Speed;
       steer=Vector3.ClampMagnitude(desired-velocidad,max_Steer);

       velocidad+=steer*Time.deltaTime;
       transform.position+=velocidad*Time.deltaTime;
     if(transform.position.x>5){
         print("PERDISTE");
         Destroy(gameObject);
     }
     if(transform.position.x<5){
         print("PERDISTE");
         Destroy(gameObject);
     }
     if(transform.position.y>7){
         print("PERDISTE");
         Destroy(gameObject);
     }
     if(transform.position.x<7){
         print("PERDISTE");
         Destroy(gameObject);
     }
   //   transform.position= new Vector3 (Mathf.Clamp(transform.position.x,-7,7),Mathf.Clamp(transform.position.y,-5,5),-10);
      
    }
}
