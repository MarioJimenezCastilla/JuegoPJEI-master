using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour
{

    public int speed = 2;

    public float anchuraX = 4;
    public float anchuraY = 1;

    private Vector3 posicionObjetivo;

    private bool movimientoDerecha;
    private bool movimientoAbajo;
    private bool movimientoAbajo2;
    private bool movimientoIzquierda;


    // Start is called before the first frame update
    void Start()
    {
        posicionObjetivo = transform.position;

        // Comenzamos moviendonos hacia la derecha
        posicionObjetivo.x += anchuraX;
        movimientoDerecha = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position != posicionObjetivo){
            transform.position = Vector2.MoveTowards(transform.position, posicionObjetivo, speed * Time.deltaTime);
        } else {
            
            if (movimientoDerecha){ 
                posicionObjetivo.y -= anchuraY; // Desplazamiento hacia abajo
                movimientoDerecha = false;
                movimientoAbajo = true;
            } else if(movimientoAbajo) {
                posicionObjetivo.x -= anchuraX; // Desplazamiento hacia la izquierda
                movimientoAbajo = false;
                movimientoIzquierda = true;
            } else if(movimientoIzquierda) {
                posicionObjetivo.y -= anchuraY; // Desplazamiento hacia abajo
                movimientoIzquierda = false;
                movimientoAbajo2 = true;
            } else if (movimientoAbajo2) {
                posicionObjetivo.x += anchuraX; // Desplazamiento hacia la derecha
                movimientoAbajo = false;
                movimientoDerecha = true;
            }
        }
    }
}
