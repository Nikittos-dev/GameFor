using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MoveSpeed = 16.0f;
    public float gravity = -9.8f;
    private CharacterController _charController;   

   [SerializeField] private Joystick joystick;

    public enum ControlType
    {
        PC,
        Android
    }
    public ControlType TypeOfControl = ControlType.PC;
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.freezeRotation = true;
        }
        _charController = GetComponent<CharacterController>();
    }
    void Update()
    {
        //Пк
        if (TypeOfControl == ControlType.PC)
        {
           

            float deltaX = Input.GetAxis("Horizontal") * MoveSpeed;
            float deltaZ = Input.GetAxis("Vertical") * MoveSpeed;

            Vector3 movement = new Vector3(deltaX, 0, deltaZ);
            movement = Vector3.ClampMagnitude(movement, MoveSpeed);

            movement.y = gravity;


            movement *= Time.deltaTime;
            movement = transform.TransformDirection(movement);
            _charController.Move(movement);
        }
        //Джойстик
        else if (TypeOfControl == ControlType.Android)
        {
            float deltaX = joystick.Horizontal * MoveSpeed;
            float deltaZ = joystick.Vertical * MoveSpeed;

            Vector3 moveInput = new Vector3(deltaX, 0, deltaZ);
            moveInput = Vector3.ClampMagnitude(moveInput, MoveSpeed);
            moveInput *= Time.deltaTime;
            _charController.Move(moveInput);
        }

    }
}
