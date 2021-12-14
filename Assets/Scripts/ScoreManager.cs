using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score=10;
    public int number=1;
    public int GetScore(){
        return score;
    }
    public void SetScore(int newScore){
        score=newScore;
    }
    public int GetNumber(){
        return number;
    }
    public void NextNumber(){
        number+=1;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
