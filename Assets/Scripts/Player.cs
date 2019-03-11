using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class  Player : MonoBehaviour {
 
    // Start is called before the first frame update
    public float speed;
    Animator anim;

    void Start()
    { 
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement(); 
    }
    void Movement() {
     
    if(Input.GetKey(KeyCode.W))
    { transform.Translate(0,speed*Time.deltaTime,0); 
    anim.setInteger("dir", 0);
    }
      else if(Input.GetKey(KeyCode.S))
    {
        transform.Translate(0,-speed*Time.deltaTime,0);
        anim.setInteger("dir", 1);
        }
     else if (Input.GetKey(KeyCode.A))
     {
         transform.Translate(-speed*Time.deltaTime,0,0);
         anim.setInteger("dir", 2);
         }
     else if(Input.GetKey(KeyCode.D))
     {
            transform.Translate(speed*Time.deltaTime,0,0);
            anim.setInteger("dir", 3);
         }
    }
}
