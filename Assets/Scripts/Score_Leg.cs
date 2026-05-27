using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class ScoreLeg : MonoBehaviour
{

    public Transform lplayer;
    public Text lscore_Text;
    void Update()
    {

        lscore_Text.text = lplayer.position.z.ToString("0");


    }
}
