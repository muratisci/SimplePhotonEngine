using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using Photon.Pun;

public class LobbyController : MonoBehaviourPunCallbacks
{
    private void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }
        
    public override void OnConnectedToMaster () 
    {
        Debug.Log("Connection Okey");
    }
    
}
