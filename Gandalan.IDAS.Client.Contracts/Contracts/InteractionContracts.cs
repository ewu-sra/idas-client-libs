﻿using Gandalan.Client.Common.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gandalan.Client.Common.Contracts
{
    public interface IInteractivePanel : INotifyPropertyChanged
    {
        string Caption { get; }    
        bool IsLoading { get; }
    }

    public interface IEditorPanel : IInteractivePanel
    {
        Task<bool> Save();
        bool Cancel();
        bool Pause();
        bool PausePossible { get; }
    }

    public interface IDisplayPanel : IInteractivePanel
    {     
    }

    public interface ILookupDialog<T, U>
    {
        T Execute(U data);
    }

    public interface IQuickEditDialog<T>
    {
        T Execute();
    }
}