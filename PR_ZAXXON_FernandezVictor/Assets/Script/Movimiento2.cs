using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Movimiento2 : MonoBehaviour
{

    [SerializeField] GameObject nave;
    [SerializeField] float desplSpeed;
    public int Vida;

    [SerializeField] Transform navePos;
   
    public float speed; // Velocidad de los obstaculos

    public int score;
    public Text Score;

    //Explosion
    [SerializeField] GameObject Explosion;

    // Start is called before the first frame update
    void Start()
    {
        desplSpeed = 60f;
        Vida = 1;
        speed = 75f;

        Score.text = "Score " + score;

    }

    // Update is called once per frame
    void Update()
    {

        

        // Movimiento  izquierda/derceha
        float desplX = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * desplSpeed * desplX, Space.World);

        // Movimiento arriba/abajo
        float desplY = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * Time.deltaTime * desplSpeed * desplY, Space.World);

        //Movimiento eje z
        //float desplz = Input.GetAxis("Adelante");
        //transform.Translate(Vector3.right * Time.deltaTime * desplSpeed * desplX, Space.World);

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
        if (posY > 18f && desplY > 0)
        {
            transform.position = new Vector3(transform.position.x, 18f, transform.position.z);
        }
        if (posY < 0.5f && desplY < 0)
        {
            transform.position = new Vector3(transform.position.x, 0.5f, transform.position.z);
        }
        transform.rotation = Quaternion.Euler(desplY * -30, 0, desplX * -30);

        if(score == 5)
        {
            speed = 120f;
            desplSpeed = 65f;
        }

        if (score == 10)
        {
            speed = 170f;
            desplSpeed = 70f;
        }
        if (score == 20)
        {
            speed = 200f;
            desplSpeed = 80f;
        }



    }

    private void OnTriggerEnter(Collider other)
   {


        if (other.gameObject.tag == "Obstaculo")
        {
            Vida--;
            if (Vida == 0)
            {
                nave.SetActive(false);
                speed = 0f;
                Instantiate(Explosion, navePos.position, Quaternion.identity);

                desplSpeed = 0f;

                StartCoroutine("Morir");
            }

        }
        else if(other.gameObject.tag == "Puntos")
        {
            
            score++;
            print("hola" + score);
            Score.text = "Score " + score;
            Destroy(other.gameObject);
        }




    }

    IEnumerator Morir()
    {
        
        yield return new WaitForSeconds(1.5f);


        SceneManager.LoadScene(2);
    }

    




}
