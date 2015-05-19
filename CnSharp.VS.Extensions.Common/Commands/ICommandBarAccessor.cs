﻿using System.Collections.Generic;
using Microsoft.VisualStudio.CommandBars;

namespace CnSharp.VisualStudio.Extensions.Commands
{
    public interface ICommandBarAccessor
    {
        //Plugin Plugin { get; set; }
        void AddControl(CommandControl control);
        void ResetControl(CommandControl control);
        void EnableControls(IEnumerable<string> ids ,bool enabled);
        void Delete();
    }
}
