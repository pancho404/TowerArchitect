using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyRB : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(rb);
    }
}
