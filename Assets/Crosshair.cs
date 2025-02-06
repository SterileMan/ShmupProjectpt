using UnityEngine.InputSystem;
using UnityEngine;

public class Crosshair : MonoBehaviour
{
    private void Start()
    {
        Cursor.visible = false;
    }

    private void Update()
    {
        if (Camera.main)
        {
            var mousePos = Mouse.current.position.ReadValue();
            transform.position = new Vector3(mousePos.x, mousePos.y, 0);
        }
    }
}