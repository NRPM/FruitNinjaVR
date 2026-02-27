using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; set; }
    public enum Game {MENU, STAGE1, STAGE1END, STAGE2,STAGE2END, STAGE3, END };

    public Game gameState;
    private void Awake()
    { 
      
            Instance = this;
            
    }

    private void Start()
    {
        gameState = Game.MENU;
        Debug.Log(gameState);
    }

    private void Update()
    {
        switch (gameState)
        {
            case Game.STAGE1:
                if (ScoreManager.Instance.dropCount >= ScoreManager.Instance.maxDropCount)
                {
                    ScoreManager.Instance.dropCount = 0;
                    gameState = Game.STAGE1END;
                    Debug.Log(gameState);
                }
                break;

            case Game.STAGE2:
                if (ScoreManager.Instance.dropCount >= ScoreManager.Instance.maxDropCount)
                {
                    ScoreManager.Instance.dropCount = 0;
                    gameState = Game.STAGE2END;
                    Debug.Log(gameState);
                }
                break;

            case Game.STAGE3:
                if (ScoreManager.Instance.dropCount >= ScoreManager.Instance.maxDropCount)
                {
                    ScoreManager.Instance.dropCount = 0;
                    gameState = Game.END;
                    Debug.Log(gameState);
                }
                break;
        }
    }
    public void PlayGame()
    {
        switch (gameState)
        {
            case Game.MENU:
                    gameState = Game.STAGE1;
                    Debug.Log(gameState);
                break;

            

            case Game.STAGE1END:
                    gameState = Game.STAGE2;
                    Debug.Log(gameState);
                
                break;

           

            case Game.STAGE2END:
                    gameState = Game.STAGE3;
                    Debug.Log(gameState);
                break;

            

            case Game.END:
                ScoreManager.Instance.score = 0;
                UIManager.Instance.UpdateScore();
                gameState = Game.STAGE1;
                Debug.Log(gameState);
                break;
        }
        
    }

    
    
}

    
