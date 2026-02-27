using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitDestroyOnCut : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag(Tags.katanaTag)) Destroy(gameObject);
    }
}
