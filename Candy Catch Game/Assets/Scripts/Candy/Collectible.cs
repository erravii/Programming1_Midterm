using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int scoreValue = 1;

    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreManager.Instance.AddPoints(scoreValue);
            Destroy(gameObject);
        }
    }
}

