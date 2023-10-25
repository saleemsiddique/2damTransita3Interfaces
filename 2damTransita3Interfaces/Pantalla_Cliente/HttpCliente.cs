using System;
using System.Net.Http;
using System.Threading.Tasks;

public class ApiClient
{

    static private HttpClient httpClient;

    public static async Task<string> GetRequestAsync(string tipoRequest, string url, string token = null)
    {
        httpClient = new HttpClient();

        if (!string.IsNullOrEmpty(token))
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
        }

        switch (tipoRequest)
        {
            case "GET":
                return await httpClient.GetStringAsync(url);
            case "POST":
                //return await httpClient.PostAsync(url);
                break;
            case "PUT":

                break;
            case "DELETE":
                var response = await httpClient.DeleteAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    return "Solicitud DELETE exitosa.";
                }
                else
                {
                    throw new Exception("Error al realizar la solicitud DELETE.");
                }
                break;
            default:
                break;
        }

        return null;
    }

}
