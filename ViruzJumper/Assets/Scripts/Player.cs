using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour{

    public float desplazamiento;
    public float maxY;
    public float minY;
    public int vidas;
    public Animator animacion;
    public GameObject moveEffect;
    private Vector2 posJugador;

    public GameObject blinksound;
    public Text vidasDisplay;
    public GameObject spawnVirus;
    public GameObject restartDisplay;

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){

        //Si no tiene mas vidas damos la opcion de reiniciar el juego.
        if (vidas == 0) {
            spawnVirus.SetActive(false);
            restartDisplay.SetActive(true);
            Destroy(gameObject);
        }

        //Mostramos las vidas del jugador.
        vidasDisplay.text = vidas.ToString();
        transform.position = Vector2.MoveTowards(transform.position, posJugador, 1);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxY) {
            //Animacion
            Instantiate(blinksound);
            animacion.SetTrigger("shake");
            Instantiate(moveEffect, transform.position, Quaternion.identity);
            posJugador = new Vector2(transform.position.x, transform.position.y + desplazamiento);
        } else if(Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minY){
            Instantiate(blinksound);
            animacion.SetTrigger("shake");
            Instantiate(moveEffect, transform.position, Quaternion.identity);
            posJugador = new Vector2(transform.position.x, transform.position.y - desplazamiento);
        }

        
    }
}
