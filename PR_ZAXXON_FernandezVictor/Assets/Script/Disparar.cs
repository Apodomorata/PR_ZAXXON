using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    [SerializeField] GameObject Bala;
    [SerializeField] Transform instantiatePos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            StartCoroutine("Disparo");
        }
        if (Input.GetKeyUp("space"))
        {
            StopCoroutine("Disparo");
        }
    }

    IEnumerator Disparo() //Intanciador fijo
    {
     
        while (true)
        {
            Vector3 newPos = new Vector3(instantiatePos.position.x, instantiatePos.position.y, instantiatePos.position.z);
            Instantiate(Bala, newPos, Quaternion.identity);

            yield return new WaitForSeconds(0.3f);

           



        }

    }
}
