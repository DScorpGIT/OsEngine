using System;
using System.Collections.Generic;
using System.Text;
using OsEngine.Entity;
using OsEngine.OsTrader.Panels;
using OsEngine.OsTrader.Panels.Attributes;


namespace OsEngine.Robots.MyBots
{
    [Bot("Lesson2_FirstBot")]
    public class Lesson2_FirstBot : BotPanel
    {
        public Lesson2_FirstBot(string name, StartProgram startProgram) : base(name, startProgram)
        {
            StrategyParameterButton button = CreateParameterButton("Test strin");
            button.UserClickOnButtonEvent += Button_UserClickOnButtonEvent;

            StrategyParameterString regime = CreateParameter("Regime", "Off", new[] { "Off", "On" });
            StrategyParameterInt smaLen = CreateParameter("SMA Len", 15, 1, 20, 1);
            StrategyParameterBool isUpCandleToEntry = CreateParameter("Is up candle", false);
            StrategyParameterDecimal bollingDeviation = CreateParameter("Bolling deviation", 1.4m, 1, 2, 0.1m);
            StrategyParameterTimeOfDay startToTrade = CreateParameterTimeOfDay("Start to trade", 11, 0, 0, 0);
        }

        private void Button_UserClickOnButtonEvent()
        {
            string str1 = "Hellow ";
            string str2 = "World";

            string result = str1 + str2;
            SendNewLogMessage(result, Logging.LogMessageType.Error);

        }
    }
}
