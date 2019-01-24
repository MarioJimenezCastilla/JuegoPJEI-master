using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionStay2D(Collision2D choque){
		if(choque.gameObject.CompareTag ("Enemigo")) {
           
           Destroy(gameObject);
        }
    }        
}
