using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 아이템 근처로 가면 메시지가 나오게 하는 스크립트
public class ItemText3 : MonoBehaviour
{
    private Transform text;

    // Start is called before the first frame update
    void Start()
    {
        text = gameObject.transform.GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        text.gameObject.SetActive(true);
    }

    // 맵 크기에 따라 collider 크기와 거리 조정만 하면 됩니다.
    private void OnTriggerStay2D(Collider2D collision)
    {
        //Debug.Log(gameObject.transform.position.x - collision.transform.position.x);
        if (gameObject.transform.position.x - collision.transform.position.x > -1
            && gameObject.transform.position.x - collision.transform.position.x < 1)
        {
            text.GetComponent<TextMesh>().color = new Color32(255, 255, 255, 255); //white
        }
        else
        {
            text.GetComponent<TextMesh>().color = new Color32(255, 255, 255, 127);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        text.gameObject.SetActive(false);
    }
}
