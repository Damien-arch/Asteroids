using UnityEngine;

public class Explode : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            source.PlayOneShot(clip);
        }
    }
}
