﻿using Mystivate.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mystivate.Logic
{
    public interface IQuestLogic
    {
        void SelectQuest();
        QuestModel GetCurrentQuest();
    }
}
