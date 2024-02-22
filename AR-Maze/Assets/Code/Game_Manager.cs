using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    public static Game_Manager instance { get; private set; } = null;

    public GameObject player {  get; private set; }

    public GameObject[] checkPoint;

    private int currentCheckPointIndex = 0;
    private int points = 0;

    private void Awake()
    {
        if (instance != null) 
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
    }

    public void Reset_Player_Position ()
    {
        player.transform.position = checkPoint[currentCheckPointIndex].transform.position;
        player.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }

    public void CheckPoint_Reach() 
    {
        currentCheckPointIndex++;
    }

    public void Register(GameObject gameObject) 
    {
        player = gameObject;
    }

    public void Increase_Score()
    {
        points++;
        UI_Manager.instance.Update_Score(points);
    }
}
