using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class ApiClient
{
    static private HttpClient httpClient;

    public static async Task<string> GetRequestAsync(string tipoRequest, string url, string token = null, string content = null)
    {
        httpClient = new HttpClient();

        if (!string.IsNullOrEmpty(token))
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
        }

        HttpContent httpContent = null;

        if (!string.IsNullOrEmpty(content))
        {
            httpContent = new StringContent(content, Encoding.UTF8, "application/json");
        }

        switch (tipoRequest)
        {
            case "GET":
                return await httpClient.GetStringAsync(url);

            case "POST":
                var postResponse = await httpClient.PostAsync(url, httpContent);
                if (postResponse.IsSuccessStatusCode)
                {
                    return "Solicitud POST exitosa.";
                }
                else
                {
                    throw new Exception("Error al realizar la solicitud POST.");
                }

            case "PUT":
                var putResponse = await httpClient.PutAsync(url, httpContent);
                if (putResponse.IsSuccessStatusCode)
                {
                    return "Solicitud PUT exitosa.";
                }
                else
                {
                    throw new Exception("Error al realizar la solicitud PUT.");
                }

            case "DELETE":
                var deleteResponse = await httpClient.DeleteAsync(url);
                if (deleteResponse.IsSuccessStatusCode)
                {
                    return "Solicitud DELETE exitosa.";
                }
                else
                {
                    throw new Exception("Error al realizar la solicitud DELETE.");
                }

            default:
                break;
        }

        return null;
    }
}
