using System;
using UnityEngine;

namespace RimuruDev.JSONUtility
{
    [Serializable]
    public sealed class JSONReader<T>
    {
        public static T Read(string jsonFileName, bool isDefaultPath = true)
        {
            try
            {
                WWW data = null;

                if (isDefaultPath)
                    data = new WWW($"{Application.streamingAssetsPath}/{jsonFileName}.json");
                else
                    data = new WWW(jsonFileName);

                return JsonUtility.FromJson<T>(data.text);
            }
            catch (Exception ex)
            {
                Debug.LogError("RimuruDev.JSONUtility.JSONReader<T>...");
                Debug.LogException(ex);
                Debug.LogError($"JSONReader<{typeof(T)}>.{typeof(T)} Read(string {jsonFileName}");
                throw;
            }
        }
    }
}