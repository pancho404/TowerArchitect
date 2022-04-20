using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropBuilding : MonoBehaviour
{
    [SerializeField] private GameObject Building;
    [SerializeField] private Rigidbody connectedRb;
    private Vector3 initialPos;
    private HingeJoint joint;
    private Vector3 increasingPos;

    // Start is called before the first frame update
    void Start()
    {
        initialPos = new Vector3(0f, 4f, 0f);
        increasingPos = new Vector3(0f, 1.5f, 0f);
        SpawnBuilding();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(joint);
            initialPos += increasingPos;
        }        
    }

    public void SpawnBuilding()
    {
        GameObject newBuilding = Instantiate(Building, initialPos, Quaternion.identity);
        newBuilding.GetComponent<OnCollision>().dropBuilding = this;
        joint = newBuilding.GetComponent<HingeJoint>();
        joint.connectedBody = connectedRb;
        
    }
}
