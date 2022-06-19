using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LInk : MonoBehaviour
{
    public string Url;

    public void OpenLinkGIthub()
    {
        Application.OpenURL("https://github.com/sihombing99");
    }
    public void openlinkedin()
    {
        Application.OpenURL("https://www.linkedin.com/in/samuelsihombing/");
    }
}
