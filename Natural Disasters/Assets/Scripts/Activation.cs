using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activation : MonoBehaviour
{
    public GameObject activation1;
    public GameObject activation2;
    public GameObject activation3;
    public GameObject deactivation1;
    public GameObject deactivation2;
    public GameObject deactivation3;

    void OnTriggerEnter(Collider other)
    { 
        if (other.CompareTag("Player"))
        {
            activation1.SetActive(true);
            activation2.SetActive(true);
            activation3.SetActive(true);
        }
        if (other.CompareTag("Player"))
        {
            deactivation1.SetActive(false);
            deactivation2.SetActive(false);
            deactivation3.SetActive(false);
        }

    }
}