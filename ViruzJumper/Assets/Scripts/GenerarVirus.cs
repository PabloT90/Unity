using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarVirus : MonoBehaviour{

    private float tiempoInterno;
    public float tiempoSpawn;
    public GameObject[] obstaculosTemplates;

    // Start is called before the first frame update
    void Start(){
        tiempoInterno = tiempoSpawn;
    }

    // Update is called once per frame
    void Update(){
        if (tiempoInterno <= 0) {
            int random = Random.Range(0, obstaculosTemplates.Length);
            Instantiate(obstaculosTemplates[random], transform.position, transform.rotation);
            tiempoInterno = tiempoSpawn;
        } else {
            tiempoInterno -= Time.deltaTime;
        }
        
    }
}
