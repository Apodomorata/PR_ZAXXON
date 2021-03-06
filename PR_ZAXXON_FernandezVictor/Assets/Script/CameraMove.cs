using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] Transform playerPosition;
    //Variables necesarias para la opci?n de suavizado
    [SerializeField] float smoothVelocity = 0.3F;
    [SerializeField] Vector3 camaraVelocity = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //Con este c?digo, conseguimos que siga al objeto pero con suavidad
        //La velocidad de suavizado, cuanto menor sea m?s brusco ser? el movimiento
        Vector3 targetPosition = new Vector3(playerPosition.position.x, playerPosition.position.y +12f, playerPosition.position.z -20);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref camaraVelocity, smoothVelocity);
       
    }
}
