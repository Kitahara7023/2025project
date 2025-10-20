using UnityEngine;



public class JumpScript : MonoBehaviour
{
    
    public float jumpForce = 5f;
    private bool isGrounded;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (isGrounded && Input.GetMouseButtonDown(0)) // 0=左クリック
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    // 地面から離れたときにisGroundedをfalseにする
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
