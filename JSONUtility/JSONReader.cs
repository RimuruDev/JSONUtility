using UnityEngine;

namespace RimuruDev.JSONUtility
{
    [System.Serializable]
    public sealed class JSONReader<T>
    {
        private string path;

        public T Read(string pathToJSONData)
        {
            using WWW data = new WWW($"{Application.streamingAssetsPath}/{pathToJSONData}");

            var tmpPlayer = JsonUtility.FromJson<T>(data.text);

            return tmpPlayer;
        }

        public T Read()
        {
            using WWW data = new WWW($"{Application.streamingAssetsPath}/{path}");

            var tmpPlayer = JsonUtility.FromJson<T>(data.text);

            return tmpPlayer;
        }

        public JSONReader() { }

        public JSONReader(string path) => this.path = path;
    }
}