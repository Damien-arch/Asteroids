using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(DestroyAfterDelay(2f));
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
