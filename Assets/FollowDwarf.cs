using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowDwarf : MonoBehaviour
{
    public GameObject target;
    private Vector2 pos;
    public float xOffset = 0f;
    public float yOffset = 0f;

    void Start() 
    {

    }
    void Update()
    {
        pos = target.transform.position + new Vector3(xOffset, yOffset, 0f);
        transform.position = Vector2.MoveTowards(transform.position, pos, 0.1f);
        Debug.Log(target.transform.position);
    }
}
