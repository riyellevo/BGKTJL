﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySc : MonoBehaviour
{



    // Use this for initialization
    void Start()
    {

        StartCoroutine("Move");
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.right * 3f * Time.deltaTime);
    }

    IEnumerator Move()
    {


        while (true)
        {
            yield return new WaitForSeconds(2.8f);
            transform.eulerAngles += new Vector3(0, 180f, 0);
        }
    }
}