# [RimuruDev](https://www.youtube.com/channel/UCcE4Ho3vmXj_vrg5rI7bpAA) JSON Utility for unity

# How to start
Download the latest release of this utility. Unpack the .dll and .json and transfer them to the unity, to the Plugin folder.

## Don't forget NameSpace 

```csharp
using RimuruDev.JSONUtility;
```

# Save to JSON
Component to save to .json
```csharp
[System.Serializable]
public class User
{
    public int id;
    public string name;
}
```
Component Saving Example
```csharp
public class Exemple : MonoBehaviour
{
    public User user;

    private void SaveToJSON()
    {
        JSONWriter.Write("UserData", user);
    }
}
```
UserData - This is the name of a .json type file
user - This is the data that we serialize in .json
```csharp
JSONWriter.Write("UserData", user);
```

# Reading to JSON
JSONReader - Reading .json file
UserData - This is the name of a .json type file
```csharp
JSONReader<User>.Read("UserData");
```
Component Reading Example
```csharp
public class Exemple : MonoBehaviour
{
    public User user;

    private void SaveToJSON()
    {
        JSONWriter.Write("UserData", user);
    }

    private void LoadFromJSON()
    {
        var readedData = JSONReader<User>.Read("UserData");

        user.id = readedData.id;
        user.name = readedData.name;
    }
}
```
# Full Example
```csharp
public class Exemple : MonoBehaviour
{
    public User user;

    private void SaveToJSON()
    {
        JSONWriter.Write("UserData", user);
    }

    [Obsolete]
    private void LoadFromJSON()
    {
        var readedData = JSONReader<User>.Read("UserData");

        user.id = readedData.id;
        user.name = readedData.name;
    }

    [Obsolete]
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
            SaveToJSON();

        if (Input.GetKeyDown(KeyCode.L))
            LoadFromJSON();
    }
}
```
