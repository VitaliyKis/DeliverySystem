using UnityEngine;

public class CubeControllerScript : MonoBehaviour
{
    Rigidbody rb;
    float horizontal;
    float vertical;
    [SerializeField]float speed;



    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    private void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

    }
    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector3 (horizontal, 0, vertical)* speed;
    }
}
