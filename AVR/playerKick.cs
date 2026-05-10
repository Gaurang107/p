using UnityEngine;

public class PlayerKick : MonoBehaviour
{
    public Rigidbody ballRb;
    public Animator anim;

    public float slowForce = 5f;
    public float mediumForce = 10f;
    public float fastForce = 20f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            KickBall(slowForce);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            KickBall(mediumForce);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            KickBall(fastForce);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetBall();
        }
    }

    void KickBall(float force)
    {
        // Play kick animation
        anim.Play("Kick");

        // Reset velocity
        ballRb.linearVelocity = Vector3.zero;

        // Apply force
        ballRb.AddForce(Vector3.forward * force, ForceMode.Impulse);
    }

    void ResetBall()
    {
        ballRb.transform.position = new Vector3(0, 0.5f, 3);

        ballRb.linearVelocity = Vector3.zero;
        ballRb.angularVelocity = Vector3.zero;
    }
}