using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//библиотека для класса SceneManager

public class ButtonMenu : MonoBehaviour
{
    public void ButtonStart()
    {
        SceneManager.LoadScene("SampleScene"); //загружаем сцену под названием SampleScene
    }

    public void ButtonExit()
    {
        Application.Quit();
    }
}
