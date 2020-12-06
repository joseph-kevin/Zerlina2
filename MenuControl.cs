using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour {

   

    public void GoToHousesScene()
    {
        SceneManager.LoadScene("Houses");
    }

    public void GoToShapesScene()
    {
        SceneManager.LoadScene("Shapes");
    }

    public void GoToAnimalsScene()
    {
        SceneManager.LoadScene("Animals");
    }

    public void GoToMapsScene()
    {
        SceneManager.LoadScene("Maps");
    }

    public void GoToTrucksScene()
    {
        SceneManager.LoadScene("Trucks");
    }

    public void GoToFruitsScene()
    {
        SceneManager.LoadScene("Fruits");
    }

    public void GoToCategoryScene()
    {
        SceneManager.LoadScene("Categories");
    }

    public void OnQuit()
    {
        Application.Quit();
    }

    public void OnRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void OnMenu()
    {
        SceneManager.LoadScene("Menu");
    }


   
    /*
    public void OnLevel1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void OnLevel2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void OnLevel3()
    {
        SceneManager.LoadScene("Level3");
    }

    */
}

