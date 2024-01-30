namespace Impart.UI.Navigation;

public interface INavigator
{
    bool CanGoBack { get; }

    bool CanGoForward { get; }

    int MaxViewCacheSize { get; set; }

    Guid Id { get; }

    IReadOnlyList<Type> Views { get; }

    bool Pop();

    bool Push(Type viewModelType);

    bool Push<TViewModel>() where TViewModel : IViewModel;

    void Reset();
}