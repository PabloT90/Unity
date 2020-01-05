using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GestionVirus : MonoBehaviour{

    public int puntos;
    public Text puntosDiplay;
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        puntosDiplay.text = puntos.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        //Contabilizamos la puntuacion.
        puntos++;
    }
}
