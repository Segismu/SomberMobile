using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPongObstacles : MonoBehaviour
{
    [SerializeField] Vector3 startingPosition;
    [SerializeField] Vector3 endPosition;
    [SerializeField] [Range (0,1)] float speed;
    float time = 0f;

    void Update()
    {
        Move();
    }

    private void Move()
    {
        time = time + Time.deltaTime * speed;
        var pingPong = Mathf.PingPong(time, 1);
        transform.position = Vector3.Lerp(startingPosition, endPosition, pingPong);
    }
}

