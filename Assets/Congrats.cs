using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Congrats : MonoBehaviour
{
    public AudioSource source;
    public AudioClip hugeSuccess;
    private void Start()
    {
        source.clip = hugeSuccess;
        source.Play();
    }
    public void nextLevelButton()
    {
        SceneManager.LoadScene("Scene1");
    }
}
