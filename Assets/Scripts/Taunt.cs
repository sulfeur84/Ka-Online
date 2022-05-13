using Mirror;
using TMPro;
using UnityEngine;

public class Taunt : NetworkBehaviour
{
    [SerializeField] private Animator animator;
    
    public TextMeshProUGUI text;
    public Pseudo psd;
    
    [SyncVar]public string pseudal;
    private void Start()
    {
        if(!isLocalPlayer) return;

        psd = FindObjectOfType<Pseudo>();
        pseudal = psd.pseudo;
        text.text = pseudal;
    }

    private void Update()
    {
        if(!isLocalPlayer) return;
        
        if(Input.GetKey(KeyCode.A)) animator.SetBool("T1",true);
        else animator.SetBool("T1",false);
        
        if(Input.GetKey(KeyCode.E)) animator.SetBool("T2",true);
        else animator.SetBool("T2",false);
    }

}
