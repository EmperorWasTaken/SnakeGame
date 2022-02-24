using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class DeactivatePickup : MonoBehaviour
{

    void Start()
    {
        Invoke("Deactivate", Random.Range(10f, 20f));
    }

    void Deactivate()
    {
        gameObject.SetActive(false);
        Destroy(gameObject);
    }
}
