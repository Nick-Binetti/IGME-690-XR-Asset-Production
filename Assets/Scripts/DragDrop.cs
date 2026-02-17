    using UnityEngine;
using UnityEngine.InputSystem;
using LookingGlass;
public class DragDrop : MonoBehaviour
{
    Vector3 MousePos = Vector3.zero;
    [SerializeField] HologramCamera Holoplay;

 

    public void OnClick(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("Mouse clicked!: " + MousePos);
            //Get Mouse Coords
            MousePos = Input.mousePosition;

            //Create a ray from screen coords into world
            Ray raycast = Camera.main.ScreenPointToRay(MousePos); // doesn't work bc were not using Unity's camera 

            RaycastHit hit;
            //Check if ray hit anything
            if (Physics.Raycast(raycast, out hit))
            {
                //If so raycasthit will have object's transform
                hit.transform.position = MousePos;
                
            }


        }
    }
}
