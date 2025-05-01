using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    [SerializeField] int score;
    [SerializeField] TextMeshProUGUI pointText;

    public void IncreaseScore()
    {
        score = score + 1;
        pointText.text = "Points: " + score;
    }






}
