using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    
    [SerializeField] private float fuerzaMovimiento;
    [SerializeField] private float velocidadMaxima;
    [SerializeField] private float fuerzaSalto;
    
    private bool isGrounded;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && (isGrounded = true))
        {
            rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
        }
    }
    
    
    private void FixedUpdate()
    {
        float hInput = Input.GetAxisRaw("Horizontal"); 
        float vInput = Input.GetAxisRaw("Vertical");
        
        Vector3 movementDirection  = new Vector3 (hInput, 0f, vInput).normalized;
        
        rb.AddForce(movementDirection * fuerzaMovimiento, ForceMode.Force);
        
    }
    
    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
           isGrounded = true; 
        }
    }
    
}
