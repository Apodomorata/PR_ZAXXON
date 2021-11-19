 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstanciadorPuntos : MonoBehaviour
{

 

    float intervalo;
    [SerializeField] GameObject Puntos;
    [SerializeField] Transform instantiatePos;

    // Start is called before the first frame update
    void Start()
    {
        intervalo = 0.4f;

        

        StartCoroutine("CrearPuntos");
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    IEnumerator CrearPuntos()
    {
        float randomX;
        float randomY;
        while (true)
        {
            randomX = Random.Range(-40f, 40f);
            randomY = Random.Range(0f, 20f);
            Vector3 newPos = new Vector3(randomX, randomY, instantiatePos.position.z);
            Instantiate(Puntos, newPos, Quaternion.identity);

            yield return new WaitForSeconds(intervalo);
        }

    }

   
}
