using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour {

    public bool pausa = false;

    // Use this for initialization
    void Start () {
        
    }
    
    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown (KeyCode.Escape)) {
            pausa = !pausa;
        }

        if (pausa) {
            Time.timeScale = 0f;
        } else {
            Time.timeScale = 1f;
        }
    }
}
