using UnityEngine;

public class BallJump : MonoBehaviour
{
    public float jumpPower;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = Vector3.up * jumpPower;
        }
    }
}
