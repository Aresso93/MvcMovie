using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public enum Rating { 
        //[DisplayName("Absolute crap")]
    Absolute_Crap = 1,
        //[Description("Slightly Crap")]
    Slightly_Crap,
        //[Description("Average")]
    Average,
        //[Description("Okish")]
    Okish,
        //[Description("Masterpiece")]
    Masterpiece
        
    }

}
