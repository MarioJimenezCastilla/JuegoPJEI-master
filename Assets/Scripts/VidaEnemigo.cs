using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaEnemigo : MonoBehaviour
{
    public int vidaEnemigo = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Para que nos vaya restando vida cuando estemos tocando el objeto.
	void OnCollisionStay2D(Collision2D choque){
		if(choque.gameObject.CompareTag ("Bala")) {
            --vidaEnemigo;
            if (vidaEnemigo <= 0) {
					
					Destroy (gameObject);
				}
        }
    }        
}
