using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectMemory1 : MonoBehaviour
{
    [SerializeField]
    private RespawnManager1 respawnManager;

    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip clip;

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
            Management.A = 1;
            Debug.Log(Management.A);
            Debug.Log("memory1-1");
        }
        else if (gameObject.name == "memory1-2")
        {
            PlayerPrefs.SetString("memory1", "memory1-2");
            respawnManager.SetRespawnMemory("memory1-2");
            Management.A = 2;
            Debug.Log(Management.A);
            Debug.Log("memory1-2");
        }
        else if (gameObject.name == "memory16-1")
        {
            PlayerPrefs.SetString("memory2", "memory16-1");
            respawnManager.SetRespawnMemory("memory16-1");
            Management.B = 1;
            Debug.Log(Management.B);
            Debug.Log("memory2-1");
        }
        else if (gameObject.name == "memory16-2")
        {
            PlayerPrefs.SetString("memory2", "memory16-2");
            respawnManager.SetRespawnMemory("memory16-2");
            Management.B = 2;
            Debug.Log(Management.B);
            Debug.Log("memory2-2");
        }
        else if (gameObject.name == "item6")
        {
            respawnManager.SetRespawnMemory("item6");
        }
        else if (gameObject.name == "item21")
        {
            respawnManager.SetRespawnMemory("item21");
        }
        else if (gameObject.name == "item30") // 스테이지 끝에 있는 아이템
        {
            if (Management.staff == 3)
            {
                Management.cat = 1; // 0 대신 스테이지 번호
            }
            else
            {
                Management.staff = 1; // 0 대신 스테이지 번호
            }
            // using UnityEngine.SceneManagement 추가하고
            StartCoroutine(Wait());
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3f);
        audioSource.clip = clip;
        audioSource.Play();
        DontDestroyOnLoad(audioSource);
        SceneManager.LoadScene("Chapter2");
    }
}

