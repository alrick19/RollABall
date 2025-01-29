using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    public UnityEvent<Vector3> OnMove = new UnityEvent<Vector3>();
    public UnityEvent OnJump = new UnityEvent();
    // Update is called once per frame
    void Update()
    {
        Vector3 inputVector = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
        // inputVector += Vector2.up;
        inputVector += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
        // inputVector += Vector2.down;
        inputVector -= Vector3.forward;
        }
        if (Input.GetKey(KeyCode.A))
        {
        inputVector -= Vector3.right;
        }
        if (Input.GetKey(KeyCode.D))
        {
        inputVector += Vector3.right;
        }
        
        OnMove?.Invoke(inputVector);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnJump?.Invoke();
        }
    }
}
