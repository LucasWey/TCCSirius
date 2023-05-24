using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePersonagem : MonoBehaviour
{
    private float velocidade;
    private Vector2 direcao;

    // Start is called before the first frame update
    void Start()
    {
        velocidade = 10;
        direcao = Vector2.zero;

    }

    // Update is called once per frame
    void Update()
    {
        InputPersonagem();
        transform.Translate(direcao * velocidade * Time.deltaTime);
    }

    void InputPersonagem()
    {
        direcao = Vector2.zero;

        if (Input.GetKey(KeyCode.Space))
        {
            direcao += Vector2.up;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            direcao += Vector2.down;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direcao += Vector2.left;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            direcao += Vector2.right;
        }
    }
}