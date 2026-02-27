using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }
    [SerializeField] private TextMeshProUGUI menuText; 
    [SerializeField] private TextMeshProUGUI buttonText;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI dropCountText;

    private void Awake()
    {
        Instance = this;
    }
    private void Update()
    {
        switch (GameManager.Instance.gameState)
        {
            case GameManager.Game.MENU:
                menuText.text = "Stage 1";
                buttonText.text = "Play";
                break;

            case GameManager.Game.STAGE1:
                buttonText.transform.parent.gameObject.SetActive(false);
                break;

            case GameManager.Game.STAGE1END:
                menuText.text = "Stage 2";
                buttonText.text = "Move on to Stage 2";
                buttonText.transform.parent.gameObject.SetActive(true);
                break;

            case GameManager.Game.STAGE2:
                buttonText.transform.parent.gameObject.SetActive(false);
                break;

            case GameManager.Game.STAGE2END:
                menuText.text = "Stage 3";
                buttonText.text = "Move on to Stage 3";
                buttonText.transform.parent.gameObject.SetActive(true);
                break;

            case GameManager.Game.STAGE3:
                buttonText.transform.parent.gameObject.SetActive(false);

                break;

            case GameManager.Game.END:
                menuText.text = "Stage 3";
                buttonText.text = "Replay from Stage 1";
                buttonText.transform.parent .gameObject.SetActive(true);
                break;
        }
    }

    public void UpdateScore()
    {
        scoreText.text = "Score: " + ScoreManager.Instance.score;
    }

    public void UpdateDropCountText()
    {
        dropCountText.text  = "DropCount: " + ScoreManager.Instance.dropCount;
    }
}
