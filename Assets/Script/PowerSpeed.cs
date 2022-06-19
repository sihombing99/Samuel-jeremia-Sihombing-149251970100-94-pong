using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSpeed : MonoBehaviour
{
    public enum PowerType { BallSpeed, tambahCepat, tambahPanjang };

    public Power manager;
    public Collider2D ball;
    public float magnitude;
    public PowerType powerupType;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            if (powerupType == PowerType.BallSpeed)
            {
                ball.GetComponent<BallControl>().ActivatePUspeedUp(magnitude);
            }else if (powerupType == PowerType.tambahCepat)
            {
                if (manager.lastHitPlayer != null)
                {
                    manager.lastHitPlayer.activatespeedPlayer();
                }
            }
            else
            {
                if (manager.lastHitPlayer != null)
                {
                    manager.lastHitPlayer.activateleghtPlayer();
                }
            }
            manager.RemovePowerUp(gameObject);
        }
    }
}
