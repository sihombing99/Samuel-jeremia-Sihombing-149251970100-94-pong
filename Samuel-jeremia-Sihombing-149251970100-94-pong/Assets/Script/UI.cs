using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public void exitbutton()
    {
        Application.Quit();
        Debug.Log("game dimatikan");
    }
    public void stargame()
    {
        SceneManager.LoadScene("Pong");
        Debug.Log("Created by Samuel-jeremia-Sihombing-149251970100-94");
    }
}
