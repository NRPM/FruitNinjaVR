using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RandomFruitSpawner : MonoBehaviour
{
    [SerializeField] private List<FruitSO> fruitSOList = new List<FruitSO>();
    [SerializeField] private float intervalBetweenSpawn = 2f;
    [SerializeField] private int minLaunchSpeed = 10;
    [SerializeField] private int maxLaunchSpeed = 20;
    
    //private List<Transform> spawnedFruitsList = new List<Transform>();
    private int maxFruitsSpawnedAtOnce = 3;
    
    private float currentTime = 0f;

 
    private void Update()
    {
        switch(GameManager.Instance.gameState)
        {
            case GameManager.Game.STAGE1:
                intervalBetweenSpawn = 2f;
            break;

            case GameManager.Game.STAGE2:
                intervalBetweenSpawn = 1.5f;
            break;

            case GameManager.Game.STAGE3:
                intervalBetweenSpawn = 1f;
            break;
        }

        currentTime += Time.deltaTime;
        if (((GameManager.Instance.gameState == GameManager.Game.STAGE1) || (GameManager.Instance.gameState == GameManager.Game.STAGE2) || (GameManager.Instance.gameState == GameManager.Game.STAGE3)) && currentTime > intervalBetweenSpawn)
        {
            currentTime = 0f;
            for (int i = 0; i < Random.Range(1, maxFruitsSpawnedAtOnce); i++)
            {

                Transform fruit = Instantiate(fruitSOList[Random.Range(0, fruitSOList.Count)].wholeFruit);
                fruit.position = gameObject.transform.position;
                Rigidbody fruitRb = fruit.GetComponent<Rigidbody>();
                fruitRb.velocity = transform.up * Random.Range(minLaunchSpeed, maxLaunchSpeed);
                //spawnedFruitsList.Add(fruit);
            }
        }
    }

}
