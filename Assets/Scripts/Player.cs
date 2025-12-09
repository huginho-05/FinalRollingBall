using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float fuerza;
    [SerializeField] private float fuerzaSalto;
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
        }
    }
    
    
    private void FixedUpdate()
    {
        float hInput = Input.GetAxisRaw("Horizontal"); 
        float vInput = Input.GetAxisRaw("Vertical");
        
        Vector3 movementDirection  = new Vector3 (hInput, 0f, vInput).normalized;
        
        rb.AddForce(movementDirection * fuerza, ForceMode.Force);
        
    }
}
