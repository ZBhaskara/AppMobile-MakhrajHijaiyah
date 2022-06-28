using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public void Mainmenu()
    {
        SceneManager.LoadScene("MainMenu");
        //StartCoroutine(delay());
    }
    public void Informasi()
    {
        SceneManager.LoadScene("Informasi");
        //StartCoroutine(delay());
    }
    public void MengenalHijaiyah()
    {
        SceneManager.LoadScene("MengenalHijaiyah");
    }
    
    public void BelajarMakhraj()
    {
        SceneManager.LoadScene("BelajarMakhraj");
    }
    public void BelajarMakhraj2()
    {
        SceneManager.LoadScene("BelajarMakhraj2");
    }
    public void Openkuis()
    {
        SceneManager.LoadScene("Openkuis");
    }
    public void Kuis()
    {
        SceneManager.LoadScene("Kuis");
    }
    public void Kuis1()
    {
        SceneManager.LoadScene("Kuis1");
    }

    /*public void Alif()
    {
        SceneManager.LoadScene("Alif");
    }*/
    public void Ba()
    {
        SceneManager.LoadScene("Ba");
    }
    /*public void animba()
    {
        SceneManager.LoadScene("animba");
    }*/

    public void Ta()
    {
        SceneManager.LoadScene("Ta");
    }
    public void Tsa()
    {
        SceneManager.LoadScene("Tsa");
    }
    public void Ja()
    {
        SceneManager.LoadScene("Ja");
    }
    public void Hatipis()
    {
        SceneManager.LoadScene("Hatipis");
    }
    public void Kho()
    {
        SceneManager.LoadScene("Kho");
    }
    public void Dal()
    {
        SceneManager.LoadScene("Dal");
    }
    public void Dzal()
    {
        SceneManager.LoadScene("Dzal");
    }
    public void Ro()
    {
        SceneManager.LoadScene("Ro");
    }
    public void Zay()
    {
        SceneManager.LoadScene("Zay");
    }
    public void Sin()
    {
        SceneManager.LoadScene("Sin");
    }
    public void Syin()
    {
        SceneManager.LoadScene("Syin");
    }
    public void Shad()
    {
        SceneManager.LoadScene("Shad");
    }
    public void Dhad()
    {
        SceneManager.LoadScene("Dhad");
    }
    public void Tha()
    {
        SceneManager.LoadScene("Tha");
    }
    public void Dza()
    {
        SceneManager.LoadScene("Dza");
    }
    public void Ain()
    {
        SceneManager.LoadScene("Ain");
    }
    public void Ghoin()
    {
        SceneManager.LoadScene("Ghoin");
    }
    public void Fa()
    {
        SceneManager.LoadScene("Fa");
    }
    public void Qof()
    {
        SceneManager.LoadScene("Qof");
    }
    public void Kaf()
    {
        SceneManager.LoadScene("Kaf");
    }
    public void Lam()
    {
        SceneManager.LoadScene("Lam");
    }
    public void Mim()
    {
        SceneManager.LoadScene("Mim");
    }
    public void Nun()
    {
        SceneManager.LoadScene("Nun");
    }
    public void Ha()
    {
        SceneManager.LoadScene("Ha");
    }
    public void Wau()
    {
        SceneManager.LoadScene("Wau");
    }
    public void Ya()
    {
        SceneManager.LoadScene("Ya");
    }
    public void Hamzah()
    {
        SceneManager.LoadScene("Hamzah");
    }



    
    public void Keluar()
    {
        Application.Quit();
    }

    /*IEnumerator delay()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Informasi");

        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Mainmenu");

    }*/
}

