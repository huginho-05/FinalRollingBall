using System;
using UnityEngine;

public class ghostFloor : MonoBehaviour
{
    [SerializeField] private float timeBeforeGhost;
    [SerializeField] private float reaparitionTime;
    private float timer;
    private bool timerGoing;
    private BoxCollider boxCollider;
    private MeshRenderer meshRender;
    
    void Start()
    {
        boxCollider = GetComponent<BoxCollider>();
        meshRender = GetComponent<MeshRenderer>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            timerGoing = true;
            timer = 0;
        }
    }
    void Update()
    {
        if (timerGoing)
        {
            timer += Time.deltaTime;
        }

        if (timer >= timeBeforeGhost && boxCollider.enabled)
        {
            boxCollider.enabled = false;
            meshRender.enabled = false;
            timerGoing = false;
            timer = 0;
        }

        if (!boxCollider.enabled)
        {
            timer += Time.deltaTime;
        }
        
        if (timer >= reaparitionTime && !boxCollider.enabled)
        {
            boxCollider.enabled = true;
            meshRender.enabled = true;
            timerGoing = false;
            timer = 0;
        }
    }

}
