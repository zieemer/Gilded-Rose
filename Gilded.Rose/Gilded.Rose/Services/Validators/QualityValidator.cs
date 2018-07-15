using Gilded.Rose.Conracts;
using Gilded.Rose.Models;

namespace Gilded.Rose.Services.Validators
{
    public class QualityValidator : IQualityValidator
    {
        public int ValidateQuality(int quality)
        {
            if (quality > 50) return 50;
            if (quality < 0) return 0;
            return quality;
        }
    }
}