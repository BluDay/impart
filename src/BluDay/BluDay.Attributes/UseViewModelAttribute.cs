﻿namespace BluDay.Attributes;

public sealed class UseViewModelAttribute<TViewModel> : Attribute where TViewModel : IViewModel
{
    public UseViewModelAttribute() { }
}