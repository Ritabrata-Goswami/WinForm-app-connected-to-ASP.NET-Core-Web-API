namespace UserLoginGUI_ApiEndpoints
{
    public static class EndpointClass
    {
        private static string BaseUrl { get; set; } = "https://localhost:7165/api/v1/UserLoginGUI";
        public static string RegEndpoint { get; set; } = BaseUrl + "/Registration";
        public static string LoginEndpoint { get; set; } = BaseUrl + "/UserLogin";
        public static string BaseImageUrl { get; set; } = "https://localhost:7165";
    }
}
