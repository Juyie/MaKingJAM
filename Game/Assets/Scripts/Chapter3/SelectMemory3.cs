using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// 선택한 선택지를 변수에 저장하는 스크립트입니다.
public class SelectMemory3 : MonoBehaviour
{
    // RespawnManager를 각 폴더에 새로 만든 스크립트 이름으로 바꾸어주세요. 예를들면 RespawnManager1 이런식 입니다.
    [SerializeField]
    private RespawnManager3 respawnManager;

    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip clip;

    [SerializeField]
    private GameObject UsedEffectAudio;

    // Start is called before the first frame update
    void Start()
    {
        UsedEffectAudio = GameObject.Find("EffectAudio2");
        StartCoroutine(DestroyAS());
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
            Management.E = 1;
        }
        else if (gameObject.name == "memory1-2")
        {
            PlayerPrefs.SetString("memory1", "memory1-2");
            respawnManager.SetRespawnMemory("memory1-2");
            Management.E = 2;
        }
        else if (gameObject.name == "memory2-1")
        {
            PlayerPrefs.SetString("memory2", "memory2-1");
            respawnManager.SetRespawnMemory("memory2-1");
            Management.F = 1;
        }
        else if (gameObject.name == "memory2-2")
        {
            PlayerPrefs.SetString("memory2", "memory2-2");
            respawnManager.SetRespawnMemory("memory2-2");
            Management.F = 2;
        }
        else if (gameObject.name == "item11")
        {
            respawnManager.SetRespawnMemory("item11");
        }
        else if (gameObject.name == "item24")
        {
            respawnManager.SetRespawnMemory("item24");
        }
        else if (gameObject.name == "(30)") // 스테이지 끝에 있는 아이템
        {
            if (Management.staff == 3)
            {
                Management.cat = 3; // 0 대신 스테이지 번호
            }
            else
            {
                Management.staff = 3; // 0 대신 스테이지 번호
            }
            // using UnityEngine.SceneManagement 추가하고
            StartCoroutine(Wait());
        }
    }

    IEnumerator Wait()
    {
        Debug.Log(Management.staff);
        Debug.Log(Management.cat);

        yield return new WaitForSeconds(3f);
        audioSource.clip = clip;
        audioSource.Play();
        DontDestroyOnLoad(audioSource);
        if (Management.cat == 3)
        {
            SceneManager.LoadScene("EndingScene");
        }
        else
        {
            SceneManager.LoadScene("Chapter1");
        }
    }

    IEnumerator DestroyAS()
    {
        yield return new WaitForSeconds(3f);
        Destroy(UsedEffectAudio);
    }
}
