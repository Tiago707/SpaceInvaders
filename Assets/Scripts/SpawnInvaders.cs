using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInvaders : MonoBehaviour
{

    [SerializeField]
    GameObject[] invasores;

    [SerializeField]
    GameObject invasorC;

    [SerializeField]
    int nInvasores = 7;

    [SerializeField]
    float xMin = -3f;
<<<<<<< HEAD
    
=======

    [SerializeField]
    float yMin = -0.5f;

    [SerializeField]
    float xInc = 1f;

    [SerializeField]
    float yInc = 0.5f;


>>>>>>> 7829f3c565d27d4638c5139fca83f254c766fc56
    void Awake()
    {
        /*
         * "Pega" neste objecto, duplica e coloca-o "naquele" sítio
         */

<<<<<<< HEAD
        float x = xMin;
        for (int i = 1; i <= nInvasores; i++)
        {
            GameObject newInvaderA = Instantiate(invasorA, transform);
            newInvaderA.transform.position = new Vector3(x, -0.5f, 0f);
            x += 1f;
        }

        x = xMin;
        for (int i = 1; i <= nInvasores; i++)
        {
             GameObject newInvaderA2 = Instantiate(invasorA, transform);
             newInvaderA2.transform.position = new Vector3(x, 0f, 0f);
             x += 1f;
        }

        x = xMin;
        for (int i = 1; i <= nInvasores; i++)
        {
            GameObject newInvaderB = Instantiate(invasorB, transform);
            newInvaderB.transform.position = new Vector3(x, 0.5f, 0f);
            x += 1f;
        }

        x = xMin;
        for (int i = 1; i <= nInvasores; i++)
        {
            GameObject newInvaderB2 = Instantiate(invasorB, transform);
            newInvaderB2.transform.position = new Vector3(x, 1f, 0f);
            x += 1f;

        }
        
        x = xMin;
        for (int i = 1; i <= nInvasores; i++)
        {
            GameObject newInvaderC = Instantiate(invasorC, transform);
            newInvaderC.transform.position = new Vector3(x, 1.5f, 0f);
            x += 1f;
=======
        float y = yMin;
        for(int line = 0; line < invasores.Length; line++)
        {
            float x = xMin;
            for (int i = 1; i <= nInvasores; i++)
            {
                GameObject newInvader = Instantiate(invasores[line], transform);
                newInvader.transform.position = new Vector3(x, y, 0f);
                x += xInc;
            }
            y += yInc;
>>>>>>> 7829f3c565d27d4638c5139fca83f254c766fc56
        }
    }
    
}
