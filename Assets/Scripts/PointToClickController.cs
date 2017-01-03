using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PointToClickController : MonoBehaviour {

   // public Transform target = null;
	// Use this for initialization
	void Start ()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        //agent.destination = target.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                agent.destination = hit.point;
            }
        }
    }
}


