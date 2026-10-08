using System.Text.Json;
using Microsoft.AspNetCore.Http;

namespace blah.Extensions
{
    // Small helpers to store complex objects in session as JSON
    public static class SessionExtensions
    {
        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }   

        public static T? GetObjectFromJson<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value is null ? default : JsonSerializer.Deserialize<T>(value);
        }
    }
}
