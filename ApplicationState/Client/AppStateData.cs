public class AppStateData : IAppState
{
    public int TimeToLiveInSeconds { get; set; }
    public DateTime LastAccessed { get; set; }
    public string Message { get; set; } = "";
    public bool Enabled { get; set; }
    public int Counter { get; set; }
}