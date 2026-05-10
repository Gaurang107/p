using UnityEngine;
using TMPro;

public class BounceController : MonoBehaviour
{
    public float stopTime = 10f;
    public float dampingRate = 0.98f;

    public TextMeshProUGUI timerText;

    private Rigidbody rb;
    private float remainingTime;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        // Initial bounce velocity
        rb.linearVelocity = new Vector3(0, 8f, 0);

        remainingTime = stopTime;
    }

    void Update()
    {
        // Countdown timer
        remainingTime -= Time.deltaTime;

        // Update timer text
        timerText.text = "Time Left: " + remainingTime.ToString("F1") + "s";

        // Gradually reduce bounce
        if (rb.linearVelocity.y > 0)
        {
            rb.linearVelocity = new Vector3(
                rb.linearVelocity.x,
                rb.linearVelocity.y * dampingRate,
                rb.linearVelocity.z
            );
        }

        // Stop bouncing
        if (remainingTime <= 0)
        {
            timerText.text = "Stopped!";

            rb.linearVelocity = Vector3.zero;
            rb.isKinematic = true;
        }
    }
}