using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transit : MonoBehaviour
{
    
    [SerializeField]int number;
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
        GameObject scoreObj = GameObject.Find("Game");
        ScoreManager score=scoreObj.GetComponent<ScoreManager>();
        Debug.Log(score.GetNumber());
        if(number==score.GetNumber()){
            int newScore=score.GetScore()+100;
            score.SetScore(newScore);
            score.NextNumber();
            Debug.Log(score.GetScore());
            transform.parent.gameObject.SetActive(false);
        }
        
    }
}
