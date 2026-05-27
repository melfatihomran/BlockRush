using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// This is the Obstacles Movement script where pl stands for player

public class NewBehaviourScript : MonoBehaviour
{
    public Player_Movement movment;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacles") {
            movment.enabled = false;
            FindObjectOfType<Game_MANG>().EndGame();
        
        }
    }
}
