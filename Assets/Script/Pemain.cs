using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pemain : MonoBehaviour
{
    public int normalspeed;
    public int tambahSpeed;
    public float PowerDurasi;
    public KeyCode UpKey;
    public KeyCode DownKey;
    public Power manager;
    public Collider2D ball;
    public Vector3 TambahUkuran;
    private Vector3 ukuranAsli;
   
   
    private int Speedasli;
    private Rigidbody2D rig;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        ukuranAsli = transform.localScale;
        Speedasli = normalspeed;
    }

    private void Update()
    {
        Vector2 movement = GetInput();
        MoveObject(movement);
    }

    private Vector2 GetInput()
    {
        if (Input.GetKey(UpKey)){
            return Vector2.up * normalspeed;
        }
        else if (Input.GetKey(DownKey)){
            return Vector2.down * normalspeed;
        }
        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement)
    {
        rig.velocity = movement;
        Debug.Log("pamain =" + movement);
    }
    public void activatespeedPlayer()
    {
        normalspeed = tambahSpeed;
        StartCoroutine(ResetBuffSpeed());
    }
    public void activateleghtPlayer()
    {
        transform.localScale= TambahUkuran;
        StartCoroutine(ResetBuffleght());
    }

    private void ResetLeght()
    {
        transform.localScale = ukuranAsli;
    }

    private void ResetSpeed()
    {
        normalspeed = Speedasli;
    }
    public IEnumerator ResetBuffleght()
    {
        yield return new WaitForSeconds(PowerDurasi);
        ResetLeght();
    }
    public IEnumerator ResetBuffSpeed()
    {
        yield return new WaitForSeconds(PowerDurasi);
        ResetSpeed();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider == ball)
        {
            manager.lastHitPlayer = this;
        }

    }
}

