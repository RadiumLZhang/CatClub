using System;
using System.Collections;
using System.Collections.Generic;
using EventHandler;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;
using Logic;
using Logic.Event;
using Manager;
using UI.Animation;
using UnityEngine.Android;
using Random = UnityEngine.Random;

public class GameView : MonoBehaviour
{
    private GameObject panelCouncil;
    private GameObject panelSettings;
    private GameObject panelEventExe;
    private GameObject panelResources;
    
    private Text textMoney;
    private Text textInfluence;
    private Text textHidency;
    private int m_oldMoney;
    private int m_oldInfluence;
    private int m_oldHidency;
    private Animation m_moneyAnimation;
    private Animation m_influenceAnimation;
    private Animation m_hidencyAnimation;
    
    private GameObject scrollSpecialEvent;
    private GameObject scrollRelationship;
    private RectTransform contentTransform;
    private Button buttonOpenExePanel;
    private Button buttonCloseExePanel;
    private RectTransform rectExePanel;
    private RectTransform rectSpecialScroll;
    private RectTransform specialEventPrefab;
    public long currentDialogEventID;

    //左上角时间
    private Text textDate;
    private Text textTime;
    
    private Coroutine openExePanel_coroutine;
    private Coroutine closeExePanel_coroutine;
    private Coroutine openSpecialScroll_coroutine;
    private Coroutine closeSpecialScroll_coroutine;
    
    //杂项
    public GameObject DroppedImage;
    public float relationshipScale;
    public Vector2 oldRelationshipPos;
    public bool bIsRelationshipScaling;

    private List<CatEvent> m_oldSpecialEvents;
    void Start()
    {
        panelCouncil = transform.Find("PanelCouncil").gameObject;
        panelSettings = transform.Find("PanelSettings").gameObject;
        panelEventExe = transform.Find("PanelEventExe").gameObject;
        panelResources = transform.Find("PanelResources").gameObject;
        
        textMoney = panelResources.transform.Find("TextMoney").GetComponent<Text>();
        textInfluence = panelResources.transform.Find("TextInfluence").GetComponent<Text>();
        textHidency = panelResources.transform.Find("TextHidency").GetComponent<Text>();
        m_moneyAnimation = textMoney.GetComponent<Animation>();
        m_influenceAnimation = textInfluence.GetComponent<Animation>();
        m_hidencyAnimation = textHidency.GetComponent<Animation>();
        
        scrollSpecialEvent = transform.Find("ScrollSpecialEvent").gameObject;
        scrollRelationship = transform.Find("ScrollRelationship").gameObject;
        specialEventPrefab = Resources.Load<RectTransform>("Prefabs/SpecialEvent");
        
        //左上角时间
        textDate = transform.Find("ImageTime").Find("TextDate").GetComponent<Text>();
        textTime = transform.Find("ImageTime").Find("TextTime").GetComponent<Text>();
        
        buttonOpenExePanel = panelEventExe.transform.Find("ButtonOpenExePanel").GetComponent<Button>();
        buttonCloseExePanel = panelEventExe.transform.Find("ButtonCloseExePanel").GetComponent<Button>();
        rectExePanel = panelEventExe.GetComponent<RectTransform>();
        rectSpecialScroll = scrollSpecialEvent.GetComponent<RectTransform>();
        rectSpecialScroll.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Bottom,0f,0);
        contentTransform = scrollSpecialEvent.transform.Find("Viewport").Find("ContentSpecialEvent").GetComponent<RectTransform>();


        bIsRelationshipScaling = false;
        UIManagerInit();
        EventHandlerManager.Instance.InitMono(panelEventExe.transform);
    }

    private void UIManagerInit()
    {
        UIManager.Instance.gameView = transform;
        UIManager.Instance.gameViewMono = this;
        UIManager.Instance.Init();
    }

    public void ButtonSettings_OnClick()
    {
        TimeTickerManager.Instance.StopTick();
        UIManager.Instance.SwitchDarkBackGround(true);
        panelSettings.SetActive(true);
    }

    public void ButtonCloseRelationship_OnClick()
    {
        relationshipScale = 1f;
        bIsRelationshipScaling = true;
        scrollRelationship.GetComponent<NPCManager>().StartNPCLerp(oldRelationshipPos.x, oldRelationshipPos.y);
        scrollRelationship.GetComponent<ScrollRect>().enabled = true;
        if(openSpecialScroll_coroutine != null) StopCoroutine(openSpecialScroll_coroutine);
        if(closeSpecialScroll_coroutine != null) StopCoroutine(closeSpecialScroll_coroutine);
        closeSpecialScroll_coroutine = StartCoroutine(ScrollSpecialCoroutine(true));
        rectSpecialScroll.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Bottom,0f,0);
        
        //buttons
        UIManager.Instance.buttonRelationship.SetActive(true);
        UIManager.Instance.buttonCloseRelationship.SetActive(false);
    }
    public void ButtonRelationship_OnClick()
    {
        relationshipScale = 0.42f;
        bIsRelationshipScaling = true;
        oldRelationshipPos = new Vector2(UIManager.Instance.scrollRelationShip.GetComponent<ScrollRect>().horizontalNormalizedPosition,UIManager.Instance.scrollRelationShip.GetComponent<ScrollRect>().verticalNormalizedPosition);
        if (scrollRelationship.GetComponent<NPCManager>().currentOpenedNPC && scrollRelationship.GetComponent<NPCManager>().currentOpenedNPC.GetComponent<NPCMono>().eventCycle.activeSelf)
            scrollRelationship.GetComponent<NPCManager>().currentOpenedNPC.GetComponent<NPCMono>().CloseEventCycle();
        scrollRelationship.GetComponent<NPCManager>().StartNPCLerp(0.5f, 0.5f);
        scrollRelationship.GetComponent<ScrollRect>().enabled = false;
        if(openSpecialScroll_coroutine != null) StopCoroutine(openSpecialScroll_coroutine);
        if(closeSpecialScroll_coroutine != null) StopCoroutine(closeSpecialScroll_coroutine);
        openSpecialScroll_coroutine = StartCoroutine(ScrollSpecialCoroutine(false));
        rectSpecialScroll.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Bottom,-185f,0);
        
        //buttons
        UIManager.Instance.buttonCloseRelationship.SetActive(true);
        UIManager.Instance.buttonRelationship.SetActive(false);
    }
    public void ButtonCouncil_OnClick()
    {
        panelCouncil.SetActive(true);
    }
    
    public void ButtonPause_OnClick()
    {
        TimeTickerManager.Instance.StopTick();
    }
    
    public void ButtonNormal_OnClick()
    {
        TimeTickerManager.Instance.StartTick();
    }
    
    public void ButtonSpeed_OnClick()
    {
        TimeTickerManager.Instance.StartTickWithSpeed(TickerSpeedEnum.Fast);
    }
    
    //Button in Council
    public void ButtonBacktoGame_OnClick()
    {
        panelCouncil.SetActive(false);
    }

    //Buttons in Settings
    public void ButtonSaveQuit_OnClick()
    {
        SaveManager.Instance.SaveData(PlayerPrefs.GetString("userName"));
        SceneManager.LoadScene("StartMenu");
    }
    public void ButtonResume_OnClick()
    {
        TimeTickerManager.Instance.Restore();
        UIManager.Instance.SwitchDarkBackGround(false);
        panelSettings.SetActive(false);
    }
    
    //Buttons in Event Exe
    public void ButtonOpenExePanel_OnClick()
    {
        OpenExePanel();
    }
    public void ButtonCloseExePanel_OnClick()
    {
        CloseExePanel();
    }

    public void ButtonStartEvent_OnClick()
    {
        //TODO：把原来的拖入响应事件放到这里
        UIManager.Instance.panelStartEventDialog.SetActive(false);
        var eventHandler = EventHandlerManager.Instance.GetHandlerByEventID(currentDialogEventID);
        eventHandler.OnPostInit(currentDialogEventID);
        if(DroppedImage)
            DroppedImage.SetActive(true);
        DroppedImage = null;
        UIManager.Instance.SwitchDarkBackGround(false);
    }
    
    public void ButtonCloseEventDialog_OnClick()
    {
        UIManager.Instance.panelStartEventDialog.SetActive(false);
        var eventHandler = EventHandlerManager.Instance.GetHandlerByEventID(currentDialogEventID);
        if (DroppedImage)
        {
            DroppedImage.SetActive(true);
            DroppedImage.GetComponent<DragHandlerSpecialEvent>().EndDrag();
        }
        DroppedImage = null;
        eventHandler.OnDestroyEvent();
        UIManager.Instance.SwitchDarkBackGround(false);
    }
    public void ButtonFinishDialog_OnClick()
    {
        var eventHandler = EventHandlerManager.Instance.GetHandlerByEventID(currentDialogEventID);
        eventHandler.OnPostFinish();
        UIManager.Instance.panelFinishEventDialog.SetActive(false);
        UIManager.Instance.SwitchDarkBackGround(false);
    }

    public void ButtonCloseFinishDialog_OnClick()
    {
        UIManager.Instance.panelFinishEventDialog.SetActive(false);
        UIManager.Instance.SwitchDarkBackGround(false);
        TimeTickerManager.Instance.Restore(); //恢复时间
    }

    public void ButtonEmergencyDialogChoice1_OnClick()
    {
        var eventHandler = EventHandlerManager.Instance.GetHandlerByEventID(currentDialogEventID);
        eventHandler.OnPostEmergency(1);
        UIManager.Instance.panelEmergencyDialog.SetActive(false);
        UIManager.Instance.SwitchDarkBackGround(false);
    }

    public void ButtonEmergencyDialogChoice2_OnClick()
    {
        var eventHandler = EventHandlerManager.Instance.GetHandlerByEventID(currentDialogEventID);
        eventHandler.OnPostEmergency(2);
        UIManager.Instance.panelEmergencyDialog.SetActive(false);
        UIManager.Instance.SwitchDarkBackGround(false);
    }

    public void ButtonCloseEmergencyDialog_OnClick()
    {
        UIManager.Instance.panelEmergencyDialog.SetActive(false);
        UIManager.Instance.SwitchDarkBackGround(false);
        TimeTickerManager.Instance.Restore();
    }
    public void OpenExePanel()
    {
        buttonOpenExePanel.gameObject.SetActive(false);
        buttonCloseExePanel.gameObject.SetActive(true);
        if(openExePanel_coroutine != null) StopCoroutine(openExePanel_coroutine);
        if(closeExePanel_coroutine != null) StopCoroutine(closeExePanel_coroutine);
        openExePanel_coroutine = StartCoroutine(ExePanelCoroutine(true));
    }
    public void CloseExePanel()
    {
        buttonOpenExePanel.gameObject.SetActive(true);
        buttonCloseExePanel.gameObject.SetActive(false);
        if(openExePanel_coroutine != null) StopCoroutine(openExePanel_coroutine);
        if(closeExePanel_coroutine != null) StopCoroutine(closeExePanel_coroutine);
        closeExePanel_coroutine = StartCoroutine(ExePanelCoroutine(false));
    }

    public void RefreshScrollSpecialEvent()
    {
        var events = EventManager.Instance.GetCommonEventList();

        if (m_oldSpecialEvents == null)
        {
            m_oldSpecialEvents = events;
            CreateNewSpecialEvent(events);
            return;
        }
        
        var newList = new List<CatEvent>();
        var keepList = new bool[m_oldSpecialEvents.Count];

        foreach (var catEvent in events)
        {
            var i = 0;
            for (; i < m_oldSpecialEvents.Count; i++)
            {
                if (catEvent.ID == m_oldSpecialEvents[i].ID)
                {
                    keepList[i] = true;
                    break;
                }
            }

            if (i >= m_oldSpecialEvents.Count)
            {
                newList.Add(catEvent);
            }
        }

        //先销毁再新增，防止index发生变化
        //销毁
        DestroySpecialEvent(keepList);
        
        //新增
        CreateNewSpecialEvent(newList);

        newList.AddRange(m_oldSpecialEvents);
        m_oldSpecialEvents = newList;
    }

    private void CreateNewSpecialEvent(List<CatEvent> events)
    {
        for (int i = events.Count - 1; i >= 0; i--)
        {
            var catEvent = events[i];
            
            var obj = Instantiate(specialEventPrefab).transform;
            obj.GetComponent<SpecialEventMono>().InitWithID(catEvent.ID);
            obj.SetParent(contentTransform);
            obj.SetAsFirstSibling();
            obj.localPosition = Vector3.zero;
            obj.localRotation = Quaternion.identity;
            obj.localScale = Vector3.one;
        }
    }

    private void DestroySpecialEvent(bool[] keepList)
    {
        for (int i = keepList.Length - 1; i >= 0; i--)
        {
            if (!keepList[i])
            {
                var specialEventMono = contentTransform.GetChild(i).GetComponent<SpecialEventMono>();
                if (m_oldSpecialEvents[i].Status == EventStatus.OnProcess)
                {
                    specialEventMono.SetVisible(false);
                }
                specialEventMono.DestroyAnimation();
                m_oldSpecialEvents.RemoveAt(i);
            }
        }
    }

        void Update()
    {
        var playerModel = PlayerModel.Instance;
        if (playerModel.NeedUpdate)
        {
            UpdatePanelResources();
            playerModel.NeedUpdate = false;
        }
        
        UpdateTime();
        UpdateRelationshipScale();
    }

    public void UpdateRelationshipScale()
    {
        if (bIsRelationshipScaling)
        {
            UIManager.Instance.ScaleRelationship(Mathf.Lerp(UIManager.Instance.scrollRelationShip.transform.localScale.x, relationshipScale, 8.0f * Time.deltaTime));
            if (Mathf.Abs(UIManager.Instance.scrollRelationShip.transform.localScale.x - relationshipScale) < 0.001f)
            {
                UIManager.Instance.ScaleRelationship(relationshipScale);
                bIsRelationshipScaling = false;
            }
        }
    }
    public void UpdatePanelResources()
    {
        var playerModel = PlayerModel.Instance;
        
        SetResource(textMoney, m_moneyAnimation, ref m_oldMoney, playerModel.Money);
        SetResource(textInfluence, m_influenceAnimation, ref m_oldInfluence, playerModel.Influence);
        SetResource(textHidency, m_hidencyAnimation, ref m_oldHidency, playerModel.Hidency);
    }

    private void SetResource(Text control, Animation animation, ref int oldValue, int newValue)
    {
        if (oldValue == newValue)
        {
            oldValue = newValue;
            control.text = newValue.ToString();
            control.SetAllDirty();
            return;
        }
        
        AnimationState state;
        if (newValue > oldValue)
        {
            state = animation["GetResource"];
        }
        else
        {
            state = animation["LoseResource"];
        }

        state.speed = 1;
        state.normalizedTime = 0;
        
        state.enabled = false;
        animation.Sample();
        animation.Play(state.name);

        control.text = newValue.ToString();
        oldValue = newValue;
        control.SetAllDirty();
    }

    public void UpdateTime()
    {
        System.DateTime now = TimeManager.Instance.GetTime();
        uint timeHour = (uint)now.Hour;
        uint timeMinute = (uint)now.Minute;
        uint timeMonth = (uint)now.Month;
        uint timeDate = (uint)now.Day;

        textTime.text = (timeHour < 10 ? "0" + timeHour : timeHour.ToString()) + ":" + (timeMinute < 10 ? "0" + timeMinute : timeMinute.ToString());
        textDate.text = timeMonth + "月" + timeDate + "日" + " "+ (timeHour > 6 && timeHour < 18 ? "昼" : "夜");
    }
    IEnumerator ExePanelCoroutine(bool bIsOpen)
    {
        var anchoredPosition = rectExePanel.anchoredPosition;
        float openPos = -rectExePanel.sizeDelta.x / 2.0f;
        float curPos = anchoredPosition.x;

        var velocity = 3.33f;
        for (float i = 0f; i < 0.3f; i += Time.deltaTime)
        {
            if (!bIsOpen)
            {
                curPos -= openPos * Time.deltaTime * velocity;
                if (curPos > 0) curPos = 0;
            }
            else
            {
                curPos += openPos *  Time.deltaTime * velocity;
                if (curPos < openPos) curPos = openPos;
            }

            
            var y = anchoredPosition.y;
            rectExePanel.anchoredPosition = new Vector2(curPos, y);
            // rectExePanel.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Right,curPos,rectExePanel.sizeDelta.x);
            yield return null;
        }
    }
    
    IEnumerator ScrollSpecialCoroutine(bool bIsOpen)
    {
        float openPos = 0;
        float closePos = -185f;
        float curPos = bIsOpen ? closePos : openPos;
        for (float i = 0f; i < 0.3f; i += Time.deltaTime)
        {
            if (bIsOpen)
            {
                curPos -= closePos * Time.deltaTime * 5f;
                if (curPos > 0) curPos = 0;
            }
            else
            {
                curPos += closePos * Time.deltaTime * 5f;
                if (curPos < closePos) curPos = closePos;
            }
            rectSpecialScroll.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Bottom,curPos,0);
            yield return null;
        }
    }
}
