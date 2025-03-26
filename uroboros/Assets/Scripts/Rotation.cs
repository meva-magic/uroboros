using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float turnSpeed;

    private float direction;

    private void FixedUpdate()
    {
        direction = Input.GetAxisRaw("Horizontal") * -1;

        transform.Rotate(Vector3.forward * turnSpeed * direction * Time.deltaTime);
    }
}
