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

    // Update is called once per frame
    void Update()
    {
        

        // Vector3 inputXZPlane = new Vector3(inputVector.x, 0, inputVector.y);
        // sphereRigidbody.AddForce(inputXZPlane * ballSpeed);


        // Debug.Log("Resultant Vector: " + inputVector);
        // Debug.Log("Resultant 3D Vector " + inputXZPlane  * ballSpeed);
    }
}
