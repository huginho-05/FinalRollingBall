using UnityEngine;

public class torqueRotation : MonoBehaviour
{
    [SerializeField] float spinnerForceX;
    [SerializeField] float spinnerForceY;
    [SerializeField] float spinnerForceZ;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddTorque(new Vector3(spinnerForceX, spinnerForceY, spinnerForceZ), ForceMode.VelocityChange);
    }

    void Update()
    {

    }

}
