using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComFollow : MonoBehaviour
{
    public Transform Player;
    private Vector3 Offset;

    // Use this for initialization
    void Start()
    {
        Offset = transform.position - Player.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Playerpos = Player.position + Offset;
        transform.position = Vector3.Slerp(transform.position, Playerpos, Time.deltaTime * 5f);
    }
}

