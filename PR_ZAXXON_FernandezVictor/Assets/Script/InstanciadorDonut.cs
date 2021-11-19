using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciadorDonut : MonoBehaviour
{
    float intervalo;
    [SerializeField] GameObject Donut;
    [SerializeField] Transform instantiatePos;


    // Start is called before the first frame update
    void Start()
    {
        intervalo = 0.4f;

        StartCoroutine("CrearDonut");


    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator CrearDonut()
    {
        float randomX;
        while (true)
        {
            randomX = Random.Range(-40f, 40f);
            Vector3 newPos = new Vector3(randomX, instantiatePos.position.y, instantiatePos.position.z);
            Instantiate(Donut, newPos, Quaternion.identity);

            yield return new WaitForSeconds(intervalo);
        }

    }



}
