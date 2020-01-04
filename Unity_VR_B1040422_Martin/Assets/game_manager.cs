using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class game_manager : MonoBehaviour
{
    public Transform spawnpoint;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void gameover()
    {
        player.transform.position = spawnpoint.transform.position;
    }

    public void restart()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void minigame()
    {
        SceneManager.LoadScene("matrix");
    }
}
