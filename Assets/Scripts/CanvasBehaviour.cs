using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasBehaviour : MonoBehaviour
{

    public GameObject[] imageHearts;

    GameObject Player;

    public void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player"); // Pega o objeto player que estiver com uma tag de Player e retorna na variavel.
    }

    public void GetHealth()
    {
        for (int i = 0; i <= imageHearts.Length - 1; i++)
        {
            imageHearts[i].gameObject.SetActive(false);
        }
        for (int i = 0; i <= Player.GetComponent<Player>().MaxHealth - 1; i++)
        {
            imageHearts[i].gameObject.SetActive(true);
        }

    }
}
