using Microsoft.AspNet.SignalR;
using Newtonsoft.Json;

namespace tesseract
{
    public class Ceres : Hub
    {
        [JsonProperty("phase")]
        public string Phase { get; set; }

        [JsonIgnore]
        public string LastUpdatedBy { get; set; }

        public void UpdateModel(Ceres ceres)
        {
            ceres.LastUpdatedBy = Context.ConnectionId;
            Clients.AllExcept(ceres.LastUpdatedBy).updateCeres(ceres);
        }
    }
}