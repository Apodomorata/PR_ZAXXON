using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciador : MonoBehaviour
{
    float intervalo;
    [SerializeField] GameObject columna;
    [SerializeField] Transform instantiatePos;
    float distancia = 30f;
    Movimiento2 movimiento2;
    float speed;


    // Start is called before the first frame update
    void Start()
    {
        //intervalo = 0.4f;

        StartCoroutine("CrearColumna");

        movimiento2 = GameObject.Find("Nave").GetComponent<Movimiento2>();

    }

    // Update is called once per frame
    void Update()
    {
        speed = movimiento2.speed;
        intervalo = distancia / speed;
    }

    IEnumerator CrearColumna()
    {
        float randomX;
        while (true)
        {
            randomX = Random.Range(-40f, 40f);
            Vector3 newPos = new Vector3(randomX, instantiatePos.position.y, instantiatePos.position.z);
            Instantiate(columna, newPos, Quaternion.identity);

            yield return new WaitForSeconds(intervalo);
        }

    }

   


}