using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class CatColumnHandler : MonoBehaviour,
    IDropHandler
{
    private Logic.Event.Event myEventInfo;
    private DragHandlerSpecialEvent droppedEvent;
    private long myID = -1;
    
    //remainingTime维护剩余时间
    private long remainingTime;
    
    public void OnDrop(PointerEventData eventData)
    {
        //TODO:为你的猫咪Handler注册事件
        droppedEvent = eventData.pointerDrag.GetComponent<DragHandlerSpecialEvent>();
        myID = droppedEvent.GetEventID();
        
        //TODO:demo里不读表的话就自己写下myEventInfo结构体，有ID,Name,ConsumeTime和sprite即可
        myEventInfo = new Logic.Event.Event(myID);
        transform.Find("ImageEvent").GetComponent<Image>().sprite = Resources.Load<Sprite>(myEventInfo.Image);
        transform.Find("ImageEvent").Find("EventTimeBackground").gameObject.SetActive(true);
        
        //用表中的ConsumeTime(需要消耗的时间)初始化remainingTime
        remainingTime = myEventInfo.ConsumeTime;
        transform.Find("ImageEvent").Find("EventTimeBackground").Find("TextEventTime").GetComponent<Text>().text = Convert.ToString(remainingTime) + "秒";
        droppedEvent.EndDrag();
        Destroy(droppedEvent.transform.parent.gameObject);
    }

    public static void SendEventDestroyEvent(long id)
    {
        return;
    }
    void Update()
    {
        //只要栏位中有事件(即ID不是默认的-1)就用remainingTime刷新UI显示
        if(myID != -1)
            transform.Find("ImageEvent").Find("EventTimeBackground").Find("TextEventTime").GetComponent<Text>().text = Convert.ToString(remainingTime) + "秒";
    }
    
    //TODO:事件完成时调这个方法清空栏位，可以是(0 == remainingTime)的时候？
    public void OnFinish()
    {
        //TODO:用猫咪Handler调事件完成方法（影响议会资源之类的）
        //设置好Logic.PlayerModel的资源参数后，调如下方法刷新右上角三个资源的UI
        //（其实把这方法放在GameView.cs的update里就不用调了，只是占资源）
        GameObject.Find("Canvas").GetComponent<GameView>().UpdatePanelResources();
        //清空UI的栏位并重设当前ID为-1
        transform.Find("ImageEvent").GetComponent<Image>().sprite = null;
        transform.Find("ImageEvent").Find("EventTimeBackground").gameObject.SetActive(false);
        myID = -1;
    }
    
    //调这个方法减少remainingTime实现读秒，看着办...
    public void TimeDecrease()
    {
        remainingTime--;
    }
}
