﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnManager1 : MonoBehaviour
{
    private string respawnMemory;

    [SerializeField]
    private GameObject player;

    // 맨 처음 Scene 시작 지점을 transform으로 하는 empty object를 만들어주세요.
    // 0번 index에는 처음 시작 지점 object를 넣어주시고, 그 뒤 index에는 선택지를 순서대로 넣어주세요.
    [SerializeField]
    private GameObject[] respawnSpots;

    private void Start()
    {
        respawnMemory = "scene1";       
    }

    public void SetRespawnMemory(string name)
    {
        respawnMemory = name;
    }

    // Scene 이름(scene + 챕터 숫자)과 선택지의 이름을 위에 넣어둔 index 순서에 맞추어 바꿔주세요.
    public void Respawn()
    {
        if (respawnMemory == "scene1")
        {
            player.transform.position = respawnSpots[0].transform.position;
        }
        else if (respawnMemory == "memory1-1")
        {
            player.transform.position = respawnSpots[1].transform.position;
  
            Debug.Log("1-1");
        }
        else if (respawnMemory == "memory1-2")
        {
            player.transform.position = respawnSpots[2].transform.position;
   
            Debug.Log("1-2");
        }
        else if (respawnMemory == "memory16-1")
        {
            player.transform.position = respawnSpots[3].transform.position;

            Debug.Log("2-1");
        }
        else if (respawnMemory == "memory16-2")
        {
            player.transform.position = respawnSpots[4].transform.position;

            Debug.Log("2-2");
        }
    }
}
