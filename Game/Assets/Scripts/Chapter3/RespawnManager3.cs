using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 부활할 때 알맞은 지점에서 부활하도록 하는 스크립트입니다.
// 복사해서 각 스테이지 번호 붙여서 사용하세요!
public class RespawnManager3 : MonoBehaviour
{
    private string respawnMemory;
    private Color color;

    [SerializeField]
    private GameObject player;

    [SerializeField]
    private GameObject cat;

    // 맨 처음 Scene 시작 지점을 transform으로 하는 empty object를 만들어주세요.
    // 0번 index에는 처음 시작 지점 object를 넣어주시고, 그 뒤 index에는 선택지를 순서대로 넣어주세요.
    [SerializeField]
    private GameObject[] respawnSpots;

    void Start()
    {
        respawnMemory = "scene3";
        if (Management.staff == 3)
        {
            player = cat;
        }
        color = player.GetComponent<SpriteRenderer>().color;
    }

    public void SetRespawnMemory(string name)
    {
        respawnMemory = name;
    }

    // Scene 이름(scene + 챕터 숫자)과 선택지의 이름을 위에 넣어둔 index 순서에 맞추어 바꿔주세요.
    public void Respawn()
    {
        if (respawnMemory == "scene3")
        {
            player.transform.position = respawnSpots[0].transform.position;
        }
        else if (respawnMemory == "memory1-1")
        {
            player.transform.position = respawnSpots[1].transform.position;
        }
        else if (respawnMemory == "memory1-2")
        {
            player.transform.position = respawnSpots[2].transform.position;
        }
        else if (respawnMemory == "item11")
        {
            player.transform.position = respawnSpots[3].transform.position;
        }
        else if (respawnMemory == "item24")
        {
            player.transform.position = respawnSpots[4].transform.position;
        }
        else if (respawnMemory == "memory2-1")
        {
            player.transform.position = respawnSpots[5].transform.position;
        }
        else if (respawnMemory == "memory2-2")
        {
            player.transform.position = respawnSpots[6].transform.position;
        }
        StartCoroutine(Blink());
    }

    IEnumerator Blink()
    {
        player.GetComponent<SpriteRenderer>().color = new Color(color.r, color.g, color.b, 0.3f);
        yield return new WaitForSeconds(0.3f);
        player.GetComponent<SpriteRenderer>().color = new Color(color.r, color.g, color.b, 0.6f);
        yield return new WaitForSeconds(0.3f);
        player.GetComponent<SpriteRenderer>().color = new Color(color.r, color.g, color.b, 0.4f);
        yield return new WaitForSeconds(0.3f);
        player.GetComponent<SpriteRenderer>().color = new Color(color.r, color.g, color.b, 0.8f);
        yield return new WaitForSeconds(0.3f);
        player.GetComponent<SpriteRenderer>().color = new Color(color.r, color.g, color.b, 0.7f);
        yield return new WaitForSeconds(0.3f);
        player.GetComponent<SpriteRenderer>().color = new Color(color.r, color.g, color.b, 1.0f);
        yield return new WaitForSeconds(0.3f);
    }

}
