using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarCanvas : MonoBehaviour
{

    public GameObject TextCanvas;

    void Start(){
        TextCanvas.SetActive(false);
    }

    private void OnTriggerEnter(Collider other){
        if(other.tag == ""){
            TextCanvas.SetActive(true);

        }
    }
    private void OnTriggerExit(Collider other){
        if(other.tag == ""){
            TextCanvas.SetActive(false);
        }
    }
}
