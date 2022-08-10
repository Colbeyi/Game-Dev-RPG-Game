using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class navmove : MonoBehaviour
{
    [SerializeField] Transform target;
    NavMeshAgent agent;
    


    
    
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        
    }

    
    void Update()
    {
        if (Input.GetMouseButton(0))
        {

            CursorMove();
        }
       
        
        
    }

    private void CursorMove()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        bool hasHit = Physics.Raycast(ray,out hit);
        if (hasHit)
        {
            agent.destination = hit.point;
        }
    }
}
