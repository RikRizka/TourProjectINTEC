using ConsumeApi_Klas.Models;
using System.Net.Http;
using System.Net.Http.Json;

namespace ConsumeApi_Klas.Services
{

    public class ApiService
    {
        private readonly HttpClient _httpClient; //HttpCline adalah dari jeso
        public ApiService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:7157/api/"); //copy hanya angka saja
        }
        //buat Methode untuk mebaca List untuk mendapatkan semua informasi
        //Mtegode ini membaca data Reservations
        public async Task<IEnumerable<ReservationDetailsDto>>etReservations()
        {

            var response = await _httpClient.GetAsync("Reservations");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<IEnumerable<ReservationDetailsDto>>();

        }
    }
}


