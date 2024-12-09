using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerCollision : MonoBehaviour
{
    private bool isDestroyed = false;
    void Start()
    {

    }
    

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Asteroid") && !isDestroyed)
        {
            isDestroyed = true;
            Debug.Log("Player hit! restarting...");

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
    IEnumerator RestartGameAfterSound(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }
}
