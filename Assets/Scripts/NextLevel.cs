using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            int current = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(current + 1);
        }
    }
}
