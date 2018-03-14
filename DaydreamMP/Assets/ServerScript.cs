using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyWiFi;
using EasyWiFi.ServerBackchannels;
using EasyWiFi.Core;
using EasyWiFi.ServerControls;

public class ServerScript : MonoBehaviour {

    public Transform player;
    public Transform player2;
    public FloatServerBackchannel fsbX;
    public FloatServerBackchannel fsbZ;

    // Use this for initialization
    void Start () {
        player2 = Instantiate(player).transform;
	}
	
	// Update is called once per frame
	void Update () {
        fsbX.setValue(player.position.x);
        fsbZ.setValue(player.position.y);
    }

    public void UpdateClientPosX(FloatBackchannelType data) {
        Debug.Log(data.FLOAT_VALUE);
        var pos = player2.position;
        pos.x = data.FLOAT_VALUE;
        player2.position = pos;
    }

    public void UpdateClientPosZ(FloatBackchannelType data) {
        var pos = player2.position;
        pos.z = data.FLOAT_VALUE;
        player2.position = pos;
    }

}
