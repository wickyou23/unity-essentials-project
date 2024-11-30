using Unity.VisualScripting;
using UnityEngine;

public class PlayerControllerScript : MonoBehaviour
{
    public float speed = 5.0f;
    public float rotationSpeed = 120.0f;

    private Rigidbody rb;

    public float jumpForce = 5.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
        }
    }

    private void FixedUpdate()
    {
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = transform.forward * moveVertical * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + movement);

        float turn = Input.GetAxis("Horizontal") * rotationSpeed * Time.fixedDeltaTime;
        Quaternion turnRotation = Quaternion.Euler(0.0f, turn, 0.0f);
        rb.MoveRotation(rb.rotation * turnRotation);
    }
}
