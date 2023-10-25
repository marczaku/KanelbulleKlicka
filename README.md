# KanelbulleKlicka
 
- Observer Pattern
- UnityEvent
  - Subscribe
  - Invoke
- Polling
- Alt+Shift for Layouting


## Quest

```csharp
public class Quest{
    public bool isAccepted;
    public bool copKilled;
}

public class StartQuestButton{
    public Quest quest;
    void OnTriggerEnter(){
       quest.isAccepted = true;
    }
}
```

- Not accepted and Not killed
- Accepted and Not Killed
- Accepted and Killed
- (Not accepted and Killed)