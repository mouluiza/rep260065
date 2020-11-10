using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controle : MonoBehaviour
{
    public float velocidade = 1;
    Vector3 direção;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        direção = new Vector3( Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        transform.Translate(direção * velocidade * Time.deltaTime);
        

    }
}
