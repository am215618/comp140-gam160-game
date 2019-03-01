using System;
using System.IO.Ports;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arduino : MonoBehaviour {

    public GameObject playerOne;
    public GameObject playerTwo;

    public int commPort = 0;

    private SerialPort serial;

    // Use this for initialization
	void Start () {
        serial = new SerialPort("\\\\.\\COM" + commPort, 9600); //Backslashes requied if COM Port > 10
        serial.ReadTimeout = 50;
        serial.Open();
	}
	
	// Update is called once per frame
	void Update () {
        WriteToArduino("P");
        string values = ReadFromArduino();

        if (values != null)
        {
            string[] splitValues = values.Split('-');

            if (splitValues.Length == 2)
            {
                positionPlayers(splitValues);
            }
        }
	}

    public void WriteToArduino(string msg)
    {
        serial.WriteLine(msg);
        serial.BaseStream.Flush();
    }

    string ReadFromArduino()
    {
        serial.ReadTimeout = 50;
        try
        {
            return serial.ReadLine();
        }
        catch(TimeoutException e)
        {
            return null;
        }
    }

    void positionPlayers(string[] values)
    {
        if(playerOne != null)
        {
            Vector3 newPosition = new Vector3(playerOne.transform.position.x, int.Parse(values[0])/100f, playerOne.transform.position.z);

            playerOne.transform.position = newPosition;
        }
        if (playerTwo != null)
        {
            Vector3 newPosition = new Vector3(playerTwo.transform.position.x, int.Parse(values[1])/100f, playerTwo.transform.position.z);

            playerTwo.transform.position = newPosition;
        }
    }

    private void OnDestroy()
    {
        serial.Close();
    }

    float Remap(float value, float from1, float to1, float from2, float to2)
    {
        return (value - from1) / (to1 - from1) * (to2 - from2) + from2;
    }
}
