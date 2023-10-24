using System;
using System.Net.Http;
using System.Threading.Tasks;

public class ApiClient
{

    static private HttpClient httpClient;

    public static async Task<string> GetRequestAsync(string tipoRequest, string url)
    {
        httpClient = new HttpClient();

        switch (tipoRequest)
        {
            case "GET":
                return await httpClient.GetStringAsync(url);
            case "POST":

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
