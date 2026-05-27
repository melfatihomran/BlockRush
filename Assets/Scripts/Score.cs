using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class Score : MonoBehaviour
{
 
    public Transform player;
    public Text score_Text;
    void Update()
    {

           score_Text.text = player.position.z.ToString("0")  ;
    
    
    }
}
