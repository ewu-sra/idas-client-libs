﻿using System;
using System.Threading.Tasks;

namespace Gandalan.Client.Contracts.Navigation
{
    public interface INavigationItem
    {
        string Group { get; }
        string Caption { get; }
        object Icon { get; }
        int Order { get; }

        Func<Task> Execute { get; } 
    }
}