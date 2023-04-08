using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pockey_Manager : MonoBehaviour
{
    public List<Vector3> localPos = new List<Vector3>();

    int cur_count = 0;
    int last_count = 0;
    // Start is called before the first frame update
    void Start()
    {
        cur_count = last_count = transform.childCount;
        foreach(Transform t in transform)
        {
            localPos.Add(t.localPosition);
        }
    }

    // Update is called once per frame
    void Update()
    {
        cur_count = transform.childCount;
        if(cur_count != last_count)
        {
            UpdatePos();
            cur_count = last_count;
        }
        
    }

    public void UpdatePos()
    {
        for(int i = 0; i< transform.childCount; i++)
        {
            transform.GetChild(i).localPosition = localPos[i];
        }
    }
}
