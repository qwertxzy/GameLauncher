using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GameLauncher.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Props
    {
        [JsonProperty("backgroundcolor")] public string BackgroundColor;
        [JsonProperty("boxcolor")] public string BoxColor;
        [JsonProperty("highlightcolor")] public string HighlightColor;
        [JsonProperty("selectedcolor")] public string SelectedColor;
        [JsonProperty("threshhold")] public int Threshold;
        [JsonProperty("horizontal_count")] public int HorizontalCount;
        [JsonProperty("vertical_count")] public int VerticalCount;
    }
}
