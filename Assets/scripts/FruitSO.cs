using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "FruitName", menuName = "ScriptableObjects/FruitSO")]
public class FruitSO : ScriptableObject
{
    public Transform wholeFruit;
    public Transform cutFruit;
    public string fruitName;
}
