using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Gamemanager : MonoBehaviour
{
    public static Gamemanager Instance;
    public bool GameStarted;
    int score = 0;
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
       
        Debug.Log("tt");

    }
       

    // Update is called once per frame
    void Update()
    {
        if(!GameStarted)
        {
            if(Input.GetMouseButtonDown(0))
            {
                GameStart();
            }
        }
    }
    public void GameStart()
    {
        GameStarted = true;
        StartCoroutine(updatescore());
    }
   
    
    
    IEnumerator updatescore()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.1f);
            score++;
            print(score);
        }
    }
    
}
