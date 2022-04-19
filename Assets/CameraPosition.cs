using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosition : MonoBehaviour
{
    private Vector3 initialPos;
    private Vector3 increasingPos;
    [SerializeField] GameObject crane;
    private Vector3 cameraOffset = new Vector3(0f, -0f, -8f);


    // Start is called before the first frame update
    void Start()
    {
        initialPos = new Vector3(0f, 1f,-8f);
        increasingPos = new Vector3(0f, 2f, 0f);
        transform.position = initialPos;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = crane.transform.position + cameraOffset;
        }
    }
}
