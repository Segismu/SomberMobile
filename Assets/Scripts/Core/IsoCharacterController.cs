using System;
using System.Collections;
using UnityEngine;

public class IsoCharacterController : MonoBehaviour
{
    [SerializeField] public float speed = 5;
    [SerializeField] public float turnSpeed = 360;
    [SerializeField] Animator runAnim;

    Rigidbody rb;

    private Vector3 getInput;

    private void Start() 
    {
        runAnim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        GatherInput();
        Rotate();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void GatherInput()
    {
        getInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
    }

    private void Rotate()
    {
        if (getInput == Vector3.zero)
            return;

        var rot = Quaternion.LookRotation(getInput.ToIso(), Vector3.up);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, rot, turnSpeed * Time.deltaTime);
    }

    private void Move()
    {
        rb.MovePosition(transform.position + transform.forward * getInput.normalized.magnitude * speed * Time.deltaTime);

        if (getInput == Vector3.zero)
        {
            runAnim.SetBool("isRunning", false);
        }
        else
        {
            runAnim.SetBool("isRunning", true);
        }
        
    }
}

public static class Helpers
{
    private static Matrix4x4 isoMatrix = Matrix4x4.Rotate(Quaternion.Euler(0, 45, 0));
    public static Vector3 ToIso(this Vector3 input) => isoMatrix.MultiplyPoint3x4(input);
}