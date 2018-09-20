using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GameLauncher.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Keybindings
    {
        [JsonProperty("exit")] public int ExitKey;
        [JsonProperty("forwards")] public int ForwardsKey;
        [JsonProperty("reverse")] public int ReverseKey;
        [JsonProperty("select")] public int SelectKey;
    }
}
