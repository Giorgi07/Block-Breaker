using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour
{
    public string gameOverScene = "Game Over";

    private void OnTriggerEnter2D(Collider2D collider)
    {
        SceneManager.LoadScene(gameOverScene);
    }

}
