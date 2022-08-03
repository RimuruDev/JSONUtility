using System;
using System.IO;
using UnityEngine;

namespace RimuruDev.JSONUtility
{
    [Serializable]
    public sealed class JSONWriter
    {
        public static void Write(string jsonFileName, object saveObject, bool isDebugLogMode = false)
        {
            var fullPath = $"{Application.streamingAssetsPath}/{jsonFileName}.json";
            var context = JsonUtility.ToJson(saveObject);

            if (isDebugLogMode) DebugLogMode(ref jsonFileName, ref fullPath, ref context, ref saveObject);

            File.WriteAllText(fullPath, context);
        }

        public static void WriteFullPath(string fullPath, object saveObject)
        {
            try
            {
                File.WriteAllText(fullPath, JsonUtility.ToJson(saveObject));
            }
            catch (Exception ex)
            {
                Debug.LogError("RimuruDev.JSONUtility.JSONWriter...");
                Debug.LogException(ex);
                Debug.LogError($"JSONWriter.Write(string fullPath, object saveObject)\n" +
                               $"FullPath: ]{fullPath}], SaveObject: [{saveObject}]");
               throw;
            }
        }

        private static void DebugLogMode(ref string jsonFileName, ref string fullPath, ref string context, ref object saveObject)
        {
            Debug.Log($"JSON file name: [{jsonFileName}]");
            Debug.Log($"Full path: [{fullPath}]");
            Debug.Log($"Defaul path: [{Application.streamingAssetsPath}]");
            Debug.Log($"Context: [{context}]");
            Debug.Log($"Object for save to .json: [{saveObject}]");
        }
    }
}