namespace FeatureFlags {
    using Unleash;

    public class FeatureFlagsReader {
        readonly DefaultUnleash _defaultUnleash;

        public FeatureFlagsReader() =>
            _defaultUnleash = new(new()
            {
                AppName = "whathever-app-it-is",
                InstanceTag = "{Instance ID}",
                UnleashApi = new("{API URL}")
            });

        public bool ReadFor(string flagName) => _defaultUnleash.IsEnabled(flagName);
    }
}