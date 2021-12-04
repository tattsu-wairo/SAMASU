using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkManager : MonoBehaviour
{
    int number=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject playername = GameObject.Find("Query-ChanHalloween");
        ScoreManager score=playername.GetComponent<ScoreManager>();
        int newScore=score.GetScore()+100;
        score.SetScore(newScore);
        transform.gameObject.SetActive(false);
    }
}
