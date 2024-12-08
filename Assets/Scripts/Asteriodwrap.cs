using UnityEngine;

public class Asteriodwrap : MonoBehaviour
{
    private Camera mainCamera;
    private float screenWidth;
    private float screenHeight;
    
    void Start()
    {
        mainCamera = Camera.main;
        screenHeight = mainCamera.orthographicSize;
        screenWidth = screenHeight * mainCamera.aspect;
    }

    void Update()
    {
        WrapAroundScreen();
    }
    private void WrapAroundScreen()
    {
        Vector3 position = transform.position;

        if (position.x > screenWidth)
            position.x = -screenWidth;
        else if (position.x < -screenWidth)
            position.x = screenWidth;

        if (position.y > screenHeight)
            position.y = -screenHeight;
        else if (position.y < -screenHeight)
            position.y = screenHeight;

        transform.position = position;
    }
}
