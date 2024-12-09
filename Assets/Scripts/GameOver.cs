using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.Audio;

public class PlayerCollision : MonoBehaviour
{
    private bool isDestroyed = false;

    public GameObject gameOverUI;
    void Start()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Asteroid") && !isDestroyed)
        {
           foreach (var renderer in GetComponentsInChildren<Renderer>())
           {
              renderer.enabled = false;
           }
           foreach (var collider in GetComponents<Collider2D>())
           {
              collider.enabled = false;
           }
        }   
    }
    IEnumerator ShowGameOverMenu(float delay)
    {
        yield return new WaitForSeconds(delay);
        if (gameOverUI != null)
        {
            gameOverUI.SetActive(true);
        }
    }
}
