using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; set; }
    public int score = 0;
    public int maxDropCount = 15;
    public int dropCount = 0;

    private void Awake()
    {
        Instance = this;
    }

    

}
