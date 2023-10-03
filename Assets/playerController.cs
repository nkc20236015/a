using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private Rigidbody rb;

    private void Start()
    {
        rb = this.GetComponent<Rigidbody> ();  // rigidbodyを取得
    }
    private void Update ()
    {
        Vector3 force = new Vector3 (0.0f,0.0f,2.0f);    // 力を設定
        if(Input.GetKey (KeyCode.W))
        {
            rb.AddForce (force);  // 力を加える
        }
    }
}