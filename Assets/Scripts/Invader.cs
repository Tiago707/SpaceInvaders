using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invader : MonoBehaviour
{
    [SerializeField]
    GameObject fire;

    [SerializeField]
    float cadencia = 50f;

    [SerializeField]
    int VidaTanks = 10;

    float tempoQuePassou = 0f;
   
    void Update()
    {
        if(tag == "Destrutivel")
        {
            tempoQuePassou += Time.deltaTime;
            if (tempoQuePassou >= cadencia)
            {
                Instantiate(fire, transform.position, transform.rotation);
                tempoQuePassou = Random.Range(0f, 3f);
            }
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
                VidaTanks = VidaTanks - 1;
            }
            if (collision.gameObject.tag == "ProjectilAmigo")
            {
                if (VidaTanks <= 0)
                {
                    Destroy(gameObject);
                    Destroy(collision.gameObject);
                }
            }
        }
    }
}