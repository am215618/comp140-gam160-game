using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathBarrierRight : MonoBehaviour {

    public bool isOnTheRight;

    public Arduino arduino;

    private void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isOnTheRight)
        {
            arduino.WriteToArduino("L");
        }
        else
        {
            arduino.WriteToArduino("K");
        }
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}