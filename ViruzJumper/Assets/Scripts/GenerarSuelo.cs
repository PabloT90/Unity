using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarSuelo : MonoBehaviour{
    public float speed;
    private float Xend;
    private float Xstart;

    private void Start() {
        Xend = 0f;
        Xstart = -16f;
    }

    private void Update() {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (transform.position.x < Xend) {
            Vector2 pos = new Vector2(Xstart, transform.position.y);
            transform.position = pos;
        }
    }
}
