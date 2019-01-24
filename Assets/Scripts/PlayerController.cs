using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    //public Transform posicionBala;
    //public Rigidbody2D bala;

    public int fuerzaMovimiento = 20;
    //public int fuerzaDisparo = 10;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D> (); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
       //Movimiento a la izquierda
       //if(Input.GetKey (KeyCode.A))
       //{
       //    MoverIzquierda();
      // } 

       //Mover a la derecha
      // if(Input.GetKey (KeyCode.D))
       //{
          // MoverDerecha();
      // }

       //Disparo    
       //if(Input.GetKeyDown (KeyCode.Space))
      // {
         //  Disparar();
     //  }
   // }

    //void MoverIzquierda()
   // {
     //   rb.AddForce(Vector2.left * fuerzaMovimiento);
   // }

   // void MoverDerecha()
    //{
       // rb.AddForce(Vector2.right * fuerzaMovimiento);
   // }


   // void Disparar(){
        //Rigidbody2D balaInstanciada = Instantiate(bala, posicionBala.position, posicionBala.rotation);
      //  balaInstanciada.AddForce(Vector2.up * fuerzaDisparo);


    }

}
