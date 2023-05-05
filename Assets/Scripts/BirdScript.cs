using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    private Rigidbody2D rb;  // Ссылка на компонент

    [SerializeField]
    private TMPro.TextMeshProUGUI Scores;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();  // находим и получаем ссылку на "соседний" компонент объекта
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * 300f);
        }

        //if (Input.GetKeyDown(KeyCode.RightArrow))
        //{
        //    rb.AddForce(Vector2.right * 300f);
        //}

        //if (Input.GetKeyDown(KeyCode.LeftArrow))
        //{
        //    rb.AddForce(Vector2.left * 300f);
        //}

        //if (Input.GetKeyDown(KeyCode.DownArrow))
        //{
        //    rb.AddForce(Vector2.down * 300f);
        //}
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "AddScores")
        {
            int score = FindAnyObjectByType<GameFunctionsScript>().AddScores();

            Scores.text = "Scores: " + score.ToString();
        }
        else
        {
            FindAnyObjectByType<GameFunctionsScript>().GameOver();
        }
    }
}
