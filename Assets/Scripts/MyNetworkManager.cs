using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
public class MyNetworkManager : NetworkManager
{
    public override void OnStartServer()
    {
        Debug.Log("server started");

    }
    public override void OnStopServer()
    {
        Debug.Log("server sstopped");

    }
    public override void OnClientConnect(NetworkConnection conn)
    {
        Debug.Log("Connected to server!");

    }
    public override void OnClientDisconnect(NetworkConnection conn)
    {
        Debug.Log("Disconected from server!");
    }
}
