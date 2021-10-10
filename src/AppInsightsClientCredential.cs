// using System;
// using System.Net.Http;
// using System.Net.Http.Headers;
// using System.Threading;
// using System.Threading.Tasks;
// using Azure.Core;
// using Azure.Identity;
// using Microsoft.IdentityModel.Clients.ActiveDirectory;
// using Microsoft.Rest;
// using Microsoft.Rest.Azure.Authentication;

// namespace FluentKusto
// {
//     public class AppInsightsClientCredential : ServiceClientCredentials
//     {
//         private string AuthenticationToken { get; set; }
//         public async override void InitializeServiceClient<T>(ServiceClient<T> client)
//         {
//             try
//             {
//                 var authEndpoint = "https://login.microsoftonline.com";
//                 var tokenAudience = "https://api.applicationinsights.io/";

//                 var aadSettings = new ActiveDirectoryServiceSettings
//                 {
//                     AuthenticationEndpoint = new Uri(authEndpoint),
//                     TokenAudience = new Uri(tokenAudience),
//                     ValidateAuthority = true,

//                 };

//                 var azcred = new DefaultAzureCredential();

//                 ApplicationTokenProvider.LoginSilentAsync("", azcred, aadSettings);

//                 )

//                 // var authenticationContext = new AuthenticationContext("https://login.windows.net/{tenantID}");
//                 // var credential = new ClientCredential(clientId: "xxxxx-xxxx-xx-xxxx-xxx", clientSecret: "{clientSecret}");

//                 // var result = authenticationContext.AcquireToken(resource: "https://management.core.windows.net/", clientCredential: credential);

//                 // if (result == null) throw new InvalidOperationException("Failed to obtain the JWT token");
//                 var accessToken = await azcred.GetTokenAsync(
//                         new TokenRequestContext(
//                                 new string[]{"https://api.applicationinsights.io"}));

//                 AuthenticationToken = accessToken.Token;
//             }
//             catch(Exception ex)
//             {
//                 throw ex;
//             }

//         }
//         public override async Task ProcessHttpRequestAsync(HttpRequestMessage request, CancellationToken cancellationToken)
//         {
//             if (request == null) throw new ArgumentNullException("request");

//             if (AuthenticationToken == null) throw new InvalidOperationException("Token Provider Cannot Be Null");

//             request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", AuthenticationToken);
//             request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

//             //request.Version = new Version(apiVersion);
//             await base.ProcessHttpRequestAsync(request, cancellationToken);
//         }
//     }
// }