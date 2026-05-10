using UnityEngine;

public class BallKick : MonoBehaviour
{
    Rigidbody rb;

    public float slowForce = 5f;
    public float mediumForce = 10f;
    public float fastForce = 20f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Press 1 for slow kick
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            KickBall(slowForce);
        }

        // Press 2 for medium kick
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            KickBall(mediumForce);
        }

        // Press 3 for fast kick
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            KickBall(fastForce);
        }

        // Reset ball position
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetBall();
        }
    }

    void KickBall(float force)
    {
        rb.linearVelocity = Vector3.zero;
        rb.AddForce(Vector3.forward * force, ForceMode.Impulse);
    }

    void ResetBall()
    {
        transform.position = new Vector3(0, 1, 0);
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }
}