using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sistempoin : MonoBehaviour
{
    public Text skorKiri; 
    public Text skorKanan;

    public Skor manager;

    private void Update()
    {
        skorKiri.text = manager.leftScore.ToString();
        skorKanan.text = manager.rightScore.ToString();
    }
}
