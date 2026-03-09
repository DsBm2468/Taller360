using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogSoundActive : MonoBehaviour
{
    public GameObject post;
    public GameObject post1;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            AudioManager.Instance.Play3D("1", post.transform.position);
            //AudioManager.Instance.Play2D("");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            AudioManager.Instance.Play3D("1", post1.transform.position);
            //AudioManager.Instance.Play2D("Salir");
        }
    }
}
