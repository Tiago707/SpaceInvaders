using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInvaders : MonoBehaviour
{

    [SerializeField]
    GameObject[] invasores;

    [SerializeField]
    GameObject[] invasoresIndestrutiveis;

    [SerializeField]
    int nInvasores = 7;

    [SerializeField]
    float xMin = -3f;

    [SerializeField]
    float yMin = -0.5f;

    [SerializeField]
    float xInc = 1f;

    [SerializeField]
    float yInc = 0.5f;

    [SerializeField]
    int VidaTank = 10;

    [SerializeField]
    float Tempo = 0f;

    [SerializeField]
    float TempoParaAndar = 0.5f;

    [SerializeField]
    float Velocidade = 0.05f;

    [SerializeField]
    float Descida = -0.5f;

    [SerializeField]
    int Movimentos = 0;

    [SerializeField]
    float probabilidadeDeIndestrutivel = 0.15f;

    void Awake()
    {
        /*
         * "Pega" neste objecto, duplica e coloca-o "naquele" sítio
         */

        float y = yMin;
        for(int line = 0; line < invasores.Length; line++)
        {
            float x = xMin;
            for (int i = 1; i <= nInvasores; i++)
            {
                if(Random.value <= probabilidadeDeIndestrutivel)
                {
                    GameObject newInvader = Instantiate(invasoresIndestrutiveis[line], transform);
                    newInvader.transform.position = new Vector3(x, y, 0f);
                } else
                {
                    GameObject newInvader = Instantiate(invasores[line], transform);
                    newInvader.transform.position = new Vector3(x, y, 0f);
                }
                x += xInc;
            }
            y += yInc;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (tag == "Destrutivel")
        {
            if (collision.gameObject.tag == "ProjectilAmigo")
            {
                Destroy(gameObject);
                Destroy(collision.gameObject);
            }
        }

        if (tag == "Indestrutivel")
        {
            if (collision.gameObject.tag == "ProjectilAmigo")
            {
                Destroy(collision.gameObject);
                VidaTank = VidaTank - 1;
            }
            if (collision.gameObject.tag == "ProjectilAmigo")
            {
                if (VidaTank <= 0)
                {
                    Destroy(gameObject);
                    Destroy(collision.gameObject);
                }
            }
        }
    }
    void Update ()
    {
        Tempo += Time.deltaTime;
        if (Tempo > TempoParaAndar && Movimentos <5) 
        {
            transform.Translate(new Vector3(Velocidade, 0, 0));
            Tempo = 0;
            Movimentos++;
        }

        if(Movimentos == 5)
        {
            transform.Translate(new Vector3(0, Descida , 0));
            Movimentos = -1;
            Velocidade = -Velocidade;
            Tempo = 0;

        }

    }
}
       