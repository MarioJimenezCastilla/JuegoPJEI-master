using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonDerecha : MonoBehaviour
{
    public Rigidbody2D personaje;
    public int fuerzaMovimiento = 100;
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
        MoverDerecha();
    }

    void OnMouseUp()
    {
        Frenar();
    }

    void Frenar()
    {
        personaje.velocity = Vector2.zero;
    }

    void MoverDerecha()
    {
        personaje.AddForce(Vector2.right * fuerzaMovimiento, ForceMode2D.Impulse);
    }
}
