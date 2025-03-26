using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float turnSpeed = 100f;

    private float direction;

    private void FixedUpdate()
    {
        direction = 0f;

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began || touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary)
            {
                if (touch.position.x < Screen.width / 2)
                {
                    direction = 1f;
                }
                else
                {
                    direction = -1f;
                }
            }
        }

        transform.Rotate(Vector3.forward * turnSpeed * direction * Time.deltaTime);
    }
}
