using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraScript : MonoBehaviour
{
    public GameObject [] Objetos;
    public int indice = 0;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i > Objetos.Length; i++)
        {
            Objetos[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Objetos[indice].SetActive(false);
            indice++;
                if (indice == Objetos.Length)
            {
                indice = 0;
            }
            Objetos[indice].SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Objetos[indice].SetActive(false);
            indice--;
            if (indice == -1)
            {
                indice = Objetos.Length - 1;
            }
            Objetos[indice].SetActive(true);
        }
    }
}
