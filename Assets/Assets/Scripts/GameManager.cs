using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class GameManager : MonoBehaviour
{
    bool alive = true;
    public GameObject deathScreen;
    public PlayableDirector director;

    private void Start()
    {
        director.Play();
        deathScreen.SetActive(false);
    }

    private void Update()
    {
        if (!alive)
        {
            setDeathScreen();
        }
    }

    private void setDeathScreen()
    {
        deathScreen.SetActive(true);

        Time.timeScale = 0.0f;
    }

    public void setDead()
    {
        alive = !alive;
    }
}
