﻿namespace BluDay.Common.UI.WindowManagement;

public interface IWindowService : IDisposable
{
    IWindow? MainWindow { get; }

    int WindowCount { get; }

    IReadOnlyList<IWindow> Windows { get; }

    IWindow? CreateWindow();

    bool HasWindow(IWindow window);
}