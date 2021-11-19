using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverColumnas : MonoBehaviour
{
    float speed;
    [SerializeField] GameObject columna;
    float positionZ;
    float destrPrefab = -180f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = GameObject.Find("Nave").GetComponent<Movimiento2>().speed;
        
        transform.Translate(Vector3.back * Time.deltaTime * speed);

        float positionZ = transform.position.z;

        if (positionZ < destrPrefab)
        {
            Destroy(columna);
        }
    }
}
