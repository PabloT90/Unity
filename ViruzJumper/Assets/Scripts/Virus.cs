using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Virus : MonoBehaviour
{
    public float speed;
    public GameObject efecto;
    public GameObject bonecracking;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        //Movemos el virus a la izquierda.
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    //Cuando el jugador colisione contra un virus:
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Player")) { //Si es el jugador el que colisiona
            Instantiate(bonecracking);
            collision.GetComponent<Player>().vidas--; //Le restamos una vida al jugador.
            collision.GetComponent<Player>().animacion.SetTrigger("shake");
            //Instanciamos la animacion del virus explotando
            Instantiate(efecto, transform.position, transform.rotation);
            Destroy(gameObject); //Destruimos el virus.
        }
    }
}
