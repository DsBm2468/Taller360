using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingHorseSoundActive : MonoBehaviour
{
    public GameObject post;
    //public GameObject post1;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Player")) //other.CompareTag es para que el audio permanezca todo el tiempo, además del loop en el sound data
        {
            AudioManager.Instance.Play2D("2"); // Se usa 2D para que el sonido no cambie por la posicion en donde este la camara

            //AudioManager.Instance.Play2D("");
        }
    }
    private void OnTriggerExit(Collider other)
    {
       //if (other.tag == "Player")
       // {
       //     AudioManager.Instance.Play3D("2", post1.transform.position);
       //     //AudioManager.Instance.Play2D("Salir");
       // }
    }
}
