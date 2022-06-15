using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : MonoBehaviour
{
    public Transform areaMuncul;
    public int maxPowerUpAmount;
    public int spawnInterval;
    
    public Vector2 LetakSkilMin;
    public Vector2 LetakSkilMax;

    public List<GameObject> powerUpTemplateList;
   
    private List<GameObject> powerUpList;
    private float timer;

    private void Start()
    {
        powerUpList = new List<GameObject>();
        timer = 0;
    }

    private void  Update()
    {
        timer += Time.deltaTime;
        if (timer > spawnInterval)
        {
            GenerateRandomPowerUp();
            timer -= spawnInterval;
        }
    }

    public void GenerateRandomPowerUp()
    {
        GenerateRandomPowerUp(new Vector2(Random.Range(LetakSkilMin.x, LetakSkilMax.x), Random.Range(LetakSkilMin.y, LetakSkilMax.y)));
    }

    public void GenerateRandomPowerUp(Vector2 position)
     {
        
        if (powerUpList.Count >= maxPowerUpAmount)
        {
            RemovePowerUp(powerUpList[0]);
            return;
        }
        if (position.x < LetakSkilMin.x ||
            position.x > LetakSkilMax.x ||
            position.y < LetakSkilMin.y ||
            position.y > LetakSkilMax.y)
        {
            return;
        }
        Debug.Log("oke");

        int randomIndex = Random.Range(0, powerUpTemplateList.Count);

        GameObject powerUp = Instantiate(powerUpTemplateList[randomIndex], new Vector3(position.x, position.y, powerUpTemplateList[randomIndex].transform.position.z), Quaternion.identity, areaMuncul);
        powerUp.SetActive(true);
 
        powerUpList.Add(powerUp);

    }
    public void RemovePowerUp(GameObject powerUp)
    {
        powerUpList.Remove(powerUp);
        Destroy(powerUp);
    }

    public void RemoveAllPowerUp()
    {
        while(powerUpList.Count >= 0)
        {
            RemovePowerUp(powerUpList[0]);
        }
    }
}


