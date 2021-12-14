using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaManager : MonoBehaviour
{
    int stamina=100;
    int staminaMax=100;
    int staminaMin=0;
    public float span = 1f;
    private float currentTime = 0f;
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider.value=stamina;
    }

    // Update is called once per frame
    void Update()
    {
        
        currentTime += Time.deltaTime;
        if(currentTime > span){
            Debug.LogFormat ("{0}秒経過", span);
            currentTime = 0f;
            stamina-=10;
            stamina=Mathf.Clamp(stamina, staminaMin, staminaMax);
        }
        slider.value=stamina;
    }
    public int GetStamina(){
        return stamina;
    }
    public void SetStamina(int num){
        stamina=num;
        stamina=Mathf.Clamp(stamina, staminaMin, staminaMax);
    }
}
