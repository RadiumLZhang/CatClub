﻿using UnityEngine;
using System;
using Logic;
using System.Collections.Generic;
using System.Data.Common;
using System.Net.Security;
using UnityEngine.UIElements;
using Event = Logic.Event.Event;

namespace EventHandler
{
    public class DesignedEventHandler
    {

        private Cat catInfo = null;
        private Logic.Event.Event eventInfo = null;
        private int eventID = 0;
        private int cacheTime = 0;

        // constructor
        public DesignedEventHandler(Cat cat)
        {
            catInfo = cat;
        }

        public void SetEventInfo(int newEventID)
        {
            eventID = newEventID;
            eventInfo = new Logic.Event.Event(eventID);
            cacheTime = (int)eventInfo.ConsumeTime;
            TimeTickerManager.AddLastingEvent(UpdateCacheTime, 1, 1, (int)eventInfo.ConsumeTime, SetEffect);
        }

        public Logic.Event.Event GetEventInfo()
        {
            return eventInfo;
        }
        public void UpdateCacheTime()
        {
            cacheTime = cacheTime - 1;
        }
    
        public int GetTimeRemain()
        {
            return cacheTime;
        }
        
        private void SetEffect()
        {
            PlayerModel.Instance.Money = 100;
        }
    }
}