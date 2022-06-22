using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public Rigidbody rb;
    //Creating 4 different sail speeds
    [Range(0, 3)]
    public int sailSpeed = 0;

    //Limits sailSpeed between 0 and 3
    private void LateUpdate()
    {
        if (sailSpeed > 3)
        {
            sailSpeed = 3;
        }
        if (sailSpeed < 0)
        {
            sailSpeed = 0;
        }
    }
    private void FixedUpdate()
    {
        rb.AddRelativeForce(sailSpeed * 25, 0, 0);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            sailSpeed = sailSpeed + 1;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            sailSpeed = sailSpeed - 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddRelativeTorque(0, -40, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddRelativeTorque(0, 40, 0);
        }
    }
}
