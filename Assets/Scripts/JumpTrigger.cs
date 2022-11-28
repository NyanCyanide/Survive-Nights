using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTrigger : MonoBehaviour
{

    public AudioSource scream;
    public GameObject player;
    public GameObject jumpcam;
    public GameObject flashimg;

    void OnTriggerEnter()
    {

            scream.Play();
            player.SetActive(false);
            jumpcam.SetActive(true);
            flashimg.SetActive(true);
            StartCoroutine(Flash());
    }

    IEnumerator Flash()
    {
        yield return new WaitForSeconds(2.03f);
        flashimg.SetActive(false);
        player.SetActive(true);
        jumpcam.SetActive(false);
    }
}
