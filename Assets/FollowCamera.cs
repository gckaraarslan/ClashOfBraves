using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
   public Transform target;
    public Vector3 offset;
  
    void LateUpdate()
    {
        
        transform.position=target.position+offset;
    }
}

// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
//
// public class FollowCamera : MonoBehaviour
// {
//     public Transform target;
//     public Vector3 offset;
//     public float zoomSpeed = 10f;  // Adjust zoom sensitivity
//     public float minZoom = 2f;     // Minimum zoom distance
//     public float maxZoom = 10f;    // Maximum zoom distance
//
//     void LateUpdate()
//     {
//         float scroll = Input.GetAxis("Mouse ScrollWheel");  // Get mouse wheel delta
//
//         // Calculate zoom based on scroll wheel input
//         float zoomAmount = scroll * zoomSpeed;
//         offset.y += zoomAmount;
//        // offset.z += zoomAmount;
//
//         // Clamp zoom within defined limits
//         offset.y = Mathf.Clamp(offset.y, minZoom, maxZoom);
//         //offset.z = Mathf.Clamp(offset.z, minZoom, maxZoom);
//
//         transform.position = target.position + offset;
//     }
// }