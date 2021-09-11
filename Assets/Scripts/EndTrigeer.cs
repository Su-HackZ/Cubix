using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigeer : MonoBehaviour
{

    public GameManger gameManger;

    void OnTriggerEnter()
    {
        gameManger.CompleteLevel();
    }
}
