using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private Rigidbody rb;

    private void Start()
    {
        rb = this.GetComponent<Rigidbody> ();  // rigidbody‚ğæ“¾
    }
    private void Update ()
    {
        Vector3 force = new Vector3 (0.0f,0.0f,2.0f);    // —Í‚ğİ’è
        if(Input.GetKey (KeyCode.W))
        {
            rb.AddForce (force);  // —Í‚ğ‰Á‚¦‚é
        }
    }
}