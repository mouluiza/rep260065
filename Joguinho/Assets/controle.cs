using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controle : MonoBehaviour
{
    public float velocidade = 1;
    Vector3 direção;
    public Material[] Cores;
    Vector3 posição;

    
    // cor 1 = verde
    // cor 2 = vermelho
    // cor 3 = rosa

    float tempo = 0;
    public float tempolimite = 3f;

    // Start is called before the first frame update
    void Start()
    {
        posição = new Vector3(11, 3, 1);
    }

    // Update is called once per frame
    void Update()
    {
        tempo += Time.deltaTime;
        direção = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        transform.Translate(direção * velocidade * Time.deltaTime);

       

        if (tempo > tempolimite)
        {
            this.gameObject.GetComponent<Renderer>().material = Cores[2];
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<vermelho>() != null)
        {
            this.gameObject.transform.position = posição;
        }
        else if (other.GetComponent<verde>() != null)
      {
            this.gameObject.GetComponent<Renderer>().material = Cores[1];
            tempo = 0;
                   
        }
    }
}