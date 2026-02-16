using UnityEngine;
using UnityEngine.InputSystem;
public class DragDrop : MonoBehaviour
{
    Vector3 MousePos;

    private Vector3 GetMousePos()
    {
        return Camera.main.WorldToScreenPoint(MousePos);
    }

    public void OnLeftButton ()
    {
        MousePos = Input.mousePosition - GetMousePos();
        Debug.Log(MousePos);    
    }

    private void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - MousePos);
    }
}
