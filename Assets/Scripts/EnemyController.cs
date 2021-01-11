using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    #region Player Collision
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (gameObject.CompareTag("Monster1") && collision.gameObject.CompareTag("Bullet"))
        {
            GameObject.Find("TimeCount").GetComponent<GameTime>().time += 1f;
            GameObject.Find("TimeCount").GetComponent<GameTime>().timeCount.text =
                 GameObject.Find("TimeCount").GetComponent<GameTime>().time.ToString();
            GameObject.Find("TimeCount").GetComponent<GameTime>().killCount++;
            Destroy(gameObject);
        }
        if (gameObject.CompareTag("Monster2") && collision.gameObject.CompareTag("Bullet"))
        {
            GameObject.Find("TimeCount").GetComponent<GameTime>().time += 2f;
            GameObject.Find("TimeCount").GetComponent<GameTime>().timeCount.text =
                GameObject.Find("TimeCount").GetComponent<GameTime>().time.ToString();
            GameObject.Find("TimeCount").GetComponent<GameTime>().killCount++;
            Destroy(gameObject);
        }
        if (gameObject.CompareTag("Monster3") && collision.gameObject.CompareTag("Bullet"))
        {
            GameObject.Find("TimeCount").GetComponent<GameTime>().time += 3f;
            GameObject.Find("TimeCount").GetComponent<GameTime>().timeCount.text =
                GameObject.Find("TimeCount").GetComponent<GameTime>().time.ToString();
            GameObject.Find("TimeCount").GetComponent<GameTime>().killCount++;
            Destroy(gameObject);
        }
        if (gameObject.CompareTag("Monster4") && collision.gameObject.CompareTag("Bullet"))
        {
            GameObject.Find("TimeCount").GetComponent<GameTime>().time += 4f;
            GameObject.Find("TimeCount").GetComponent<GameTime>().timeCount.text =
                GameObject.Find("TimeCount").GetComponent<GameTime>().time.ToString();
            GameObject.Find("TimeCount").GetComponent<GameTime>().killCount++;
            Destroy(gameObject);
        }
        if (gameObject.CompareTag("Monster5") && collision.gameObject.CompareTag("Bullet"))
        {
            GameObject.Find("TimeCount").GetComponent<GameTime>().time += 5f;
            GameObject.Find("TimeCount").GetComponent<GameTime>().timeCount.text =
                GameObject.Find("TimeCount").GetComponent<GameTime>().time.ToString();
            GameObject.Find("TimeCount").GetComponent<GameTime>().killCount++;
            Destroy(gameObject);
        }
        GameObject.Find("TimeCount").GetComponent<GameTime>().killCounter.text = "Kills: " +
            GameObject.Find("TimeCount").GetComponent<GameTime>().killCount.ToString();
    }

    #endregion
}
