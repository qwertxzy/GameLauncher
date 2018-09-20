using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GameLauncher.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Game
    {
        [JsonProperty("executable")] public string ExecutablePath;
        [JsonProperty("icon")] public string IconPath;
        [JsonProperty("parameters")] public string Parameters;
        [JsonProperty("text")] public string Text;
    }
}
