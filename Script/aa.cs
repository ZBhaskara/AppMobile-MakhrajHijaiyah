using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public void Mainmenu()
    {
        SceneManager.LoadScene("MENU");
    }
    public void Informasi()
    {
        SceneManager.LoadScene("ButtonInformasi");
    }
    public void Materi1()
    {
        SceneManager.LoadScene("Materi1");
    }
    public void Materi2()
    {
        SceneManager.LoadScene("materi2");
    }
    public void Materi3()
    {
        SceneManager.LoadScene("materi3");
    }

    public void Materi4()
    {
        SceneManager.LoadScene("Materi4");
    }
    public void Materi5()
    {
        SceneManager.LoadScene("materi5");
    }
    public void Materi6()
    {
        SceneManager.LoadScene("materi6");
    }

    public void Petunjuk()
    {
        SceneManager.LoadScene("Petunjuk");
    }
    public void Soal()
    {
        SceneManager.LoadScene("Soal");
    }
    public void Video()
    {
        SceneManager.LoadScene("materiVideo");
    }
    public void Pertanyaan1()
    {
        SceneManager.LoadScene("pertanyaan1");
    }
    public void Pertanyaan2()
    {
        SceneManager.LoadScene("pertanyaan2");
    }
    public void Score()
    {
        SceneManager.LoadScene("score");
    }
    public void Quis1()
    {
        Application.LoadLevel("Quis1");
    }
}

