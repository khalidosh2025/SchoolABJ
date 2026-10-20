public class TabsState
{
    public bool ShowClassVisitsTabs { get; private set; }
    public event Action? OnChange;

    public void ShowTabs()
    {
        ShowClassVisitsTabs = true;
        NotifyStateChanged();
    }

    public void HideTabs()
    {
        ShowClassVisitsTabs = false;
        NotifyStateChanged();
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
}