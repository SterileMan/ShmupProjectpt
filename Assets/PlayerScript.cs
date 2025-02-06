using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class ExampleClass : MonoBehaviour
{
    public float speed = 0.5F;
    public float rotateSpeed = -0.5F;
    public Crosshair crosshair;
    public Camera MainCam;
    

    private void DoPlayerRotation()
    {
        if (Camera.main)
        {
            transform.rotation = Quaternion.LookRotation(Vector3.forward,
                    Camera.main.ScreenToWorldPoint(crosshair.transform.position) - transform.position);
        }
    }

    private void Start()
    {
        MainCam = Camera.main;
    }
    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();

        
        DoPlayerRotation();

        // Move forward / backward
        Vector2 right = transform.TransformDirection(Vector2.right);
        float rurSpeed = speed * Input.GetAxis("Horizontal");
        controller.Move(right * rurSpeed);

        // Move forward / backward
        Vector3 forward = transform.TransformDirection(Vector2.up);
        float curSpeed = speed * Input.GetAxis("Vertical");
        controller.Move(forward * curSpeed);
    }
}