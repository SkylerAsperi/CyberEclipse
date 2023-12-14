using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activation : MonoBehaviour
{
    public GameObject activation1;
    public GameObject activation2;
    public GameObject activation3;
    public GameObject activation4;
    public GameObject activation5;
    public GameObject deactivation1;
    public GameObject deactivation2;
    public GameObject deactivation3;
    public GameObject deactivation4;
    public GameObject deactivation5;

    void OnTriggerEnter(Collider other)
    { 
        if (other.CompareTag("Player"))
        {
            activation1.SetActive(true);
            activation2.SetActive(true);
            activation3.SetActive(true);
            activation4.SetActive(true);
            activation5.SetActive(true);
            deactivation1.SetActive(true);
            deactivation2.SetActive(true);
            deactivation3.SetActive(true);
            deactivation4.SetActive(true);
            deactivation5.SetActive(true);
        }
    }
}