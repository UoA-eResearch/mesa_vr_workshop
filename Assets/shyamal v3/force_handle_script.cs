using UnityEngine;
using System.Collections;

public class force_handle_script : MonoBehaviour {
    public Rigidbody rb;
    public Vector3 startPos;
    // Use this for initialization
    void Start () {
        startPos = transform.position;

        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-15, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
    }
}

