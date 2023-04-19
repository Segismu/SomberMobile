using System;
using System.Collections;
using UnityEngine;

public class IsoCharacterController : MonoBehaviour, IDataPersistence
{
    [SerializeField] float speed = 5;
    [SerializeField] float turnSpeed = 360;

    [HideInInspector] public FixedJoystick joystick;

    private Animator runAnim;
    private Rigidbody rb;

    Vector3 getInput = Vector3.zero;
    
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
        getInput = new Vector3(joystick.input.x, 0, joystick.input.y);
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
        rb.MovePosition(transform.position + getInput.normalized.magnitude * speed * Time.deltaTime * transform.forward);

        if (getInput == Vector3.zero)
        {
            runAnim.SetBool("isRunning", false);
        }
        else
        {
            runAnim.SetBool("isRunning", true);
        }
        
    }

    public void LoadData(GameData data)
    {
        this.transform.position = data.playerPosition;
    }

    public void SaveData(GameData data)
    {
        data.playerPosition = this.transform.position;
    }
}


public static class Helpers
{
    private static Matrix4x4 isoMatrix = Matrix4x4.Rotate(Quaternion.Euler(0, 45, 0));
    public static Vector3 ToIso(this Vector3 input) => isoMatrix.MultiplyPoint3x4(input);
}