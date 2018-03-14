using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyWiFi.ClientControls;
using EasyWiFi.Core;

public class ClientScript : MonoBehaviour {
    public FloatDataClientController clientPosX;
    public FloatDataClientController clientPosZ;
    public Transform player;
    public Transform player2;
    // Use this for initialization
    void Start () {
        player2 = Instantiate(player).transform;
	}
	
	// Update is called once per frame
	void Update () {
        clientPosX.setValue(0);
        clientPosZ.setValue(0);
    }

    public void UpdateServerPosX(FloatBackchannelType data )
    {
        Debug.Log(data.FLOAT_VALUE);
        player2.transform.position = new Vector3(data.FLOAT_VALUE, 
                                                player2.transform.position.y, 
                                                player2.transform.position.z);


    }

    public void UpdateServerPosZ(FloatBackchannelType data)
    {
        player2.transform.position = new Vector3(player2.transform.position.x,
                                                player2.transform.position.y,
                                                data.FLOAT_VALUE);
    }
}
