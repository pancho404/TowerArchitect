using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision : MonoBehaviour
{
    [SerializeField] private GameObject Building;
    [SerializeField] private Rigidbody rb;
    public DropBuilding dropBuilding;

    // Start is called before the first frame update
    void Start()
    {
        rb = Building.GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        dropBuilding.SpawnBuilding();
        Destroy(rb);
        Destroy(this);
    }
}
