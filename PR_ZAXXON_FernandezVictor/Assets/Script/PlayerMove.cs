using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Vector3 CubePost = new Vector3(0f, 0f, 0f);

    public float speed = 0f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = CubePost;
        speed = 10f;

    }

    // Update is called once per frame
    void Update()
    {
        // Movimiento nave.

        float desplH = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * desplH);

        float desplV = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * Time.deltaTime * speed * desplV);

       

    }
    

}