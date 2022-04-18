using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendulum : MonoBehaviour
{
    [SerializeField] float MaxAngleDeflection = 40.0f;
    [SerializeField] float SpeedOfPendulum = 2.0f;
    private Vector3 initialPos;
    private Vector3 increasingPos;
    // Start is called before the first frame update
    void Start()
    {
        initialPos = new Vector3(0f, 6f, 0f);
        increasingPos = new Vector3(0f, 1f, 0f);
        transform.position = initialPos;
    }

    // Update is called once per frame
    void Update()
    {
        float angle = MaxAngleDeflection * Mathf.Sin(Time.time * SpeedOfPendulum);
        transform.localRotation = Quaternion.Euler(0, 0, angle);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position += increasingPos;
        }
    }
}
