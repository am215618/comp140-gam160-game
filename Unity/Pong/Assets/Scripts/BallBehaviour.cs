using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour {

    [SerializeField]
    float forceValue = 4.5f;

    Rigidbody rb;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        StartCoroutine(ExectuteAfterTime(1));
    }


    public void ResetBall()
    {
        rb.velocity = Vector3.zero;
        transform.position = Vector3.zero;
    }

    public void RestartGame()
    {
        ResetBall();
        Invoke("GoBall", 1);
    }

    IEnumerator ExectuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        rb.AddForce(new Vector3(forceValue * 50, 50, 0));
    }
}
