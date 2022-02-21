using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botones : MonoBehaviour
{
    public void A()
    {
     SceneManager.LoadScene(1);
    }
    public void VolverAJugar()
    {
        SceneManager.LoadScene(1);
    }
    public void MenuPrincipal()
    {
        SceneManager.LoadScene(0);

    }
    public void GameOver()
    {
        SceneManager.LoadScene(2);
    }
    public void Ajustes()
    {
        SceneManager.LoadScene(3);
    }
    public void Salir()
    {
        Application.Quit();
    }
}
