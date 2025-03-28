using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private float startTime;
    
    [SerializeField] private float timeLeft;

    private void Start()
    {
        timeLeft = startTime;
    }

    private void FixedUpdate() 
    {
        timeLeft -= 1f;
    }
}
