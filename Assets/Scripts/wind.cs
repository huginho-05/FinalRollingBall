using UnityEngine;

public class wind : MonoBehaviour
{
    [SerializeField] private float fuerzaViento;
    [SerializeField] private Vector3 direccion = Vector3.up;
    private void OnTriggerStay(Collider other)
    {
        Rigidbody rb = other.attachedRigidbody;
        if (rb == null) return;
        
        rb.AddForce(direccion.normalized * fuerzaViento, ForceMode.Force);
    }
}
