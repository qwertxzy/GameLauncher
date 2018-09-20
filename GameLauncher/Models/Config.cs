using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace GameLauncher.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Config
    {
        [JsonProperty("games")] public List<Game> Games;
        [JsonProperty("keybindings")] public Keybindings Bindings;
        [JsonProperty("misc")] public Props Misc;
    }
}
