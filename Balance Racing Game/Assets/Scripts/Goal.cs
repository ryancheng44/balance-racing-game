using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collisionInfo)
    {
        if (collisionInfo.CompareTag("Player"))
        {
            Debug.Log("GAME WON! :D");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
