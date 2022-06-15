using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSpeed : MonoBehaviour
{
    public Power manager;
    public Collider2D ball;
    public float magnitude;

    private void OnTriggerEnter2D(Collider2D colision)
    {
        if (colision == ball)
        {
            ball.GetComponent<BallControl>().ActivatePUspeedUp(magnitude);
            manager.RemovePowerUp(gameObject);
        }
    }
}
