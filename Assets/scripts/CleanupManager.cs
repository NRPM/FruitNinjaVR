using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanupManager : MonoBehaviour
{

    public static CleanupManager Instance { get; set; }
    [SerializeField]private float waitInterval = 2f;
    

    private void Awake()
    {
        Instance = this;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag(Tags.fruitTag))
        {
            ScoreManager.Instance.dropCount++;
            StartCoroutine(Cleanup(collision.gameObject));
            UIManager.Instance.UpdateDropCountText();
        }
        else if (collision.collider.CompareTag(Tags.cutFruitTag))
        {
            StartCoroutine(Cleanup(collision.gameObject));
        }

    }

    IEnumerator Cleanup(GameObject go)
    {
        yield return new WaitForSeconds(waitInterval);
        Destroy(go);
        Debug.Log("destroyed fruit");

        
    }
}
