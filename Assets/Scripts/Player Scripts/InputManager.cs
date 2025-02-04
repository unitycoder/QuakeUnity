using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    Camera cam;

    public float horizontalInputAxis;
    public float verticalInputAxis;
    public float mouseHorizontalInputAxis;
    public bool reloadDown;
    public bool switchDown;

    public Vector3 inputVector;

    public void Update()
    {
        horizontalInputAxis = Input.GetAxisRaw("Horizontal");
        verticalInputAxis = Input.GetAxisRaw("Vertical");
        reloadDown = Input.GetKeyDown(KeyCode.R);
        switchDown = Input.GetKeyDown(KeyCode.F);
        mouseHorizontalInputAxis = Input.GetAxis("Mouse X");

        //inputVector = new Vector3(horizontalInputAxis, 0, verticalInputAxis);
        inputVector = transform.right * horizontalInputAxis + transform.forward * verticalInputAxis;
        inputVector.Normalize();

    }


    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(transform.position, transform.position + inputVector);
    }
}
