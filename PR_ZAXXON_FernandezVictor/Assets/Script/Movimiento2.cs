using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento2 : MonoBehaviour
{ 

    [SerializeField] float desplSpeed;

    // Start is called before the first frame update
    void Start()
    {
        desplSpeed = 35f;
    }

    // Update is called once per frame
    void Update()
    {
        float desplX = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * desplSpeed * desplX, Space.World);

        float desplY = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * Time.deltaTime * desplSpeed * desplY, Space.World);

        float posY = transform.position.y;
        float posX = transform.position.x;

        if (posX > 47f && desplX > 0)
        {
            transform.position = new Vector3(47f, transform.position.y, transform.position.z);
        }
        if (posX < -47f && desplX < 0)
        {
            transform.position = new Vector3(-47f, transform.position.y, transform.position.z);
        }
        if (posY > 14f && desplY > 0)
        {
            transform.position = new Vector3(transform.position.x, 14f, transform.position.z);
        }
        if (posY < 0.5f && desplY < 0)
        {
            transform.position = new Vector3(transform.position.x, 0.5f, transform.position.z);
        }

    }

    //private void OnTriggerEnter(Collider other)
    
}
