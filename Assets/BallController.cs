using UnityEngine;

public class BallController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private Rigidbody sphereRigidBody;
    [SerializeField] private float ballSpeed = 1.1f;

    [SerializeField] private float jumpForce = 6f;

    private bool isGrounded;
    
    public void MoveBall(Vector3 input)
    {   
        Vector3 inputXZPlane = new(input.x, 0, input.z);
        sphereRigidBody.AddForce(inputXZPlane * ballSpeed);
    }

    public void Jump()
    {
        if (isGrounded)
        {
            sphereRigidBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        // tag Plane has been added to the Plane 3D object
        if (collision.gameObject.CompareTag("Plane"))
        {
            isGrounded = true;
        }
    }

    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Plane"))
        {
            isGrounded = false;
        }
    }
}
