
using OsEngine.Entity;
using OsEngine.Indicators;
using OsEngine.Language;
using OsEngine.Market;
using OsEngine.Market.Servers;
using OsEngine.OsTrader.Panels;
using OsEngine.OsTrader.Panels.Attributes;
using OsEngine.OsTrader.Panels.Tab;
using System;
using System.Collections.Generic;

namespace OsEngine.Robots.MyBots
{
    [Bot("Lesson1HellowWorld")]
    public class Lesson1HellowWorld : BotPanel
    {
        public Lesson1HellowWorld(string name, StartProgram startProgram) : base(name, startProgram)
        {
            StrategyParameterButton button = CreateParameterButton("Hellow World Button!");
            button.UserClickOnButtonEvent += Button_UserClickOnButtonEvent;

        }

        private void Button_UserClickOnButtonEvent()
        {
            SendNewLogMessage("Hello World!", Logging.LogMessageType.Error);
        }
    }
}
