using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropBuilding : MonoBehaviour
{
    [SerializeField] private GameObject Building;
    private Vector3 initialPos;
    private SpringJoint joint;
    private Vector3 increasingPos;

    // Start is called before the first frame update
    void Start()
    {
        initialPos = new Vector3(0f, 4f, 0f);
        increasingPos = new Vector3(0f, 1f, 0f); ;
        GameObject newBuilding = Instantiate(Building, initialPos, Quaternion.identity);
        joint = newBuilding.GetComponent<SpringJoint>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(joint);
            GameObject newBuilding = Instantiate(Building, initialPos, Quaternion.identity);
            joint = newBuilding.GetComponent<SpringJoint>();
            initialPos += increasingPos;
        }
    }
}
