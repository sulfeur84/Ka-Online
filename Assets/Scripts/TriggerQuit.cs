using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

public class TriggerQuit : NetworkBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && isLocalPlayer) NetworkManager.singleton.StopClient();
    }
}
