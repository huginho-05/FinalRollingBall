using UnityEngine;

public class rotation : MonoBehaviour
{
    [SerializeField] float spinnerSpeed_X;
    [SerializeField] float spinnerSpeed_Y;
    [SerializeField] float spinnerSpeed_Z;
    
    
    void Update()
    {
        transform.Rotate(spinnerSpeed_X, spinnerSpeed_Y,spinnerSpeed_Z);
    }
}
