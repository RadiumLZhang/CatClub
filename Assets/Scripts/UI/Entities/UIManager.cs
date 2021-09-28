using System.Collections;
using System.Collections.Generic;
using Logic;
using Logic.Event;
using UnityEngine;
using UnityEngine.UI;

public class UIManager: BaseModel<UIManager>
{
    //Images
    public GameObject darkBackgroundImage;

    //Panels
    public GameObject panelCouncil;
    public GameObject panelSettings;
    public GameObject panelEventExe;
    public GameObject panelResources;
    public GameObject panelStartEventDialog;
    
    //Scrolls
    public GameObject scrollSpecialEvent;

    //Buttons
    public GameObject buttonOpenExePanel;
    public GameObject buttonCloseExePanel;
    public GameObject buttonCouncil;
    public GameObject buttonCouncilCatManage;
    
    //NPCs
    public Dictionary<long, GameObject> NPCEventCycles;

    //StartEventDialog
    public Transform textEventName;
    public Transform textEventDescription;
    public Transform imageEvent;
    public Transform textResultPreview;
    
    public GameObject imageTarget;
    public GameObject imageParticipant;
    public GameObject imageParticipantCenter;
    public void SwitchDarkBackGround(bool bIsSwitchToDark)
    {
        // darkBackgroundImage.SetActive(bIsSwitchToDark);
    }

    public void InitStartEventDialogUI()
    {
        textEventName = panelStartEventDialog.transform.Find("TextEventName");
        textEventDescription = panelStartEventDialog.transform.Find("TextEventDescription");
        imageEvent = panelStartEventDialog.transform.Find("ImageEvent");
        textResultPreview = panelStartEventDialog.transform.Find("ImageResultPreview").Find("TextResultPreview");
        
        imageTarget = panelStartEventDialog.transform.Find("ImageTarget").gameObject;
        imageParticipant = panelStartEventDialog.transform.Find("ImageParticipant").gameObject;
        imageParticipantCenter = panelStartEventDialog.transform.Find("ImageParticipantCenter").gameObject;
    }
    public void InitStartEventDialog(CatEvent m_myCatEventInfo)
    {
        panelStartEventDialog.SetActive(true);
        textEventName.GetComponent<Text>().text = m_myCatEventInfo.Name;
        textEventDescription.GetComponent<Text>().text = m_myCatEventInfo.Name;//TODO:读事件描述，然后替换这个.Name
        imageEvent.GetComponent<Image>().sprite = Resources.Load<Sprite>(m_myCatEventInfo.Imageout);//TODO:这个字段策划还没配！！
        textResultPreview.GetComponent<Text>().text = m_myCatEventInfo.Name;//TODO:读事件结果，然后替换这个.Name
        if (m_myCatEventInfo.HumanId == 0)
        {
            imageParticipantCenter.GetComponent<Image>().sprite = Resources.Load<Sprite>("hahaha");//TODO：换成拖进猫栏对应的猫的头像图片，@muidarzhang
            imageTarget.SetActive(false);
            imageParticipant.SetActive(false);
            imageParticipantCenter.SetActive(true);
        }
        else
        {
            imageParticipant.GetComponent<Image>().sprite = Resources.Load<Sprite>("hahaha");//TODO：换成拖进猫栏对应的猫的头像图片，@muidarzhang
            imageTarget.GetComponent<Image>().sprite = Resources.Load<Sprite>("hahaha");//TODO：绑定的人类单头像的路径，需要读人物表，@xinqizhou，人物id是m_myCatEventInfo.HumanId
            imageTarget.SetActive(true);
            imageParticipant.SetActive(true);
            imageParticipantCenter.SetActive(false);
        }
    }
}
