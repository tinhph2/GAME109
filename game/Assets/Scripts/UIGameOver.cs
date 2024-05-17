using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIGameOver : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    ScoreKeeper scoreKeeper;
    ASM_MN asm;

    void Awake()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
        asm = FindObjectOfType<ASM_MN>();
    }

    void Start()
    {
        scoreText.text = "You Scored:\n" + scoreKeeper.GetScore();
        asm = new ASM_MN();
        asm.YC1();
       // ASM_MN.YC2();
        //ASM_MN.YC3();
        //ASM_MN.YC4();
        //ASM_MN.YC5();
        //ASM_MN.YC6();
        //ASM_MN.YC7();
    }

    


}
