using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonDisparo : MonoBehaviour
{
    public Rigidbody2D personaje;

    public Transform posicionBala;
    public Rigidbody2D[] balas;


    public int fuerzaDisparo = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Disparo();
    }

    void Disparo(){
        //Rigidbody2D balaInstanciada = Instantiate (bala, posicionBala.position, posicionBala.rotation);
        //balaInstanciada.AddForce(Vector2.up * fuerzaDisparo);

        int numeroBala = Random.Range(0, balas.Length);
        Rigidbody2D balaInstanciada = Instantiate(balas[numeroBala], posicionBala.position, posicionBala.rotation);
        balaInstanciada.AddForce(Vector2.up * fuerzaDisparo);

    }
}
