using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KatanaCutChecker : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag(Tags.fruitTag))
        {

            ScoreManager.Instance.score++; //update score
            UIManager.Instance.UpdateScore();

            // destroy whole fruit and replace it with cut fruit variant
            GameObject fruit = collision.gameObject;
            Rigidbody fruitrb = fruit.GetComponent<Rigidbody>();
            GameObject cutFruit = Instantiate(collision.collider.GetComponent<CutFruit>().cutFruitVariant);
            Rigidbody cutFruitrb = cutFruit.GetComponent<Rigidbody>();
            cutFruit.transform.position = fruitrb.position;
            cutFruitrb.velocity = fruitrb.velocity;

            


        }
    }
}
