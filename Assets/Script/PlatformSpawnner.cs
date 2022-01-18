using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawnner : MonoBehaviour
{
    public GameObject platform;
    public Transform lastplatform;
    Vector3 lastpos;
    Vector3 newpos;
    bool stop;
    // Start is called before the first frame update
    void Start()
    {
        lastpos = lastplatform.position;
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
        
       //if(Input.GetKey(KeyCode.Space))
       // {
       //     Spawn();
       // }
    }
    IEnumerator Spawn()
    {
        while (!stop)
        {
            Generatepos();
            Instantiate(platform, newpos, Quaternion.identity);
            lastpos = newpos;
            yield return new WaitForSeconds(0.2f);

        }
       
    }
    //void Spawn()
    //{
    //    Generatepos();
    //    Instantiate(platform, newpos, Quaternion.identity);
    //    lastpos = newpos;

    //}
    void Generatepos()
    {
        newpos = lastpos;
        int rand = Random.Range(0, 2);
        if(rand > 0)
        {
            newpos.x += 4f;

        }
        else
        {
            newpos.z += 4f;
        }
    }
}
