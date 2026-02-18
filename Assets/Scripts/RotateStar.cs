using System.Net.Mime;
using UnityEngine;
using UnityEngine.InputSystem;

public class RotateStar : MonoBehaviour
{
    float angle;
    bool isRotatingLeft;
    public void OnPress(InputAction.CallbackContext context)
    {

        if (context.performed)
        {
            isRotatingLeft = true;
        }

        if (context.canceled)
        {
            isRotatingLeft = false;
        }
    }

    void Update()
    {
        // Apply the rotation around the Z-axis (for 2D rotation)
        if (isRotatingLeft)
        {
            angle--;
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
        }


    }
}
