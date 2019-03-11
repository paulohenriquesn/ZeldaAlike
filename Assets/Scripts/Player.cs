using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class  Player : MonoBehaviour {
 
    // Start is called before the first frame update
    public float speed;
    Animator Anim;
    public Image[] hearts;
    public int MaxHealth;
    int CurrentHealth;

    void Start()
    { 
        Anim = GetComponent<Animator>();
        CurrentHealth = MaxHealth;
        GetHealth();
    }
    void GetHealth() {
        for(int i= 0; i <= hearts.Length -1; i++)
        {
      hearts[i].gameObject.SetActive(false);
        }
        for(int i = 0; i <= CurrentHealth -1; i++) {
            hearts[i].gameObject.SetActive(true);
        }

    }

    // Update is called once per frame
    void Update()
    {
        Movement(); 
        if(Input.GetKeyDown(KeyCode.P))
        CurrentHealth--;
        GetHealth();
        if (Input.GetKeyDown(KeyCode.L))
        CurrentHealth++;
        if(CurrentHealth > MaxHealth)
        CurrentHealth = MaxHealth;
    }
    void Movement() {
     
    if(Input.GetKey(KeyCode.W))
    { transform.Translate(0,speed*Time.deltaTime,0); 
    Anim.SetInteger("dir", 0);
    }
      else if(Input.GetKey(KeyCode.S))
    {
        transform.Translate(0,-speed*Time.deltaTime,0);
        Anim.SetInteger("dir", 1);
        }
     else if (Input.GetKey(KeyCode.A))
     {
         transform.Translate(-speed*Time.deltaTime,0,0);
         Anim.SetInteger("dir", 2);
         
         }
     else if(Input.GetKey(KeyCode.D))
     {
            transform.Translate(speed*Time.deltaTime,0,0);
            Anim.SetInteger("dir", 3);
         }
    }
}
