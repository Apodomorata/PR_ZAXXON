using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverBala : MonoBehaviour
{
    float speed;
    [SerializeField] GameObject columna;
    float positionZ;
   

    // Start is called before the first frame update
    void Start()
    {
        speed = 120f;

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        float positionZ = transform.position.z;
    }


}
