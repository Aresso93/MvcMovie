using System.ComponentModel;

namespace MvcMovie.Models
{
    public enum Rating { 
        [Description("Absolute crap")]
    Absolute_Crap = 1,
        [Description("Slightly Crap")]
    Slightly_Crap,
        [Description("Average")]
    Average,
        [Description("Okish")]
    Okish,
        [Description("Masterpiece")]
    Masterpiece
        
    }

}
