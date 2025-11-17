using System.Collections;
using UnityEngine;
using System.Collections.Generic;

public class NPCDialogue : MonoBehaviour
{
    bool player_detection = false;
 
   
    // Update is called once per frame
    void Update()
    {

        if (player_detection && Input.GetKeyDown(KeyCode.E))
        {
            print("ELLLO THERE MATE");
        } 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "PlayerBody")
        {
            player_detection = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        player_detection = false;
    }
}