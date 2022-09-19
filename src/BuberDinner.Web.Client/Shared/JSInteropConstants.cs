namespace BuberDinner.Web.Client.Shared
{
    public static class JsInteropConstants
    {
        private const string FuncPrefix = "mmtScripts";

        public const string GetSessionStorage = $"{FuncPrefix}.getSessionStorage";

        public const string SetSessionStorage = $"{FuncPrefix}.setSessionStorage";
    }
}