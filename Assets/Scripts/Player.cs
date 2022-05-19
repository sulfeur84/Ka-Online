using System.Collections.Generic;
using Mirror;

    public class Player : NetworkBehaviour
    {
        public static readonly HashSet<string> playerNames = new HashSet<string>();
        
        
        public string playerName;

        // RuntimeInitializeOnLoadMethod -> fast playmode without domain reload
        [UnityEngine.RuntimeInitializeOnLoadMethod]
        static void ResetStatics()
        {
            playerNames.Clear();
        }

        public override void OnStartServer()
        {
            playerName = (string)connectionToClient.authenticationData;
        }
    }
