using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonIzquierda : MonoBehaviour
{

    public Rigidbody2D personaje;
    public int fuerzaMovimiento = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
    }



    void OnMouseDown()
    {
        MoverIzquierda();
    }

    void OnMouseUp()
    {
        Frenar();
    }

    void Frenar()
    {
        personaje.velocity = Vector2.zero;
    }



    void MoverIzquierda()
    {
        personaje.AddForce(Vector2.left * fuerzaMovimiento, ForceMode2D.Impulse);
    }
}
