using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectilePlant : MonoBehaviour
{

    public Animator animator;

    public float speed = 10f;


    void Update()
    {
       
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
       
    }
}
