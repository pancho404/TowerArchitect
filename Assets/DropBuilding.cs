﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropBuilding : MonoBehaviour
{
    [SerializeField] private GameObject Building;
    private Vector3 initialPos;
    private SpringJoint joint;
    
    // Start is called before the first frame update
    void Start()
    {
        joint = Building.GetComponent<SpringJoint>();
        initialPos = new Vector3(0f, 4f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DestroyImmediate(joint, true);
            Instantiate(Building, initialPos, Quaternion.identity);
        }
    }
}
