using UnityEngine;

public class movingBehaviour : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
        
        [SerializeField] private float speed;
        
        [SerializeField] private Vector3 direccionInicial;
        
        [SerializeField] private float timerFloor;
        
        private Vector3 direccionActual;
    
        private float timer;
        
        void Start()
        {
            direccionActual = direccionInicial;
        }
    
        // Update is called once per frame
        void Update()
        {
            timer += Time.deltaTime;
            transform.Translate(direccionActual * speed * Time.deltaTime);
            
            if (timer >= timerFloor)
            {
                direccionActual *= -1;
                timer = 0;
            }
        }
}
