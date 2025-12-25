namespace UserLoginGUI_ApiEndpoints
{
    public static class EndpointClass
    {
        private static string BaseUrl { get; set; } = "https://localhost:7165/api/v1/UserLoginGUI";
        public static string RegEndpoint { get; set; } = BaseUrl + "/Registration";
        public static string LoginEndpoint { get; set; } = BaseUrl + "/UserLogin";
        public static string BaseImageUrl { get; set; } = "https://localhost:7165";
        public static string ItemPostUrl { get; set; } = BaseUrl + "/ItemPost";
        public static string GetRecordsUrl { get; set; } = BaseUrl + "/GetItemRecords";
        public static string DeleteRowsUrl { get; set; } = BaseUrl + "/DeleteRow?RowId=";
    }
}
