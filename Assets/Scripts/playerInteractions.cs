using UnityEngine;
using UnityEngine.SceneManagement;

public class playerInteractions : MonoBehaviour
{
    private Vector3 initialPosition;

    [SerializeField] private Vector3 spawnPosition;
    
    void Start()
    {
        this.gameObject.transform.position = spawnPosition;
        initialPosition = transform.position; 
    }

    private void OnTriggerEnter(Collider other)
    {
        //Si eres atravesado por una trampa, vuelves a la posicion inicial
        if (other.gameObject.CompareTag("Trap"))
        {
            transform.position = initialPosition;
        }
        
        if (other.gameObject.CompareTag("FinalTrigger"))
        {
            SceneManager.LoadSceneAsync(2);
        }
    }

    
}
