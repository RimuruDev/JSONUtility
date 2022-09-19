#### [[На русском языки](/README_ru.md) - [In Russian](/README_ru.md)] | [[На английском языки](/README.md) - [In English](/README.md)]

# [RimuruDev](https://www.youtube.com/channel/UCcE4Ho3vmXj_vrg5rI7bpAA) JSON утилита для Unity

# Как начать
Загрузите последнюю версию этой утилиты.  Распакуйте .dll и .json и перенесите их в юнити, в папку Plagins.

## Не забывайте namespace

```csharp
using RimuruDev.JSONUtility;
```

# Сохранение в JSON
Компонент для сохранения в .json
```csharp
[System.Serializable]
public class User
{
    public int id;
    public string name;
}
```
Пример сохранения компонента
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
UserData — это имя файла типа .json.
user — это данные, которые мы сериализуем в .json
```csharp
JSONWriter.Write("UserData", user);
```

# Чтение из JSON
JSONReader - Чтение .json файла
UserData - Это имя файла типа .json
```csharp
JSONReader<User>.Read("UserData");
```
Пример чтения компонента
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
# Полный пример
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
