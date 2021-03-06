﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ERAServer.Data.Enum
{
    [Flags]
    internal enum InteractableStateFlags : byte
    {
        /// <summary>
        /// No state flags set
        /// </summary>
        None = 0,

        /// <summary>
        /// When through, will not block other interactables
        /// </summary>
        Through = (1 << 0),

        /// <summary>
        /// When visible, will use graphic/body to display itself
        /// </summary>
        Visible = (1 << 1),

        /// <summary>
        /// When event running, will stop all input but event 
        /// </summary>
        EventRunning = (1 << 2),
        
        /// <summary>
        /// When locked, direction can not be changed, unless explicitly called
        /// </summary>
        Locked  = (1 << 3),

        /// <summary>
        /// When bush, is on a bush tile
        /// </summary>
        Bush    = (1 << 4),
    }
}
