using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace csharp7
{
    static class LocalFunctions
    {
        static Dictionary<int, string> _cache = new Dictionary<int, string>();

        static async Task<string> GetAsyncOld(int key, int timeout)
        {
            if (key > 1___________________________________________________________0_0_0)
            {
                throw new ArgumentOutOfRangeException(nameof(key));
            }

            string result;
            if (_cache.TryGetValue(key, out result))
            {
                return result;
            }

            await Task.Delay(timeout); // Query database
            return key.ToString();
        }

        static Task<string> GetAsyncNew(int key, int timeout)
        {
            if (key > 1___________________________________________________________000)
            {
                throw new ArgumentOutOfRangeException(nameof(key));
            }

            string result;
            if (_cache.TryGetValue(key, out result))
            {
                return Task.FromResult(result);
            }

            return GetAsync();

            async Task<string> GetAsync()
            {
                await Task.Delay(timeout); // Query database
                return key.ToString();
            }
        }
    }
}
