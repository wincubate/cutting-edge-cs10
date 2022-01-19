using System.Collections.Generic;
using System.Net.Http;
using System.Threading;

namespace Wincubate.CS9.ExtensionAsyncEnumerableLab
{
    public record UrlResult(string Url, string Contents);

    static class ListExtensions
    {
        public async static IAsyncEnumerator<UrlResult> GetAsyncEnumerator(
            this List<string> urls,
            CancellationToken cancellationToken = default
        )
        {
            using var client = new HttpClient();

            foreach (string url in urls)
            {
                yield return new UrlResult(
                    url,
                    await client.GetStringAsync(url, cancellationToken)
                );
            }
        }
    }
}