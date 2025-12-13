using System;
using UnityEngine;

public class ghostFloor : MonoBehaviour
{
    [SerializeField] private float timeBeforeGhost;
    [SerializeField] private float reaparitionTime;
    private float timer;
    private bool timerGoing;

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

        if (timer >= timeBeforeGhost && gameObject.activeSelf)
        {
            gameObject.SetActive(false);
            timerGoing = false;
            timer = 0;
        }

        if (!gameObject.activeSelf)
        {
            timer += Time.deltaTime;
        }
        
        if (timer >= reaparitionTime && !gameObject.activeSelf)
        {
            gameObject.SetActive(true);
            timerGoing = false;
            timer = 0;
        }
    }

}
