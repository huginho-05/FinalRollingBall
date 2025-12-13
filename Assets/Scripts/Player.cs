using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    
    [SerializeField] private float movementForce;
    [SerializeField] private float maxSpeed;
    [SerializeField] private float jumpForce;
    
    private bool isGrounded;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }
    
    
    private void FixedUpdate()
    {
        float hInput = Input.GetAxisRaw("Horizontal"); 
        float vInput = Input.GetAxisRaw("Vertical");
        
        Vector3 movementDirection  = new Vector3 (hInput, 0f, vInput).normalized;
        
        rb.AddForce(movementDirection * movementForce, ForceMode.Force);
        
        if (rb.linearVelocity.magnitude > maxSpeed)
        {
            rb.linearVelocity = rb.linearVelocity.normalized * maxSpeed;
        }
        
    }
    
    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
           isGrounded = true; 
        }
    }
    
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            isGrounded = false;
        }
    }
    
}
