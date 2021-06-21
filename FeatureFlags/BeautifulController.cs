namespace FeatureFlags {
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class BeautifulController : ControllerBase {
        readonly FeatureFlagsReader _featureFlagsReader;

        public BeautifulController(FeatureFlagsReader featureFlagsReader) => _featureFlagsReader = featureFlagsReader;

        [HttpGet("/featureFlag")]
        public string GetFeatureFlags() => _featureFlagsReader.ReadFor("feature-is-here").ToString();
    }
}