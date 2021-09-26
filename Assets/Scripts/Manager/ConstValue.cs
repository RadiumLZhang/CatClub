﻿namespace Manager
{
    public class ConstValue
    {
        // 游戏开始年份
        public const int YEAR = 2021;
        
        // 游戏开始月份
        public const int MONTH = 9;
        
        // 游戏开始日期
        public const int DAY = 24;
        
        // 现实中的一秒对应游戏中的x秒, TimeManager当中使用
        public const int TIME_STEP = 20;
        
        // TimeTickerManager每秒执行多少次
        public const int TIME_TICKER_STEP = 20;
    }
}