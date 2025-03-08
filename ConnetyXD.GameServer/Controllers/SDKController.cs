using Microsoft.AspNetCore.Mvc;
using Serilog;
using System.Text;

namespace ConnetyXD.GameServer.Controllers
{
    [ApiController]
    [Route("/")]
    public class SDKController : ControllerBase
    {
        [Route("member/api/v1/game/auth/signin/refresh/token")]
        public IResult PostToken()
        {
            Log.Information("PostToken");
            return Results.Text(@"
{
    ""resultCode"": ""SUCCESS"",
    ""resultData"": {
        ""accessToken"": ""eyJhbGciOiJIUzI1NiJ9.eyJpbUlkIjoiV0ZFOUFCVjREWTUzUjlGNlE5QTciLCJwaklkIjoiMTAwOCIsInR5cGUiOiJTRVNTSU9OIiwic3ViIjoiNWZkNWE5MTctY2M2MS00Y2FiLWFiMDAtMWYyNTIzZTNjMzI5IiwiaXNzIjoiaHliZWltLXBsYXRmb3JtLXAiLCJhdWQiOlsiaHliZWltLWdhbWUtcCJdLCJpYXQiOjE3NDEyMzYyOTMsImV4cCI6MTc0MzgyODI5M30.MWI71W7wORvrgSneqJ85mlyRHMnCRJw_pmUMFhMLpog"",
        ""countryCode"": ""US"",
        ""imId"": ""WFE9ABV4DY53R9F6Q9A7""
    },
    ""resultMessage"": ""success""
}
", "application/json");
        }

        [Route("member/api/v1/game/auth/check/available")]
        public IResult GetCheckAvailable()
        {
            Log.Information("GetCheckAvailable");

            return Results.Text(@"
{
    ""resultCode"": ""SUCCESS"",
    ""resultData"": {
        ""adNightPush"": true,
        ""adPush"": true,
        ""advertising"": true,
        ""imId"": ""WFE9ABV4DY53R9F6Q9A7"",
        ""loginVerifyToken"": ""eyJhbGciOiJIUzI1NiJ9.eyJpbUlkIjoiV0ZFOUFCVjREWTUzUjlGNlE5QTciLCJwaklkIjoiMTAwOCIsInR5cGUiOiJMT0dJTl9WRVJJRlkiLCJzdWIiOiJhNzVmMTY0OS0yZjg1LTQ2YWEtYjMxYy1hODYzODJjNzFhODYiLCJpc3MiOiJoeWJlaW0tcGxhdGZvcm0tcCIsImF1ZCI6WyJoeWJlaW0tc2VydmVyLXAiXSwiaWF0IjoxNzQxMjM2Mjk0LCJleHAiOjE3NDEyMzk4OTR9.2CVKU6RtYxJ3kTFb4CbwDov0H_48PfJc7OYnREVGUW0""
    },
    ""resultMessage"": ""success""
}
", "application/json");
        }

        [Route("member/api/v1/game/auth/signin")]
        public IResult PostAuthSignIn()
        {
            Log.Information("PostAuthSignIn");

            return Results.Text(@"
{
    ""resultCode"": ""SUCCESS"",
    ""resultData"": {
        ""adNightPush"": true,
        ""adPush"": true,
        ""advertising"": true,
        ""imId"": ""PFFXZ28WG7LP9DEKT7Q4"",
        ""loginVerifyToken"": ""eyJhbGciOiJIUzI1NiJ9.eyJpbUlkIjoiUEZGWFoyOFdHN0xQOURFS1Q3UTQiLCJwaklkIjoiMTAwOCIsInR5cGUiOiJMT0dJTl9WRVJJRlkiLCJzdWIiOiJkYTY0YjhhMi1jNmYzLTQzYzAtYTVjMy02MGFjZTM5MmM4ZGUiLCJpc3MiOiJoeWJlaW0tcGxhdGZvcm0tcCIsImF1ZCI6WyJoeWJlaW0tc2VydmVyLXAiXSwiaWF0IjoxNzQxMjU5MzE4LCJleHAiOjE3NDEyNjI5MTh9.rZrDRK05mRE0vdUGVAyJD3GfubUQCHfkjWxsgbxlzlc""
    },
    ""resultMessage"": ""success""
}
");
        }

        [HttpGet("{*catchAll}")]
        public IResult CatchAllGet(string catchAll)
        {
            Log.Information($"HttpGet: {catchAll}");
            return Results.Empty;
        }

        [HttpPost("{*catchAll}")]
        public IResult CatchAllPost(string catchAll)
        {
            Log.Information($"HttpGet: {catchAll}");
            return Results.Empty;
        }
    }
}

