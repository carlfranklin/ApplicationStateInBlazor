public interface IAppState
{
    int TimeToLiveInSeconds { get; set; }
    DateTime LastAccessed { get; set; }
    string Message { get;  }
    bool Enabled { get;  }
    int Counter { get;  }
}