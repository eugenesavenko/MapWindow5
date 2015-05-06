﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MW5.Api.Events;
using MW5.Api.Legend.Events;
using MW5.Plugins.Identifier.Controls;
using MW5.Plugins.Identifier.Enums;
using MW5.Plugins.Mvp;

namespace MW5.Plugins.Identifier.Views
{
    public interface IIdentifierView : IMenuProvider
    {
        IdentifierPluginMode Mode { get; }
        bool ZoomToShape { get; }
        void Clear();
        event Action ModeChanged;
        event EventHandler<ShapeEventArgs> ShapeSelected;
        void UpdateView();
    }
}
