using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnVirus : MonoBehaviour{

    public GameObject virus;
    // Start is called before the first frame update
    void Start(){
        Instantiate(virus, transform.position, transform.rotation);
    }
}
