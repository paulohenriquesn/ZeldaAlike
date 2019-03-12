using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class  Player : MonoBehaviour {
    
    Vector2 playerPos; //Vector de posições ele armazena posições de floats. [0.0f,1.0f] 
    public GameObject CanvasObject; // Objeto canvas, separado para acessar o script
    public Rigidbody2D playerRb; //Rigidbody2d é um tipo de fisica do jogador,usado para mexer com colisões,posições.

    public float speed; 
    public int MaxHealth;
    public static int CurrentHealth;

    void Start()
    { 
        CurrentHealth = MaxHealth;
        CanvasObject.GetComponent<CanvasBehaviour>().GetHealth(); // Acessa o Objeto Canvas no componente Script, e acessa a função dela.
    }

    private void FixedUpdate()  //Metodo com menos bug porque se atualiza de acordo com os frames.
    {
        Movement();
    }

   
    void Update()
    { 
        if(Input.GetKeyDown(KeyCode.P))
        CurrentHealth--;
        CanvasObject.GetComponent<CanvasBehaviour>().GetHealth();
        if (Input.GetKeyDown(KeyCode.L))
        CurrentHealth++;
        if(CurrentHealth > MaxHealth)
        CurrentHealth = MaxHealth;
    }
    void Movement()
    {
        //Outro Metodo porém mais suave.

        //Cria um vetor de 2 valores de posição com o Axis Horizontal e Vertical que estou explicando ali embaixo.
        /* playerPos = new Vector2(Input.GetAxis("Horizontal") * speed , Input.GetAxis("Vertical") * speed);     
         //Adiciona uma força no Rigidbody para a fisica fazer uma força para o player se movimentar.
        playerRb.AddForce(playerPos * Time.deltaTime);*/

        //Pega os Axis Horizontal,Vertical e verificam se estão sendo utilizados por exemplo um joystick se X está sendo utilizado se sim
        //Ele verifica e retorna a posição de onde está sendo atingido exemplo (PRESSIONO A, RETORNA 1, PRESSIONO D, RETORNA 1) se eu soltar retornam 0.
        this.transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, Input.GetAxis("Vertical") * speed * Time.deltaTime,0);
    }
}
