using Unity.VisualScripting;
using UnityEngine;

public class BallController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private Rigidbody sphereRigidbody;
    [SerializeField] private float ballSpeed = 1.1f;
    
    public void MoveBall(Vector2 input)
    {   
        Vector3 inputXZPlane = new(input.x, 0, input.y);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);
    }
}
