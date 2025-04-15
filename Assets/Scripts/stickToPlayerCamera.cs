using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stickToPlayerCamera : MonoBehaviour
{
    public GameObject playerTransform;
    public GameObject cameraTransform;
    
    void Update()
    {
        Vector3 cameraPos = cameraTransform.transform.position;
        cameraPos.y = playerTransform.transform.position.y;
        cameraTransform.transform.position = cameraPos;
    }
}
