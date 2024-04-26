using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
  Animator animator;

    Ray ray;
   
   private void Start() {
    animator=GetComponent<Animator>();
   }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            MoveToCursor();
            
        }
        UpdateAnimator();


    }
   void MoveToCursor()
    {
       
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray,out hit))
        {
            Debug.DrawRay(ray.origin, ray.direction * 100, Color.red, 5f, false);
            GetComponent<NavMeshAgent>().SetDestination(hit.point);
        }
       
        
    }
    void UpdateAnimator()
    {
        Vector3 velocity=GetComponent<NavMeshAgent>().velocity;
        Vector3 localVelocity=transform.InverseTransformDirection(velocity);
        float speed=localVelocity.z;
        GetComponent<Animator>().SetFloat("forwardSpeed", speed);
    }
}

