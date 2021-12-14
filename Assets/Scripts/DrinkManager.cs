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
        GameObject player = other.gameObject;
        QueryChan.QueryFlyingController Qcontroller = player.GetComponent<QueryChan.QueryFlyingController>();
        Qcontroller.StartCoroutine(Qcontroller.Acceleration());

        GameObject gameObj=GameObject.Find("Game");
        ScoreManager score=gameObj.GetComponent<ScoreManager>();
        StaminaManager stamina=gameObj.GetComponent<StaminaManager>();
        stamina.SetStamina(stamina.GetStamina()-40);
        int newScore=score.GetScore()+drink_score;
        score.SetScore(newScore);
        transform.gameObject.SetActive(false);
    }
}
