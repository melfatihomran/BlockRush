using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EndTrigger : MonoBehaviour
{
    public Game_MANG game_Manager;
    private void OnTriggerEnter(Collider other)
    {
        game_Manager.CompleteLevel(); 
    }
}
