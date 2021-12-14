using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaManager : MonoBehaviour
{
    int stamina=0;
    int staminaMax=100;
    int staminaMin=0;
    public float span = 1f;
    private float currentTime = 0f;
    public Slider slider;
    public GameObject panel;
    public GameObject player;
    public byte panelAlph=0;
    public Image panelImage;
    QueryChan.QueryFlyingController Qcontroller;
    // Start is called before the first frame update
    void Start()
    {
        panelImage =panel.GetComponent<Image>();
        slider.value=stamina;
        player=GameObject.Find("Query-ChanHalloween");
        Qcontroller = player.GetComponent<QueryChan.QueryFlyingController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if(currentTime > span){
            currentTime = 0f;
            if(!Qcontroller.IsAcceleration()){
                stamina+=(int)Qcontroller.GetSpeed();
            }
        }
        stamina=Mathf.Clamp(stamina, staminaMin, staminaMax);
        panelAlph=System.Convert.ToByte(255*(stamina/slider.maxValue));
        Debug.Log(panelImage);
        panelImage.color=new Color32(0,0,0,panelAlph);
        slider.value=stamina;
    }
    public int GetStamina(){
        return stamina;
    }
    public void SetStamina(int num){
        stamina=num;
        stamina=
        Mathf.Clamp(stamina, staminaMin, staminaMax);
    }
    public Color GetColor(){
        return panelImage.color;
    }
}
