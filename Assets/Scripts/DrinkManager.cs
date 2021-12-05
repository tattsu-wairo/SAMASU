using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkManager : MonoBehaviour
{
    [SerializeField]public AudioClip sound_drink;
    AudioSource audioSource;
    int drink_score=50;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        audioSource.PlayOneShot(sound_drink);
        GameObject playername = GameObject.Find("Query-ChanHalloween");
        ScoreManager score=playername.GetComponent<ScoreManager>();
        int newScore=score.GetScore()+drink_score;
        score.SetScore(newScore);
        transform.gameObject.SetActive(false);
        Debug.Log(score.GetScore());
    }
}
