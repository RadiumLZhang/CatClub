using System;
using System.Collections;
using System.Collections.Generic;
using EventHandler;
using Logic.Event;
using Manager;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CatColumnHandler : MonoBehaviour, IDropHandler
{
    private Logic.Event.CatEvent m_myCatEventInfo;
    private DragHandlerSpecialEvent droppedSpecialEvent;
    private DragHandlerNPCEvent droppedNPCEvent;
    
    public int index;
    private long myID = -1;

    //remainingTime维护剩余时间
    private long remainingTime;

    private Transform imageRemainingTime;
    private Text textRemainingTime;
    
    void Start()
    {
        imageRemainingTime = transform.Find("CatPortrait").Find("ImageRemainingTime");
        textRemainingTime = imageRemainingTime.Find("TextRemainingTime").GetComponent<Text>();
    }
    public void OnDrop(PointerEventData eventData)
    {
        if ((droppedSpecialEvent = eventData.pointerDrag.GetComponent<DragHandlerSpecialEvent>()) != null)
        {
            if (droppedSpecialEvent.bIsExtracting)
            {

                myID = droppedSpecialEvent.GetEventID();
                DesignedEventHandler eventHandler = EventHandlerManager.Instance.GetHandlerByID(index);
                eventHandler.SetEventInfo((int) myID);
                
                m_myCatEventInfo = eventHandler.GetEventInfo();
                UIManager.Instance.InitStartEventDialog(m_myCatEventInfo);
                //TODO:这里需要暂停一下，点击弹窗中的“行动开始”后再执行后续步骤，按钮回调函数是GameView.cs line 171 ButtonStartEvent_OnClick()
                
                m_myCatEventInfo.Status = EventStatus.OnProcess;
                transform.Find("ImageEvent").GetComponent<Image>().sprite = Resources.Load<Sprite>(m_myCatEventInfo.Imageout);
                transform.Find("ImageEvent").GetComponent<Image>().enabled = true;

                remainingTime = eventHandler.GetTimeRemain();
                textRemainingTime.text = Convert.ToString(remainingTime) + "s";
                imageRemainingTime.gameObject.SetActive(true);

                droppedSpecialEvent.EndDrag();
                Destroy(droppedSpecialEvent.transform.parent.gameObject);
                transform.GetComponent<Image>().raycastTarget = false;
            }
        }
        else if ((droppedNPCEvent = eventData.pointerDrag.GetComponent<DragHandlerNPCEvent>()) != null)
        {
            myID = droppedNPCEvent.GetEventID();
            DesignedEventHandler eventHandler = EventHandlerManager.Instance.GetHandlerByID(index);
            eventHandler.SetEventInfo((int) myID);
                
            m_myCatEventInfo = eventHandler.GetEventInfo();
            UIManager.Instance.InitStartEventDialog(m_myCatEventInfo);
            //TODO:这里需要暂停一下，点击弹窗中的“行动开始”后再执行后续步骤，按钮回调函数是GameView.cs line 171 ButtonStartEvent_OnClick()
            transform.Find("ImageEvent").GetComponent<Image>().sprite = Resources.Load<Sprite>(m_myCatEventInfo.Imageout);
            transform.Find("ImageEvent").GetComponent<Image>().enabled = true;
                
            remainingTime = eventHandler.GetTimeRemain();
            textRemainingTime.text = Convert.ToString(remainingTime) + "s";
            imageRemainingTime.gameObject.SetActive(true);
                
            droppedNPCEvent.EndDrag();
            //TODO:删除该NPC池子中的事件
            droppedNPCEvent.GetComponent<Image>().sprite = null;
            droppedNPCEvent.gameObject.SetActive(false);
            transform.GetComponent<Image>().raycastTarget = false;
        }
    }

    public static void SendEventDestroyEvent(long id)
    {
        return;
    }

    void Update()
    {
        DesignedEventHandler eventHandler = EventHandlerManager.Instance.GetHandlerByID(index);
        remainingTime = eventHandler.GetTimeRemain();
        //只要栏位中有事件(即ID不是默认的-1)就用remainingTime刷新UI显示
        if (myID != -1)
            textRemainingTime.text = Convert.ToString(remainingTime) + "s";
        if (remainingTime == 0)
            OnFinish();
        
    }

    //TODO:事件完成时调这个方法清空栏位，可以是(0 == remainingTime)的时候？
    public void OnFinish()
    {
        transform.Find("ImageEvent").GetComponent<Image>().enabled = false;
        transform.Find("ImageEvent").GetComponent<Image>().sprite = null;
        imageRemainingTime.gameObject.SetActive(false);
        myID = -1;
        transform.GetComponent<Image>().raycastTarget = true;
        droppedSpecialEvent = null;
        droppedNPCEvent = null;
    }
}
    
