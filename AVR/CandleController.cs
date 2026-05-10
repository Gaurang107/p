using UnityEngine;

public class CandleController : MonoBehaviour
{
    public GameObject flame;
    public GameObject smoke;
    public Light candleLight;

    bool isLit = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ToggleCandle();
        }
    }

    void ToggleCandle()
    {
        isLit = !isLit;

        flame.SetActive(isLit);
        smoke.SetActive(isLit);
        candleLight.enabled = isLit;
    }
}