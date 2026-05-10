using UnityEngine;

public class DayNightToggle : MonoBehaviour
{
    public Material daySkybox;
    public Material nightSkybox;

    public Light sunLight;

    private bool isNight = false;

    void Update()
    {
        // Left mouse click
        if (Input.GetMouseButtonDown(0))
        {
            ToggleDayNight();
            Debug.Log("Mouse Clicked");
        }
    }

    void ToggleDayNight()
    {
        if (isNight)
        {
            // Change to Day
            RenderSettings.skybox = daySkybox;

            sunLight.intensity = 1.2f;
            sunLight.color = Color.white;

            RenderSettings.ambientLight = Color.white;

            isNight = false;
        }
        else
        {
            // Change to Night
            RenderSettings.skybox = nightSkybox;

            sunLight.intensity = 0.2f;
            sunLight.color = new Color(0.6f, 0.6f, 1f);

            RenderSettings.ambientLight = new Color(0.2f, 0.2f, 0.35f);

            isNight = true;
        }

        // Update lighting
        DynamicGI.UpdateEnvironment();
    }
}