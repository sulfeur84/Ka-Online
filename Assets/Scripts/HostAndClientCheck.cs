using Mirror;
using UnityEngine;

public class HostAndClientCheck : NetworkBehaviour
{
    [SerializeField] private SpriteRenderer SpriteField;
    [SerializeField] private BoxCollider2D Collider;
    [SerializeField] private BoxCollider2D Trigger;
    [SerializeField] private TriggerQuit TQ;

    [SerializeField] private GameObject Boite;

    [SyncVar] private bool isHost = false;

    public override void OnStartClient()
    {
        base.OnStartClient();
        
        if(isServer && isLocalPlayer)
        {
            Destroy(Boite);
            Destroy(TQ);
            isHost = true;
        }
        else if(isClientOnly && isLocalPlayer)
        {
            Destroy(Collider);
            Destroy(Trigger);
            Destroy(SpriteField);
        }
        else if(!isLocalPlayer && isHost)
        {
            Destroy(Boite);
            Destroy(TQ);
        }
        else if(!isLocalPlayer && !isHost)
        {
            Destroy(Trigger);
            Destroy(Collider);
            Destroy(SpriteField);
        }
    }
}
