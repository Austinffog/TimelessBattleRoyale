using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Enemy : MonoBehaviour
{
    #region Spawn
    public GameObject monster1, monster2, monster3, monster4, monster5;
    public float spawnLeastWait1, spawnMostWait1, spawnWait1; //monster1
    public float spawnLeastWait2, spawnMostWait2, spawnWait2; //monster2
    public float spawnLeastWait3, spawnMostWait3, spawnWait3; //monster3
    public float spawnLeastWait4, spawnMostWait4, spawnWait4; //monster4
    public float spawnLeastWait5, spawnMostWait5, spawnWait5; //monster5
    public Vector3 spawnValues;
    #endregion

    public float kill;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Monster1());
        StartCoroutine(Monster2());
        StartCoroutine(Monster3());
        StartCoroutine(Monster4());
        StartCoroutine(Monster5());
    }

    // Update is called once per frame
    void Update()
    {
        spawnWait1 = Random.Range(spawnLeastWait1, spawnMostWait1); //monster1
        spawnWait2 = Random.Range(spawnLeastWait2, spawnMostWait2); //monster2
        spawnWait3 = Random.Range(spawnLeastWait3, spawnMostWait3); //monster3
        spawnWait4 = Random.Range(spawnLeastWait4, spawnMostWait4); //monster4
        spawnWait5 = Random.Range(spawnLeastWait5, spawnMostWait5); //monster5

        kill = GameObject.Find("TimeCount").GetComponent<GameTime>().killCount;

    }

    #region Monster Spawner
    IEnumerator Monster1()
    {
        while (true)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x),
                Random.Range(-spawnValues.y, spawnValues.y), 0);
            Instantiate(monster1, spawnPosition + transform.TransformPoint(0, 0, 0), Quaternion.identity);
            yield return new WaitForSeconds(spawnWait1);
        }
    }
    IEnumerator Monster2()
    {
        while (kill < 50f) //condition to not spawn anything
        {
            yield return null;
        }
        while (kill >= 50f)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x),
                Random.Range(-spawnValues.y, spawnValues.y), 0);
            Instantiate(monster2, spawnPosition + transform.TransformPoint(0, 0, 0), Quaternion.identity);
            yield return new WaitForSeconds(spawnWait2);
        }
    }
    IEnumerator Monster3()
    {
        while (GameObject.Find("TimeCount").GetComponent<GameTime>().time > 50f)
        {
            yield return null;
        }
        while (GameObject.Find("TimeCount").GetComponent<GameTime>().time <= 50f)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x),
                Random.Range(-spawnValues.y, spawnValues.y), 0);
            Instantiate(monster3, spawnPosition + transform.TransformPoint(0, 0, 0), Quaternion.identity);
            yield return new WaitForSeconds(spawnWait3);
        }
    }
    IEnumerator Monster4()
    {
        while (kill < 150f)
        {
            yield return null;
        }
        while (kill >= 150f)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x),
                Random.Range(-spawnValues.y, spawnValues.y), 0);
            Instantiate(monster4, spawnPosition + transform.TransformPoint(0, 0, 0), Quaternion.identity);
            yield return new WaitForSeconds(spawnWait4);
        }
    }
    IEnumerator Monster5()
    {
        while (kill < 500f)
        {
            yield return null;
        }
        while (kill >= 500f)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x),
                Random.Range(-spawnValues.y, spawnValues.y), 0);
            Instantiate(monster5, spawnPosition + transform.TransformPoint(0, 0, 0), Quaternion.identity);
            yield return new WaitForSeconds(spawnWait5);
        }
    }
    #endregion

}
