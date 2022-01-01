using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 선택한 선택지를 변수에 저장하는 스크립트입니다.
public class SelectMemory : MonoBehaviour
{
    // RespawnManager를 각 폴더에 새로 만든 스크립트 이름으로 바꾸어주세요. 예를들면 RespawnManager1 이런식 입니다.
    [SerializeField]
    private RespawnManager respawnManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // PlayerPrefs 첫번째 parameter에는 memory + 선택지 숫자(몇 번째 선택지인지)
    // 두번째 parameter에는 선택한 memory 이름을 넣어주세요.
    // 해당 챕터의 선택지 수 만큼 else if문을 복사해서 쓰시면 됩니다.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.name == "memory1-1")
        {
            PlayerPrefs.SetString("memory1", "memory1-1");
            respawnManager.SetRespawnMemory("memory1-1");
        }
        else if (gameObject.name == "memory1-2")
        {
            PlayerPrefs.SetString("memory1", "memory1-2");
            respawnManager.SetRespawnMemory("memory1-2");
        }
        else if (gameObject.name == "memory2-1")
        {
            PlayerPrefs.SetString("memory2", "memory2-1");
            respawnManager.SetRespawnMemory("memory2-1");
        }
    }
}
