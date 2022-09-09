using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Trigger function
    void OnTriggerEnter(Collider other, GameObject text)
    {
        Renderer render = GetComponent<Renderer>();
        render.material.color = Color.green;
    }
}
