﻿using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Event;

namespace Event
    public class EventManager : MonoBehaviour
    {

        private static EventManager instance = null;
        
        // constructor
        private EventManager
        {
            List<DesignedEventHandler> EventHandlerList; //控制长度为4
            List<CatList> 
        }

        
        //accessor
        public static EventManager GetEventManager()
        {
            if (instance == null)
            {
                instance = new EventManager();
            }

            return instance;
        }

        private void Start()
        {
            List<ActiveEvent> activeEvents = new List<ActiveEvent>();
            
        }
        
        // 猫咪作为handler的一个属性
        public int InitalizeNewEvent(Event event, Cat cat)
        {
            
            EventHandlerList.Add(new EventHandler(cat, event));
        }
        

        public int GetHandlerID(CatInfo cat){
            
        }
}