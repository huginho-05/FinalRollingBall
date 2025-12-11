using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private Color newColor = Color.red;

    void Start()
    {
        GetComponent<Renderer>().material.color = newColor;
    }
}
