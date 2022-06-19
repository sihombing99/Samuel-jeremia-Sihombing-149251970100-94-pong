using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public Vector2 speed;
    public Vector2 resetPosition;
    private Rigidbody2D  rig;
    
    
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
    }
        
    
    public void ResetBall()
    {
        transform.position = resetPosition;
        rig.velocity = speed;
    }
    public void ActivatePUspeedUp(float magnitude)
    {
        rig.velocity *= magnitude;
    }
    
}
